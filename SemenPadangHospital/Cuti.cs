using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace SemenPadangHospital
{
    public partial class Cuti : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;

        public Cuti()
        {
            InitializeComponent();
            //alamat = "server=sql6.freemysqlhosting.net; database=sql6124227; username=sql6124227; password=uYpxJkn9kX;";
            alamat = "server=localhost; database=db_sph; username=root; password=;";
            //alamat = "server=192.168.150.40; database=db_sph; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            MainFormLoad(null, null);
        }
        void MainFormLoad(object sender, EventArgs e)
        {
            try
            {
                //comboBox1.Items.Add(mdr.GetString("fname"));

                koneksi.Open();
                query = string.Format("select * from cuti_karyawan");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                dgv_cuti.DataSource = ds.Tables[0];
                dgv_cuti.Columns[0].Width = 30;
                dgv_cuti.Columns[0].HeaderText = "No";
                dgv_cuti.Columns[1].Width = 100;
                dgv_cuti.Columns[1].HeaderText = "Karyawan";
                dgv_cuti.Columns[2].Width = 100;
                dgv_cuti.Columns[2].HeaderText = "Cuti";
                dgv_cuti.Columns[3].Width = 100;
                dgv_cuti.Columns[3].HeaderText = "Periode";
                dgv_cuti.Columns[4].Width = 100;
                dgv_cuti.Columns[4].HeaderText = "Sisa";
                dgv_cuti.Columns[5].Width = 100;
                dgv_cuti.Columns[5].HeaderText = "Ambil";
                dgv_cuti.Columns[6].Width = 100;
                dgv_cuti.Columns[6].HeaderText = "Kembali";
                dgv_cuti.Columns[7].Width = 100;
                dgv_cuti.Columns[7].HeaderText = "Batas";
                

                dtpcuti.Format = DateTimePickerFormat.Custom;
                dtpcuti.CustomFormat = "dd-MMM-yyyy";
                dtcuti.Format = DateTimePickerFormat.Custom;
                dtcuti.CustomFormat = "dd-MMM-yyyy";

                dtpperiode.Format = DateTimePickerFormat.Custom;
                dtpperiode.CustomFormat = "dd-MMM-yyyy";
                dtperiode.Format = DateTimePickerFormat.Custom;
                dtperiode.CustomFormat = "dd-MMM-yyyy";

                dtpambil.Format = DateTimePickerFormat.Custom;
                dtpambil.CustomFormat = "dd-MMM-yyyy";
                dtambil.Format = DateTimePickerFormat.Custom;
                dtambil.CustomFormat = "dd-MMM-yyyy";

                dtpbatas.Format = DateTimePickerFormat.Custom;
                dtpbatas.CustomFormat = "dd-MMM-yyyy";
                dtbatas.Format = DateTimePickerFormat.Custom;
                dtbatas.CustomFormat = "dd-MMM-yyyy";

                dtkembali.Format = DateTimePickerFormat.Custom;
                dtkembali.CustomFormat = "dd-MMM-yyyy";

                tbcarinm.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bersih()
        {
            tbnama.Clear();
            tbnama_.Clear();
            tbcarinm.Clear();

            dtcuti.Value = DateTime.Now;
            dtpcuti.Value = DateTime.Now;

            dtperiode.Value = DateTime.Now;
            dtpperiode.Value = DateTime.Now;

            cmbsisa.SelectedItem = null;
            cbsisa.SelectedItem = null;

            dtambil.Value = DateTime.Now;
            dtpambil.Value = DateTime.Now;

            dtkembali.Value = DateTime.Now;

            dtbatas.Value = DateTime.Now;
            dtpbatas.Value = DateTime.Now;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda logout dari aplikasi cuti?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new Welcome().Show();
                this.Hide();
            }
            
        }

        private void tbcarinm_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbcarinm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cari_nama();
            }
        }

        private void cari_nama()
        {
            try
            {
                if (tbcarinm.Text != "")
                {
                    query = string.Format("SELECT * FROM `cuti_karyawan` WHERE `nama` LIKE '%" + tbcarinm.Text + "%' >= 1");
                    ds.Clear();
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    perintah.ExecuteNonQuery();
                    adapter.Fill(ds);
                    koneksi.Close();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow kolom in ds.Tables[0].Rows)
                        {   
                            
                        }
                        dgv_cuti.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Nama Belum Terdaftar");
                        MainFormLoad(null, null);
                    }

                }
                else
                {
                    MessageBox.Show("Data Yang Anda Pilih Tidak Ada !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            bersih();
            MainFormLoad(null, null);
        }

        private void Cuti_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            simpan();
        }

        private void simpan()
        {
            //dateTimePicker.Value.Date.ToString("yyyyMMdd")
            

            try
            {
                if (tbnama.Text != "")
                {
                    // 2. Build the command query
                    query = "INSERT INTO cuti_karyawan(nama, cuti, periode, sisa, ambil, batas) VALUES(@nama, @cuti, @periode, @sisa, @ambil, @batas)";
                    
                    perintah = new MySqlCommand(query, koneksi);

                    perintah.Parameters.AddWithValue("nama", tbnama.Text);
                    perintah.Parameters.AddWithValue("cuti", dtpcuti.Value.Date.ToString("dd-MMM-yyyy"));
                    perintah.Parameters.AddWithValue("periode", dtpperiode.Value.Date.ToString("dd-MMM-yyyy"));
                    perintah.Parameters.AddWithValue("sisa", cbsisa.SelectedItem.ToString());
                    perintah.Parameters.AddWithValue("ambil", dtpambil.Value.Date.ToString("dd-MMM-yyyy"));
                    perintah.Parameters.AddWithValue("batas", dtpbatas.Value.Date.ToString("dd-MMM-yyyy"));

                    koneksi.Open();
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Insert Data Suksess ...");
                        MainFormLoad(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Gagal inser Data . . . ");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak lengkap !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btsave_Click_1(object sender, EventArgs e)
        {
            simpan();
            bersih();
        }

        private void btreset_Click_1(object sender, EventArgs e)
        {
            bersih();
            MainFormLoad(null, null);

            dtcuti.Value.ToShortDateString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bersih();
            MainFormLoad(null, null);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            update_cmd();
            bersih();
        }

        private void update_cmd()
        {
            string cutier = dtcuti.Value.Date.ToString("dd-MMM-yyyy");
            string perioder = dtperiode.Value.Date.ToString("dd-MMM-yyyy");
            string siser = cmbsisa.SelectedItem.ToString();
            string ambiler = dtambil.Value.Date.ToString("dd-MMM-yyyy");
            string kembalier = dtkembali.Value.Date.ToString("dd-MMM-yyyy");
            string bataser = dtbatas.Value.Date.ToString("dd-MMM-yyyy");
            try
            {
                if (tbnama.Text != "")
                {
                    query = string.Format("update cuti_karyawan set nama = '{0}',cuti = '{1}',periode = '{2}',sisa = '{3}',ambil = '{4}',kembali = '{5}',batas = '{6}' where no = '{7}'", 
                        tbnama_.Text, cutier, perioder, siser, ambiler, kembalier, bataser, no.Text);

                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Update Data Suksess ...");
                        MainFormLoad(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Gagal Update Data . . . ");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak lengkap !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            cmd_hapus();
        }

        private void cmd_hapus()
        {
            try
            {
                if (tbnama.Text != "" && tbnama_.Text != "")
                {
                    if (MessageBox.Show("Anda Yakin Menghapus Data Ini ??", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        query = string.Format("Delete from cuti_karyawan where no = '{0}'", no.Text);
                        ds.Clear();
                        koneksi.Open();
                        perintah = new MySqlCommand(query, koneksi);
                        adapter = new MySqlDataAdapter(perintah);
                        int res = perintah.ExecuteNonQuery();
                        koneksi.Close();
                        if (res == 1)
                        {
                            MessageBox.Show("Delete Data Suksess ...");
                        }
                        else
                        {
                            MessageBox.Show("Gagal Delete data");
                        }
                    }
                    MainFormLoad(null, null);
                }
                else
                {
                    MessageBox.Show("Data Yang Anda Pilih Tidak Ada !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd_hapus();
        }

        private void dgv_cuti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

            DateTime curDate;

            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgv_cuti.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.

                no.Text = row.Cells[0].Value.ToString();
                tbnama.Text = row.Cells[1].Value.ToString();
                tbnama_.Text = row.Cells[1].Value.ToString();
                
                dtcuti.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
                if (DateTime.TryParse(row.Cells[2].Value.ToString(), out curDate))
                {
                    dtcuti.Value = curDate;
                }
                dtpcuti.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
                if (DateTime.TryParse(row.Cells[2].Value.ToString(), out curDate))
                {
                    dtpcuti.Value = curDate;
                }

                dtperiode.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
                if (DateTime.TryParse(row.Cells[3].Value.ToString(), out curDate))
                {
                    dtperiode.Value = curDate;
                }
                dtpperiode.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
                if (DateTime.TryParse(row.Cells[3].Value.ToString(), out curDate))
                {
                    dtpperiode.Value = curDate;
                }

                cmbsisa.Text = row.Cells[4].Value.ToString();
                cbsisa.Text = row.Cells[4].Value.ToString();

                dtambil.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
                if (DateTime.TryParse(row.Cells[5].Value.ToString(), out curDate))
                {
                    dtambil.Value = curDate;
                }
                dtpambil.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
                if (DateTime.TryParse(row.Cells[5].Value.ToString(), out curDate))
                {
                    dtpambil.Value = curDate;
                }

                /**
                dtkembali.Value = Convert.ToDateTime(row.Cells[6].Value.ToString());
                if (DateTime.TryParse(row.Cells[6].Value.ToString(), out curDate))
                {
                    dtkembali.Value = curDate;
                }**/

                dtbatas.Value = Convert.ToDateTime(row.Cells[7].Value.ToString());
                if (DateTime.TryParse(row.Cells[7].Value.ToString(), out curDate))
                {
                    dtbatas.Value = curDate;
                }
                dtpbatas.Value = Convert.ToDateTime(row.Cells[7].Value.ToString());
                if (DateTime.TryParse(row.Cells[7].Value.ToString(), out curDate))
                {
                    dtpbatas.Value = curDate;
                }

            } else
            {
                MessageBox.Show("anda memilih data kosong");
            }
        }

        private void dtpambil_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpcuti_ValueChanged(object sender, EventArgs e)
        {

        }

        private void copyAlltoClipboard()
        {
            dgv_cuti.SelectAll();
            DataObject dataObj = dgv_cuti.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

    }
}

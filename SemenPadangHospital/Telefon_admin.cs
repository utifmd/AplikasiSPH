using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace SemenPadangHospital
{
    public partial class Telefon_admin : Form
    {

        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;

        public Telefon_admin()
        {
            InitializeComponent();
            //alamat = "server=sql6.freemysqlhosting.net; database=sql6124227; username=sql6124227; password=uYpxJkn9kX;";
            //alamat = "server=localhost; database=db_sph; username=root; password=;";
            alamat = "server=192.168.150.40; database=db_sph; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            MainFormLoad(null, null);
        }

        void MainFormLoad(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("select * from telp_unit");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                dgv_telfon.DataSource = ds.Tables[0];
                dgv_telfon.Columns[0].Width = 30;
                dgv_telfon.Columns[0].HeaderText = "No";
                dgv_telfon.Columns[1].Width = 230;
                dgv_telfon.Columns[1].HeaderText = "Nama unit";
                dgv_telfon.Columns[2].Width = 110;
                dgv_telfon.Columns[2].HeaderText = "Nomor tlp unit";
                bersih();
                //radiobutton_pria.Checked = false;
                //radiobutton_wanita.Checked = false;
                tbNama.Enabled = true;
                tbNomor.Enabled = true;
                tbNama.Focus();
                bcNama.Enabled = true;
                bcNomor.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda logout dari aplikasi telfon unit?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new Telefon().Show();
                this.Hide();
            }
        }

        private void Telefon_admin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmd_simpan();
        }

        private void bersih()
        {
            tbNama.Clear();
            tbNomor.Clear();
            tbunit.Clear();
            tbtlpunit.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd_update();
        }

        private void cmd_update()
        {
            try
            {
                if (tbunit.Text != "" && tbtlpunit.Text != "")
                {
                    query = string.Format("UPDATE telp_unit SET nm_unt = '{0}',tlp_unt = '{1}' where id = '{2}'",
                        tbunit.Text, tbtlpunit.Text, tbno.Text);

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

        private void button3_Click(object sender, EventArgs e)
        {
            cmd_hapus();
        }

        private void cmd_hapus()
        {try
            {
                if (tbunit.Text != "" && tbtlpunit.Text != "")
                {
                    if (MessageBox.Show("Data tersebut akan kami hapus?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        query = string.Format("Delete from telp_unit where id = '{0}'", tbno.Text);
                        ds.Clear();
                        koneksi.Open();
                        perintah = new MySqlCommand(query, koneksi);
                        adapter = new MySqlDataAdapter(perintah);
                        int res = perintah.ExecuteNonQuery();
                        koneksi.Close();
                        if (res == 1)
                        {
                            MessageBox.Show("Data berhasil dihapus!");
                        }
                        else
                        {
                            MessageBox.Show("Data berhasil dihapus!");
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

        private void bcNama_Click(object sender, EventArgs e)
        {
            cari_nama();
        }

        private void cari_nama()
        {
            try
            {
                if (tbNama.Text != "")
                {
                    query = string.Format("SELECT * FROM `telp_unit` WHERE `nm_unt` LIKE '%" + tbNama.Text + "%' >= 1");
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
                            tbno.Text = kolom["id"].ToString();
                            tbunit.Text = kolom["nm_unt"].ToString();
                            tbtlpunit.Text = kolom["tlp_unt"].ToString();
                        }
                        dgv_telfon.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Ada !!");
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
            bersih();
        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cari_nama();
            }
        }

        private void bcNomor_Click(object sender, EventArgs e)
        {
            cari_nomor();
        }

        private void tbNomor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cari_nomor();
            }
        }

        private void cari_nomor()
        {
            try
            {
                if (tbNomor.Text != "")
                {
                    query = string.Format("SELECT * FROM `telp_unit` WHERE `tlp_unt` LIKE '%" + tbNomor.Text + "%' >= 1");
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
                            tbno.Text = kolom["id"].ToString();
                            tbunit.Text = kolom["nm_unt"].ToString();
                            tbtlpunit.Text = kolom["tlp_unt"].ToString();
                            /*if (kolom["jeniskelamin"].ToString() == "Pria")
                            {
                                radiobutton_pria.Checked = true;
                            }
                            else
                            {
                                radiobutton_wanita.Checked = true;
                            }*/
                        }
                        dgv_telfon.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Ada !!");
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
            bersih();
        }

        private void tbNomor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormLoad(null, null);
            bersih();
        }

        private void dgv_telfon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgv_telfon.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.

                tbno.Text = row.Cells[0].Value.ToString();
                tbunit.Text = row.Cells[1].Value.ToString();
                tbtlpunit.Text = row.Cells[2].Value.ToString();

            }
            else
            {
                MessageBox.Show("anda memilih data kosong");
            }
        }

        private void tbtlpunit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd_simpan();
            }
        }
        
        private void copyAlltoClipboard()
        {
            dgv_telfon.SelectAll();
            DataObject dataObj = dgv_telfon.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }



        private void button6_Click(object sender, EventArgs e)
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

        private void cmd_simpan()
        {
            try
            {
                if (tbtlpunit.Text != "" && tbunit.Text != "")
                {
                    // 2. Build the command query
                    query = "INSERT INTO telp_unit(nm_unt, tlp_unt) VALUES(@nm_unt, @tlp_unt)";

                    perintah = new MySqlCommand(query, koneksi);

                    perintah.Parameters.AddWithValue("nm_unt", tbunit.Text);
                    perintah.Parameters.AddWithValue("tlp_unt", tbtlpunit.Text);

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
                        MessageBox.Show("Gagal insert Data . . . ");
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
    }
}

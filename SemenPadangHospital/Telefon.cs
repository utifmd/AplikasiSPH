
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;


namespace SemenPadangHospital
{
    public partial class Telefon : Form
    {

        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;

        public Telefon()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                        {   /*
                            tbNama.Text = kolom["nm_unt"].ToString();
                            tbNama.Text = kolom["tlp_unt"].ToString();
                            if (kolom["jeniskelamin"].ToString() == "Pria")
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
                            tbNama.Text = kolom["nm_unt"].ToString();
                            tbNama.Text = kolom["tlp_unt"].ToString();
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

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainFormLoad(null, null);
        }

        private void tbNama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cari_nama();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Welcome().Show();
            this.Hide();

        }

        private void tbNomor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cari_nomor();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Login_tlp().Show();
            this.Hide();

        }

        private void bcNomor_Click(object sender, EventArgs e)
        {
            cari_nomor();
        }

        private void dgv_telfon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void Telefon_Load(object sender, EventArgs e)
        {

        }

        private void dgv_telfon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgv_telfon.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                tbid.Text = row.Cells[0].Value.ToString();
                tbNama.Text = row.Cells[1].Value.ToString();
                tbNomor.Text = row.Cells[2].Value.ToString();
            }
        }

        private void bersih()
        {
            tbNama.Clear();
            tbNomor.Clear();
        }
    }
}

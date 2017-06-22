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

namespace SemenPadangHospital
{
    public partial class Login_cuti : Form
    {
        public Login_cuti()
        {
            InitializeComponent();
        }
        
        private void Caluculate(int i)
        {
            double pow = Math.Pow(i, i);
        }

        public void DoWork(IProgress<int> progress)
        {
            for (int j = 0; j < 100000; j++)
            {
                Caluculate(j);

                if (progress != null)
                    progress.Report((j + 1) * 100 / 100000);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private async void btapply_Click(object sender, EventArgs e)
        {

            pbbtn.Maximum = 100;
            pbbtn.Step = 1;

            var progress = new Progress<int>(v =>
            {
                pbbtn.Value = v;
            });

            await Task.Run(() => DoWork(progress));
            cmd_login();
        }

        private void cmd_login()
        {
            if (tbnip.Text == "" || tbpass.Text == "")
            {
                MessageBox.Show("Form tidak lengkap!");
                return;
            }
            try
            {
                //string cs = "server=sql6.freemysqlhosting.net; database=sql6124227; username=sql6124227; password=uYpxJkn9kX;";
                //string cs = "server=localhost; database=db_sph; username=root; password=;";
                string cs = "server=192.168.150.40; database=db_sph; username=root; password=;";

                //Create SqlConnection
                MySqlConnection con = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand("Select * from admin_sph where username=@username and password=@password", con);
                cmd.Parameters.AddWithValue("@username", tbnip.Text);
                cmd.Parameters.AddWithValue("@password", tbpass.Text);
                con.Open();
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Login sukses sebagai "+tbnip.Text+"!");
                    this.Hide();
                    Cuti fm = new Cuti();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Gagal!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd_login();
            }
        }

        private void tbpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new Welcome().Show();
            this.Hide();
        }
    }
}

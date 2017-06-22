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
    public partial class Login_tlp : Form
    {
        public Login_tlp()
        {
            InitializeComponent();
        }

        private void tbpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd_login();
            }
        }

        private void cmd_login()
        {
            if (tbuser.Text == "" || tbpass.Text == "")
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
                cmd.Parameters.AddWithValue("@username", tbuser.Text);
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
                    MessageBox.Show("Login Sukses, " + tbuser.Text + "!");
                    this.Hide();
                    Telefon_admin fm = new Telefon_admin();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Telefon().Show();
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

        private async void btlogin_Click(object sender, EventArgs e)
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
    }
}

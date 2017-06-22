using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace SemenPadangHospital
{
    public partial class Welcome : Form
    {
        public Welcome()
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
        

        private async void btelfon_Click(object sender, EventArgs e)
        {

            pbbtn.Maximum = 100;
            pbbtn.Step = 1;

            var progress = new Progress<int>(v =>
            {
                pbbtn.Value = v;
            });
            
            await Task.Run(() => DoWork(progress));
            
            Telefon tl = new Telefon();
            tl.Show();

            this.Hide();
        }

        private void btcuti_Click(object sender, EventArgs e)
        {
            new Login_cuti().Show();
            this.Hide();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void serverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Server().Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ownerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("copyright utif.inc");
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}

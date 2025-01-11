using SuperMarket_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void splash_progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void SplashForm_Load(object sender, EventArgs e)
        {
            splash_timer1.Start();
        }
        int startpoint = 0;
        private void splash_timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            splash_progressBar1.Value = startpoint;
            if (splash_progressBar1.Value == 100)
            {
                splash_progressBar1.Value = 0;
                splash_timer1.Stop();
                LoginForm log = new LoginForm();
                this.Hide();
                log.Show();
            }
        }

       

    }
}

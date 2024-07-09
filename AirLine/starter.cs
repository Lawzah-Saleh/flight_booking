using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AirLine
{
    public partial class starter : Form
    {
        public starter()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        int sta = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            sta += 1;
            progressBar1.Value = sta;
            if (progressBar1.Value == 50)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void starter_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

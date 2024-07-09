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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flights flight = new flights();
            flight.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Addpassenger pass = new Addpassenger();
            pass.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Tickets tick = new Tickets();
            tick.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cancellation can = new Cancellation();
            can.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

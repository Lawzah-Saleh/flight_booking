using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AirLine
{
    public partial class flights : Form
    {
        public flights()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\AirLineDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "" || FsrcTb.SelectedItem.ToString() == "" || SeatNum.Text == "" || Fdate.Text == "" || Fdescb.SelectedItem.ToString() == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into FlightTbl values(" + FcodeTb.Text + " ,' " + FsrcTb.SelectedItem.ToString() + " ',' " + Fdescb.SelectedItem.ToString() + " ',' " + Fdate.Value.ToString()+ "'," + SeatNum.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("flight record successfully");
                    Con.Close();
                }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            }
        }

        private void flights_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FcodeTb.Text = "";
            SeatNum.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Viewflights viewfli = new Viewflights();
            viewfli.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}

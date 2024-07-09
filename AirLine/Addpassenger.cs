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
    public partial class Addpassenger : Form
    {
        public Addpassenger()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\AirLineDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void passid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passid.Text == "" || passaddress.Text == "" || passname.Text == "" || passporttd.Text == "" || phonetb.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into PassengerTbl values("+ passid.Text + ",' " + passname.Text + " ','" + passporttd.Text + " ',' " + passaddress.Text + "','" + nationaltycb.SelectedItem.ToString() + "','" + gendercb.SelectedItem.ToString() + "','" + phonetb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("passenger record successfully");
                    Con.Close();
                }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Addpassenger_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewPassengers viewpass = new ViewPassengers();
            viewpass.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}

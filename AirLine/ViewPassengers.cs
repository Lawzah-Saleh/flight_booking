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
    public partial class ViewPassengers : Form
    {
        public ViewPassengers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\AirLineDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from PassengerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            passengerDGV.DataSource = ds.Tables[0];
            Con.Close();
        
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewPassengers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pidTb.Text = passengerDGV.SelectedRows[0].Cells[0].Value.ToString();
            PnameTb.Text = passengerDGV.SelectedRows[0].Cells[1].Value.ToString();
            PpassTb.Text = passengerDGV.SelectedRows[0].Cells[2].Value.ToString();
            PaddresTb.Text = passengerDGV.SelectedRows[0].Cells[3].Value.ToString();
            Pnatcb.SelectedItem = passengerDGV.SelectedRows[0].Cells[4].Value.ToString();
            gendcb.SelectedItem = passengerDGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Addpassenger addpas = new Addpassenger();
            addpas.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pidTb.Text == "")
            {
                MessageBox.Show("Enter the passenger to Delete");
            }
            else {

                try
                {
                    Con.Open();
                    string query = "delete from PassengerTbl where Passid=" + pidTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("passenger deleted successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void natcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pidTb.Text = "";
            PnameTb.Text = "";
            PpassTb.Text = "";
            PaddresTb.Text = "";
            Pnatcb.SelectedItem = "";
            gendcb.SelectedItem = "";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pidTb.Text == "" || PnameTb.Text == "" || PpassTb.Text == "" || PaddresTb.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else {
                try { 
                    Con.Open();
                    string query = "update PassengerTbl set PassName='" + PnameTb.Text + "'Passport='" + PpassTb.Text + "',PassAd='" + PaddresTb.Text + "',PassNat='" + Pnatcb.SelectedItem.ToString() + "',PassGend='" + gendcb.SelectedItem.ToString() + "',PassPhone='" + PphoneTb.Text + "'where PassId='" + pidTb.Text + ";";
                    SqlCommand cmd =new SqlCommand(query,Con);
                cmd.ExecuteNonQuery();
                    MessageBox.Show("passenger updated successfully");
                    Con.Close();
                    populate();
                }catch(Exception Ex)
                {
                MessageBox.Show("missing information");
                }
            
            }
        }
    }
}

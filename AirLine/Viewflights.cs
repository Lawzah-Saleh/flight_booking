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
    public partial class Viewflights : Form
    {
        public Viewflights()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\AirLineDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from FlightTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,Con);
             SqlCommandBuilder builder = new SqlCommandBuilder(sda);
             var ds = new DataSet();
             sda.Fill(ds);
             flightsDGV.DataSource = ds.Tables[0];
             Con.Close();

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Viewflights_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void flightsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            fcodeTb.Text = flightsDGV.SelectedRows[0].Cells[0].Value.ToString();
            sourcecb.SelectedItem = flightsDGV.SelectedRows[0].Cells[2].Value.ToString();
            fdestcb.SelectedItem = flightsDGV.SelectedRows[0].Cells[3].Value.ToString();
            seatnum.Text = flightsDGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flights addfl =new flights();
            addfl.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fcodeTb.Text = "";
            seatnum.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fcodeTb.Text == "")
            {
                MessageBox.Show("Enter the flight to Delete");
            }
            else
            {

                try
                {
                    Con.Open();
                    string query = "delete from FlightTbl where Fcode=" + fcodeTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight deleted successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (fcodeTb.Text == "" || seatnum.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else {
                try { 
                    Con.Open();
                    string query = "FlightTbl set Fsrc='" + sourcecb.SelectedItem.ToString() + "',FDest='" + fdestcb.SelectedItem.ToString() + "',FDate='" + fdate.Value.Date.ToString() +"',FCap="+seatnum.Text +"'where Fcode='" + fcodeTb.Text + "';";
                    SqlCommand cmd =new SqlCommand(query,Con);
                cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight updated successfully");
                    Con.Close();
                    populate();
                }catch(Exception Ex)
                {
                MessageBox.Show("Missing information");
                }
            
            }
        }
        }
    }


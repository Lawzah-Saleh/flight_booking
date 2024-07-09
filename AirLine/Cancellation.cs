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
    public partial class Cancellation : Form
    {
        public Cancellation()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\AirLineDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void fillTicketId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Tid from TicketTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Tid", typeof(string));
            dt.Load(rdr);
            TidCb.ValueMember = "Tid";
            TidCb.DataSource = dt;
            Con.Close();
        }
        private void fetchfcode()
        {
            //Con.Open();
            string query = "select * from ticketTbl where Tid=" + TidCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                FcodeTb.Text = dr["Fcode"].ToString();
                
            }
            Con.Close();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void populate()
        {
            Con.Open();
            string query = "select * from CancelTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CancellationDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void Cancellation_Load(object sender, EventArgs e)
        {
            fillTicketId();
            populate();
           
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void deleteticket()
        {
            try
            {
                Con.Open();
                string query = "delete from TicketTbl where Tid=" + TidCb.SelectedValue+ ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ticket deleted successfully");
                Con.Close();
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if ( CanId.Text =="" || FcodeTb.Text =="")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CancelTbl values(" + CanId.Text + ",'" + TidCb.SelectedValue.ToString() + "' ,'" + FcodeTb.Text + " ',' " + Cancdate.Value.Date + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Canceled successfully");
                    Con.Close();
                   populate();
                   deleteticket();
                }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            }
        }

        private void CancellationDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FcodeTb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void TidCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchfcode();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CanId.Text = "";
            FcodeTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}

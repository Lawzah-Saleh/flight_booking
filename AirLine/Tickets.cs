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
    public partial class Tickets : Form
    {
        public Tickets()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\AirLineDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from TicketTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,Con);
             SqlCommandBuilder builder = new SqlCommandBuilder(sda);
             var ds = new DataSet();
             sda.Fill(ds);
             TicketDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void fillpassenger()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select passid from passengerTbl",Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Passid",typeof(int));
            dt.Load(rdr);
            Pidcb.ValueMember = "Passid";
            Pidcb.DataSource = dt;
            Con.Close();
        }
        private void fillFlightCode()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Fcode from FlightTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Fcode", typeof(string));
            dt.Load(rdr);
            FCodeCb.ValueMember = "Fcode";
            FCodeCb.DataSource = dt;
            Con.Close();
        }
        string pname, ppass, pnat;
        private void fetchpassenger()
        {
            //Con.Open();
            string query = "select * from PassengerTbl where Passid="+Pidcb.SelectedValue.ToString()+"";
            SqlCommand cmd = new SqlCommand(query,Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
           pname=dr["PassName"].ToString();
            ppass=dr["Passport"].ToString();
                pnat=dr["PassNat"].ToString();
                PNameTb.Text = pname;
                PPassTb.Text = ppass;
                PNatTb.Text = pnat;
            }
           // Con.Close();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            fillpassenger();
            fillFlightCode();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pidcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchpassenger();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Tid.Text == "" || PNameTb.Text== "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into TicketTbl values(" + Tid.Text + " ,' " + FCodeCb.SelectedValue.ToString() + " '," + Pidcb.SelectedValue.ToString() + " ,' " + PNameTb.Text + "','" + PPassTb.Text + "','" + PNatTb.Text + "'," + PAmtTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Booked successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            }
        }

        private void TicketDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PNameTb.Text = "";
            PPassTb.Text = "";
            PNatTb.Text = "";
            PAmtTb.Text = "";
            Tid.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}

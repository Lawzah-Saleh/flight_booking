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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UidTb.Text == "" || UpasswordTb.Text == "")
            {
                MessageBox.Show("Enter the user id and the passwort ^_^");
            }
            else if (UidTb.Text == "airline" && UpasswordTb.Text == "123")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The user id or password is Wrong");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UidTb.Text = "";
            UpasswordTb.Text = "";
        }

        private void UidTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

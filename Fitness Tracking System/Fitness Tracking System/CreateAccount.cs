using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracking_System
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void lblGoLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void cmdCreateAccount_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            User customer = new User();

            if (customer.Check_Password(txtPassword.Text) == true)
            {
                customer.CreateAccount(txtUserName.Text, txtPassword.Text);
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }

            else if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and Password should not be empty.");
                return;
            }
            else
            {
                MessageBox.Show("password must be at least 12 characters long, and contain at least " +
                                "1 lowercase and 1 uppercase letter.");
            }

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

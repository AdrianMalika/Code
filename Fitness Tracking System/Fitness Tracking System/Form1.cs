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
    public partial class Form1 : Form
    {
        public static string Username { get; private set; }
        public static int UserID;
        public Form1()
        {
            InitializeComponent();
            Username = txtUserName.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {

            string username = txtUserName.Text;
            string password = txtPassword.Text;

            User customer = new User();

            if (customer.Login(username, password) == true)
            {
                MessageBox.Show("Login successful!");
                Username = txtUserName.Text;
                HomePage home = new HomePage();
                this.Hide();
                home.Show();
            }
            else if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and Password should not be empty.");
                return;
            }
            else
            {
                MessageBox.Show("Login failed. Wrong username or password.");
            }
        }

        private void lblGoCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            this.Hide();
            createAccount.Show();

        }

        private void lblNoAcc_Click(object sender, EventArgs e)
        {

        }
    }
}

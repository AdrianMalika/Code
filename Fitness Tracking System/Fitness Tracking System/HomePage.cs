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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void lblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to LogOut?", "Confrim", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
            else
            {
            }                
        }

        private void cmdSetGoal_Click(object sender, EventArgs e)
        {
            SetGoals set = new SetGoals();
            this.Hide();
            set.Show();
        }

        private void cmdHistory_Click(object sender, EventArgs e)
        {
            Histoy histoy = new Histoy();
            histoy.Show();
            this.Hide();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class SetGoals : Form
    {
        public SetGoals()
        {
            InitializeComponent();

            // Populate the dropdown with available activities
            List<string> availableActivities = new List<string>
            {
             "Walking",
             "Swimming",
             "Running",
             "Cycling",
             "Yoga",
             "Hiking"
            };

            cmbActivities.DataSource = availableActivities;

        }

        private void OpenActivityForm(string activityName)
        {
            switch (activityName)
            {
                case "Walking":
                    Walking walkingForm = new Walking();
                    walkingForm.Show();
                    this.Hide();
                    break;

                case "Swimming":
                    Swimming swimmingForm = new Swimming();
                    swimmingForm.Show();
                    this.Hide();
                    break;

                case "Running":
                    Running runningFrom = new Running();
                    runningFrom.Show();
                    this.Hide();
                    break;

                case "Cycling":
                    Cycling cyclingForm = new Cycling();
                    cyclingForm.Show();
                    this.Hide();
                    break;

                case "Yoga":
                    Yoga yoga = new Yoga();
                    yoga.Show();
                    this.Hide();
                    break;

                case "Hiking":
                    Hiking hiking = new Hiking();
                    hiking.Show();
                    this.Hide();
                    break;

                default:
                    MessageBox.Show("Unsupported activity selected.");
                    break;
            }
        }

       
        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomePage home = new HomePage();
            this.Hide();
            home.Show();
        }

        private void SetGoals_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the selected activity from the dropdown
            string selectedActivity = cmbActivities.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedActivity))
            {
                // Open the form corresponding to the selected activity
                OpenActivityForm(selectedActivity);
            }
            else
            {
                MessageBox.Show("Please select a valid activity.");
            }
        }

        private void cmbActivities_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

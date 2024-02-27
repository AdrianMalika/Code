using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracking_System
{
    public partial class Hiking : Form
    {
        private string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Fitness Tracking.mdb";

        public Hiking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStep.Text, out int steps) &&
                            double.TryParse(txtDIstance.Text, out double distance) &&
                            int.TryParse(txtElevationGain.Text, out int time) &&
                            int.TryParse(txtGoal.Text, out int goal))
            {
                double caloriesBurned = Activities.CalculateCaloriesBurnedWalking(steps, distance, time);

                // Display the calculated calories burned
                lblCaloriesBurned.Text = $"Calories Burned: {caloriesBurned}";

                // Insert a new record into the database
                InsertNewGoal(caloriesBurned, goal);

                // Report whether the user has achieved the goal
                ReportGoalAchievement(caloriesBurned, goal);

                AfterAchievingGoalOptions();
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for Steps, Distance, ElevationGain, and Goal.");
            }
        }

        private void InsertNewGoal(double caloriesBurned, int goal)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Goals (Username, ActivityType, Goal, AchievedGoal, Metric1, Metric2, Metric3) " +
                               "VALUES (@Username, 'Hiking', @Goal, @caloriesBurned, @Steps, @Distance, @ElevationGain)";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", Form1.Username);
                    cmd.Parameters.AddWithValue("@Goal", goal);
                    cmd.Parameters.AddWithValue("@caloriesBurned", caloriesBurned);
                    cmd.Parameters.AddWithValue("@Steps", int.Parse(txtStep.Text));
                    cmd.Parameters.AddWithValue("@Distance", double.Parse(txtDIstance.Text));
                    cmd.Parameters.AddWithValue("@ElevationGain", int.Parse(txtElevationGain.Text));

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void ReportGoalAchievement(double caloriesBurned, int goal)
        {
            bool goalAchieved = caloriesBurned >= goal;

            MessageBox.Show($"Goal Achievement Report:\n\n" +
                            $"Goal: {goal} calories\n" +
                            $"Calories Burned: {caloriesBurned} calories\n" +
                            $"Achieved: {(goalAchieved ? "Yes" : "No")}",
                            "Goal Achievement Report",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        private void AfterAchievingGoalOptions()
        {
            DialogResult result = MessageBox.Show("Would you like to Set new Goal?", "Goal Achieved", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SetNewGoal();
            }
            else if (result == DialogResult.No)
            {
                HomePage home = new HomePage();
                home.Show();
                this.Hide();
            }

        }

        private void SetNewGoal()
        {
            SetGoals set = new SetGoals();
            this.Hide();
            set.Show();
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetGoals set = new SetGoals();
            this.Hide();
            set.Show();
        }

        private void Hiking_Load(object sender, EventArgs e)
        {

        }
    }
}

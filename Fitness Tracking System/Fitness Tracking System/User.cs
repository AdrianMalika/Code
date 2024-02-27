using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracking_System
{
    class User
      {
        private string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Fitness Tracking.mdb";
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        public bool Check_Password(string password)
        {
            return (password.Length >= 12 && password.Length <= 19 && password.Any(char.IsUpper) && password.Any(char.IsLower));
        }

        // LOGIN
        public bool Login(string username, string password)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE [UserName]=@username AND [Password]=@password";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int userCount = (int)cmd.ExecuteScalar();
                if (userCount > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public void CreateAccount(string username, string password)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                // Check if the username already exists in the database
                string checkUsernameQuery = "SELECT COUNT(*) FROM [Users] WHERE [UserName] = @username";
                OleDbCommand checkUsernameCmd = new OleDbCommand(checkUsernameQuery, conn);
                checkUsernameCmd.Parameters.AddWithValue("@username", username);
                conn.Open();

                int existingUserCount = (int)checkUsernameCmd.ExecuteScalar();
                if (existingUserCount > 0)
                {
                    // show pakakha user which is already there
                    MessageBox.Show("Username is already taken. Please choose a different one.");
                    conn.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("You have been Regstered");
                }

                //ENTER INTO DATABASE THE USERNAME AND PASSWORD
                string query = "INSERT INTO [Users] ([UserName], [Password]) " + "VALUES (@username, @password)";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}

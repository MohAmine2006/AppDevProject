using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SmartExpenseTracker
{
    public partial class LoginForm : Form
    {
        public string LoggedInUser { get; private set; }
        string mySqlConn = "Server=127.0.0.1;Database=expense;User=root;Password=";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            // Tried to hash password but couldn't get it to work with the database
            //string hashedInput = SecurityHelper.HashPassword(password); 

            try
            {
                using (MySqlConnection conn = new MySqlConnection(mySqlConn))
                {
                    // Validate both username and password are provided
                    if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Please enter both username and password.", "Input Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //return;
                    }
                    else
                    {
                        // MySQL query to check for matching username and password
                        conn.Open();
                        string query = "SELECT userID FROM users WHERE username=@username AND password=@password";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            LoggedInUser = username;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            //if (username == "Admin" && password == "1234")
            //{
            //    LoggedInUser = username;
            //    this.DialogResult = DialogResult.OK; 
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid username or password", "Error", 
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}

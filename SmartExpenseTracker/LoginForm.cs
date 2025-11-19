using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartExpenseTracker
{
    public partial class LoginForm : Form
    {
        public string LoggedInUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (username == "Admin" && password == "1234")
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

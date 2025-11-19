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
    public partial class SmartExpenseTrackerForm : Form
    {
        private string username;

        public SmartExpenseTrackerForm(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void SmartExpenseTrackerForm_Load(object sender, EventArgs e)
        {
            iconLabelButton.Text = $"Welcome {username}";
        }


        private void clock_Tick(object sender, EventArgs e)
        {
            clockLabelContainer.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss tt");
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Smart Expense Tracker" +
                "\nVersion: 1.0.0" +
                "\nAuthor: Daiyan Abrar Samin & Mohamed Amine Hamidouch", "About", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

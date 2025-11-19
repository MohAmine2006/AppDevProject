using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartExpenseTracker
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var loginForm = new LoginForm())
            {
                // Show login form first
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Only open main form if login successful
                    Application.Run(new SmartExpenseTrackerForm(loginForm.LoggedInUser));
                }
            }
        }
    }
}

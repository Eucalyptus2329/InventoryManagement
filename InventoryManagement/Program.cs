using System;
using System.Windows.Forms;

namespace InventoryManagement
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

            LoginForm loginform = new LoginForm();
            if(loginform.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new LoginForm());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}

using System;
using System.Windows.Forms;


namespace InventoryManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == false)
                PasswordBox.UseSystemPasswordChar = true;
            else
                PasswordBox.UseSystemPasswordChar = false;

        }
        private void label2_Click_1(object sender, EventArgs e)
        {
            UsernameBox.Clear();
            PasswordBox.Clear();
            PasswordBox.Text = "Password";
            UsernameBox.Text = "Username";
        }

        private void PasswordBoxEnter(object sender, EventArgs e)
        {
            if(PasswordBox.Text == "Password")
            {
                PasswordBox.Text = "";
            }
        }
        private void PasswordBoxLeave(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "")
            {
                PasswordBox.Text = "Password";
            }
        }
        private void UsernameBoxEnter(object sender, EventArgs e)
        {
            if(UsernameBox.Text == "Username") 
            {
                UsernameBox.Text = "";
            }
        }
        private void UsernameBoxLeave(object sender, EventArgs e)
        {
            if (UsernameBox.Text == "")
            {
                UsernameBox.Text = "Username";
            }
        }

        private void CloseWindowButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application","Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

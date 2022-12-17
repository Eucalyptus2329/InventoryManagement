using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace InventoryManagement
{
    public partial class LoginForm : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=EULIX-LAPTOP;Initial Catalog=PavillionManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand CM = new SqlCommand();
        SqlDataReader Dr;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordBox.PasswordChar = '*';
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordBox.PasswordChar = showPasswordCheckbox.Checked ? '\0' : '*';
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                CM = new SqlCommand("Select * from UserFormDb where Username = @Username AND Password = @Password", connection);
                CM.Parameters.AddWithValue("@Username", UsernameBox.Text);
                CM.Parameters.AddWithValue("@Password", PasswordBox.Text);
                connection.Open();
                Dr = CM.ExecuteReader();
                Dr.Read();
                if (Dr.HasRows)
                {
                    MessageBox.Show("Welcome " + Dr["fullname"].ToString() + "! ", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mainform main = new Mainform();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Access Denied. Invalid Username or Password", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ClearLabel_Click(object sender, EventArgs e)
        {
            UsernameBox.Clear();
            PasswordBox.Clear();
        }

      
    }
}

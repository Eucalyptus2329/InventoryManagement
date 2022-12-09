using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace InventoryManagement
{
    public partial class UserModule : Form 
    {
        public string UserConnectionString { get; set; }
        SqlConnection connection = new SqlConnection("Data Source=EULIX-LAPTOP;Initial Catalog=PavillionManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand CM = new SqlCommand();
        public UserModule()
        {
            InitializeComponent();
        }
        
        //Clear Method
        public void Clear()
        {
            UsernameTxtBox.Clear();
            PasswordTxtBox.Clear();
            RetypePasswordBox.Clear();
            FullNameTxtBox.Clear();
            PhoneNumberTxtBox.Clear();
        }

        //Close Window Button
        private void CloseWindowButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //Clear Button
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
        
        //Save Button
        private void SaveButton_Click(object sender, EventArgs e) 
        {
            try
            {
                if(PasswordTxtBox.Text != RetypePasswordBox.Text) 
                {
                    MessageBox.Show("Passwords do not match", "Retype Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(MessageBox.Show("Are you sure you want to save this User?","Saving Record",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string insert = "insert into UserFormDb(Username,Password,FullName,PhoneNumber)values(@Username,@Password,@FullName,@PhoneNumber)";
                    CM = new SqlCommand(insert,connection);
                    CM.Parameters.AddWithValue("@Username", FullNameTxtBox.Text);
                    CM.Parameters.AddWithValue("@Password", PasswordTxtBox.Text);
                    CM.Parameters.AddWithValue("@FullName",FullNameTxtBox.Text);
                    CM.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTxtBox.Text);
                    connection.Open();
                    CM.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("User has been successfully saved");
                    Clear();
                    
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //Update Button 
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PasswordTxtBox.Text != RetypePasswordBox.Text)
                {
                    MessageBox.Show("Passwords do not match", "Retype Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to update this User?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string insert = "UPDATE UserFormDb SET Password = @Password, Fullname = @FullName, PhoneNumber = @PhoneNumber WHERE Username like '" + UsernameTxtBox.Text + "' ";
                    CM = new SqlCommand(insert, connection);
                    CM.Parameters.AddWithValue("@Username", UsernameTxtBox.Text);
                    CM.Parameters.AddWithValue("@Password", PasswordTxtBox.Text);
                    CM.Parameters.AddWithValue("@FullName", FullNameTxtBox.Text);
                    CM.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTxtBox.Text);
                    connection.Open();
                    CM.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("User has been successfully updated.");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Clear();
        }
    }
}

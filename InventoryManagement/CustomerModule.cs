using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class CustomerModule : Form
    {
        //SQL Connection
        SqlConnection connection = new SqlConnection("Data Source=EULIX-LAPTOP;Initial Catalog=PavillionManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand CM = new SqlCommand();
        public CustomerModule()
        {
            InitializeComponent();
        }
        //Clear Method
        public void Clear()
        {
            CustomerNameTxtBox.Clear();
            PhoneNumberTxtBox.Clear();
        }
        //Save Button
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this User?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string insert = "insert into CustomerDb(CustomerName, CustomerPhoneNumber)values(@CustomerName, @CustomerPhoneNumber)";
                    CM = new SqlCommand(insert, connection);
                    CM.Parameters.AddWithValue("@CustomerName", CustomerNameTxtBox.Text);
                    CM.Parameters.AddWithValue("@CustomerPhoneNumber",PhoneNumberTxtBox.Text);
                    connection.Open();
                    CM.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("User has been successfully saved");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Clear Button
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
        //Update Button
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this User?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string insert = "UPDATE CustomerDb SET CustomerName = @CustomerName, CustomerPhoneNumber = @CustomerPhoneNumber WHERE CustomerID like '" + CustomerIDLabel.Text + "' ";
                    CM = new SqlCommand(insert, connection);
                    CM.Parameters.AddWithValue("@CustomerName", CustomerNameTxtBox.Text);
                    CM.Parameters.AddWithValue("@CustomerPhoneNumber", PhoneNumberTxtBox.Text);
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

        //Close Window Button
        private void CloseWindowButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

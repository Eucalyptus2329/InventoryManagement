using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class CategoryModule : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=EULIX-LAPTOP;Initial Catalog=PavillionManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand CM = new SqlCommand();
        public CategoryModule()
        {
            InitializeComponent();
        }
        //Clear Method
        public void Clear()
        {
            CategoryNameTxtBox.Clear();
        }
        //Save Button
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Category?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string insert = "insert into CategoryDb(CategoryName)values(@CategoryName)";
                    CM = new SqlCommand(insert, connection);
                    CM.Parameters.AddWithValue("@CategoryName", CategoryNameTxtBox.Text);
                    connection.Open();
                    CM.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Category has been successfully saved");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Update Button
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this Category?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string insert = "UPDATE CategoryDb SET CategoryName = @CategoryName WHERE CategoryID like '" + CategoryIDLabel.Text + "' ";
                    CM = new SqlCommand(insert, connection);
                    CM.Parameters.AddWithValue("@CategoryName", CategoryNameTxtBox.Text);
                    connection.Open();
                    CM.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Category has been successfully updated.");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Clear();
        }
        //Clear Button
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //Close Window Button
        private void CloseWindowButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

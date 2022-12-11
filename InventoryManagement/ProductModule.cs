using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class ProductModule : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=EULIX-LAPTOP;Initial Catalog=PavillionManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand CM = new SqlCommand();
        SqlDataReader Dr;
        public ProductModule()
        {
            InitializeComponent();
            LoadCategory();
        }
        public void LoadCategory()
        {
            comboCategoryBox.Items.Clear();
            CM = new SqlCommand("Select CategoryName from CategoryDb", connection);
            connection.Open();
            Dr = CM.ExecuteReader();
            while (Dr.Read())
            {
                comboCategoryBox.Items.Add(Dr[0].ToString());
            }
            Dr.Close();
            connection.Close();
        }
        //Clear Method
        public void Clear()
        {
            ProductNameTxtBox.Clear();
            QuantityTxtBox.Clear();
            PriceTxtBox.Clear();
            DescriptionTxtBox.Clear();
            comboCategoryBox.Text = "";
        }


        //Save Button
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Product?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string insert = "insert into ProductDb(ProductName,Quantity, Price, Description, ProductCategory)values(@ProductName,@Quantity, @Price, @Description, @ProductCategory)";
                    CM = new SqlCommand(insert, connection);
                    CM.Parameters.AddWithValue("@ProductName", ProductNameTxtBox.Text);
                    CM.Parameters.AddWithValue("@Quantity", Convert.ToInt16(QuantityTxtBox.Text));
                    CM.Parameters.AddWithValue("@Price", Convert.ToInt16(PriceTxtBox.Text));
                    CM.Parameters.AddWithValue("@Description", DescriptionTxtBox.Text);
                    CM.Parameters.AddWithValue("@ProductCategory", comboCategoryBox.Text);
                    connection.Open();
                    CM.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Product has been successfully saved");
                    Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Close Window Button
        private void CloseWindowButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //Update Button 
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this Product?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string insert = "UPDATE ProductDb SET ProductName = @ProductName, Quantity = @Quantity, Price = @Price, Description = @Description, ProductCategory = @ProductCategory WHERE ProductID like '" + ProductIDLabel.Text + "' ";
                    CM = new SqlCommand(insert, connection);
                    CM.Parameters.AddWithValue("@ProductName", ProductNameTxtBox.Text);
                    CM.Parameters.AddWithValue("@Quantity", QuantityTxtBox.Text);
                    CM.Parameters.AddWithValue("@Price", PriceTxtBox.Text);
                    CM.Parameters.AddWithValue("@Description", DescriptionTxtBox.Text);
                    CM.Parameters.AddWithValue("@ProductCategory", comboCategoryBox.Text);
                    connection.Open();
                    CM.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Product has been successfully updated!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Clear();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

   
    }
}

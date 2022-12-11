using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class ProductForm : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=EULIX-LAPTOP;Initial Catalog=PavillionManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand CM = new SqlCommand();
        SqlDataReader Dr;
        public ProductForm()
        {
            InitializeComponent();
            LoadProduct();
        }
        public void LoadProduct()
        {
            int i = 0;
            dataGridViewProduct.Rows.Clear();
            CM = new SqlCommand("Select * from ProductDb", connection);
            connection.Open();
            Dr = CM.ExecuteReader();
            while (Dr.Read())
            {
                i++;
                dataGridViewProduct.Rows.Add(i, Dr[0].ToString(), Dr[1].ToString(), Dr[2].ToString(), Dr[3].ToString(), Dr[4].ToString());
            }
            Dr.Close();
            connection.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ProductModule ProductModule = new ProductModule();
            ProductModule.SaveButton.Enabled = true;
            ProductModule.UpdateButton.Enabled = false;
            ProductModule.ShowDialog();
            LoadProduct();
        }
        //Edit and Delete Button
        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
               ProductModule ProductModule = new ProductModule();
               ProductModule.ProductIDLabel .Text = dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
               ProductModule.ProductNameTxtBox.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
               ProductModule.QuantityTxtBox.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
               ProductModule.PriceTxtBox.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
               ProductModule.DescriptionTxtBox.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
               ProductModule.CategoryTxtBox.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
               ProductModule.SaveButton.Enabled = false;
               ProductModule.UpdateButton.Enabled = true;
               ProductModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this Product?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Open();
                    CM = new SqlCommand("Delete from ProductDb WHERE ProductName like '" + dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value.ToString() + "' ", connection);
                    CM.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Product has been successfully deleted");
                }
            }
            LoadProduct();
        }
        //Hand Cursor for Edit and Delete Button Specifically in Data Grid
        private void dataGridViewProduct_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            string colName = dataGridViewProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Edit" || colName == "Delete") // C# supports two boolean or operators: the single bar | and the double-bar ||. The difference is that | always checks both the left and right conditions, while || only checks the right - side condition if it's necessary (if the left side evaluates to false).
            {
                dataGridViewProduct.Cursor = Cursors.Hand;
            }
            else
            {
                dataGridViewProduct.Cursor = Cursors.Default;
            }
        }
    }
}

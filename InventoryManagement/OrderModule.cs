using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class OrderModule : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=EULIX-LAPTOP;Initial Catalog=PavillionManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand CM = new SqlCommand();
        SqlDataReader Dr;
        public OrderModule()
        {
            InitializeComponent();
            LoadCustomer();
            LoadProduct();
        }

        private void CloseWindowButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void LoadCustomer()
        {
            int i = 0;
            dataGridViewCustomer.Rows.Clear();
            CM = new SqlCommand("Select * from CustomerDb where CONCAT(CustomerID,CustomerName) like '%" + SearchCustomerBox.Text + "%'", connection);
            connection.Open();
            Dr = CM.ExecuteReader();
            while (Dr.Read())
            {
                i++;
                dataGridViewCustomer.Rows.Add(i, Dr[0].ToString(), Dr[1].ToString());
            }
            Dr.Close();
            connection.Close();
        }
        public void LoadProduct()
        {
            int i = 0;
            dataGridViewProduct.Rows.Clear();
            CM = new SqlCommand("Select * from ProductDb where CONCAT(ProductName,Quantity, Price, Description, ProductCategory) like '%" + SearchProductBox.Text + "%'", connection);
            connection.Open();
            Dr = CM.ExecuteReader();
            while (Dr.Read())
            {
                i++;
                dataGridViewProduct.Rows.Add(i, Dr[0].ToString(), Dr[1].ToString(), Dr[2].ToString(), Dr[3].ToString(), Dr[4].ToString(), Dr[5].ToString());
            }
            Dr.Close();
            connection.Close();
        }

        private void SearchCustomerBox_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void SearchProductBox_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
        int quantity = 0;
        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductIDBox.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            ProductNameBox.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            quantity = Convert.ToInt16(dataGridViewProduct.Rows[e.RowIndex].Cells[3].Value.ToString());
            PriceBox.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
            TotalBox.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIDBox.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            CustomerNameBox.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void OrderInsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerIDBox.Text == "")
                {
                    MessageBox.Show("Please select a Customer", "Customer Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ProductIDBox.Text == "")
                {
                    MessageBox.Show("Please select a Product", "Product Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to insert this Order?", "Insert Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string insert = "insert into OrderDb(OrderDate,ProductID,CustomerID,Quantity,Price,Total)values(@OrderDate,@ProductID,@CustomerID,@Quantity,@Price,@Total)";
                    CM = new SqlCommand(insert, connection);
                    CM.Parameters.AddWithValue("@OrderDate", dateTimeOrder.Value);
                    CM.Parameters.AddWithValue("@ProductID", Convert.ToInt16(ProductIDBox.Text));
                    CM.Parameters.AddWithValue("@CustomerID", Convert.ToInt16(CustomerIDBox.Text));
                    CM.Parameters.AddWithValue("@Quantity", Convert.ToInt16(UDQuantity.Value));
                    CM.Parameters.AddWithValue("@Price", Convert.ToDouble(PriceBox.Text));
                    CM.Parameters.AddWithValue("@Total", Convert.ToDouble(TotalBox.Text));
                    connection.Open();
                    CM.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Order has been successfully saved");

                    string update = "UPDATE ProductDb SET Quantity = (Quantity-@Quantity) WHERE ProductID like '" + ProductIDBox.Text + "' ";
                    CM = new SqlCommand(update, connection);
                    CM.Parameters.AddWithValue("@Quantity", UDQuantity.Value);
                    connection.Open();
                    CM.ExecuteNonQuery();
                    connection.Close();
                    Clear();
                    LoadProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Clear()
        {
            CustomerIDBox.Clear();
            CustomerNameBox.Clear();
            ProductIDBox.Clear();
            ProductNameBox.Clear();
            dateTimeOrder.Value= DateTime.Now;
            PriceBox.Clear();
            UDQuantity.Value = 0;
            TotalBox.Clear();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void UDQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(UDQuantity.Value) > quantity)
            {
                MessageBox.Show("Instock quantity is not enough!", "Warning Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UDQuantity.Value = UDQuantity.Value - 1;
                return;
            }
            if (Convert.ToInt16(UDQuantity.Value) > 0)
            {
                double total = Convert.ToInt16(UDQuantity.Value) * Convert.ToDouble(PriceBox.Text);
                TotalBox.Text = total.ToString();
            }
        }
    }
}

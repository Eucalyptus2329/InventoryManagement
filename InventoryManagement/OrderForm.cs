using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class OrderForm : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=EULIX-LAPTOP;Initial Catalog=PavillionManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand CM = new SqlCommand();
        SqlDataReader Dr;
        public OrderForm()
        {
            InitializeComponent();
            LoadOrder();
        }
        public void LoadOrder()
        {
            double total = 0;
            int i = 0;
            dataGridViewOrder.Rows.Clear();
            CM = new SqlCommand("Select OrderId, OrderDate, O.ProductID, P.ProductName, O.CustomerID, C.CustomerName, O.Quantity, O.Price, O.Total from OrderDb as O Join CustomerDb as C ON O.CustomerID = C.CustomerID JOIN ProductDb as P on O.ProductID = P.ProductID where CONCAT( OrderId, OrderDate, O.ProductID, P.ProductName, O.CustomerID, C.CustomerName, O.Quantity, O.Price, O.Total) like '%" + SearchBox.Text + "%'", connection);
            connection.Open();
            Dr = CM.ExecuteReader();
            while (Dr.Read())
            {
                i++;
                dataGridViewOrder.Rows.Add(i, Dr[0].ToString(), Convert.ToDateTime(Dr[1].ToString()).ToString("dd/MM/yyyy"), Dr[2].ToString(), Dr[3].ToString(), Dr[4].ToString(), Dr[5].ToString(), Dr[6].ToString(), Dr[7].ToString(), Dr[8].ToString());
                total += Convert.ToDouble(Dr[8].ToString());
            }
            Dr.Close();
            connection.Close();
            QuantityText.Text = i.ToString();
            TotalText.Text = total.ToString();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            OrderModule OrderModule = new OrderModule();
            OrderModule.ShowDialog();
            LoadOrder();
        }

        private void dataGridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewOrder.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this Order?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Open();
                    CM = new SqlCommand("Delete from OrderDb WHERE OrderID like '" + dataGridViewOrder.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ", connection);
                    CM.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Order has been successfully deleted");

                    string update = "UPDATE ProductDb SET Quantity = (Quantity+@Quantity) WHERE ProductID like '" + dataGridViewOrder.Rows[e.RowIndex].Cells[3].Value.ToString() + "' ";
                    CM = new SqlCommand(update, connection);
                    CM.Parameters.AddWithValue("@Quantity", Convert.ToInt16(dataGridViewOrder.Rows[e.RowIndex].Cells[7].Value.ToString()));
                    connection.Open();
                    CM.ExecuteNonQuery();
                    connection.Close();

                }
                LoadOrder();
            }
        }

        private void dataGridViewOrder_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            string colName = dataGridViewOrder.Columns[e.ColumnIndex].Name;
            if (colName == "Delete") 
            {
                dataGridViewOrder.Cursor = Cursors.Hand;
            }
            else
            {
                dataGridViewOrder.Cursor = Cursors.Default;
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadOrder();
        }
    }
}

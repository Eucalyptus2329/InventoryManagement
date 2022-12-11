using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class CustomerForm : Form
    {
        //Connect to SQL DataBase
        SqlConnection connection = new SqlConnection("Data Source=EULIX-LAPTOP;Initial Catalog=PavillionManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand CM = new SqlCommand();
        SqlDataReader Dr;
        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomer();
        }
        public void LoadCustomer()
        {
            int i = 0;
            dataGridViewCustomer.Rows.Clear();
            CM = new SqlCommand("Select * from CustomerDb", connection);
            connection.Open();
            Dr = CM.ExecuteReader();
            while (Dr.Read())
            {
                i++;
                dataGridViewCustomer.Rows.Add(i, Dr[0].ToString(), Dr[1].ToString(), Dr[2].ToString());
            }
            Dr.Close();
            connection.Close();
        }   
        private void AddButton_Click(object sender, System.EventArgs e)
        {
            CustomerModule CustomerModule = new CustomerModule();
            CustomerModule.SaveButton.Enabled = true;
            CustomerModule.UpdateButton.Enabled = false;
            CustomerModule.ShowDialog();
            LoadCustomer();
        }

        //Edit and Delete Button
        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewCustomer.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CustomerModule CustomerModule = new CustomerModule();
                CustomerModule.CustomerIDLabel.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                CustomerModule.CustomerNameTxtBox.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                CustomerModule.PhoneNumberTxtBox.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                CustomerModule.SaveButton.Enabled = false;
                CustomerModule.UpdateButton.Enabled = true;
                CustomerModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this User?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Open();
                    CM = new SqlCommand("Delete from CustomerDb WHERE CustomerName like '" + dataGridViewCustomer.Rows[e.RowIndex].Cells[2].Value.ToString() + "' ", connection);
                    CM.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("User has been successfully deleted");
                }
            }
            LoadCustomer();
        }
        //Hand Cursor for Edit and Delete Button Specifically in Data Grid
        private void dataGridViewCustomer_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            string colName = dataGridViewCustomer.Columns[e.ColumnIndex].Name;
            if (colName == "Edit" || colName == "Delete") // C# supports two boolean or operators: the single bar | and the double-bar ||. The difference is that | always checks both the left and right conditions, while || only checks the right - side condition if it's necessary (if the left side evaluates to false).
            {
                dataGridViewCustomer.Cursor = Cursors.Hand;
            }
            else
            {
                dataGridViewCustomer.Cursor = Cursors.Default;
            }
        }
    }
}

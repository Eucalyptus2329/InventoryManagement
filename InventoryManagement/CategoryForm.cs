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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace InventoryManagement
{
    public partial class CategoryForm : Form
    {
        //Connect to SQL DataBase
        SqlConnection connection = new SqlConnection("Data Source=EULIX-LAPTOP;Initial Catalog=PavillionManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand CM = new SqlCommand();
        SqlDataReader Dr;
        public CategoryForm()
        {
            InitializeComponent();
            LoadCategory();
        }
        public void LoadCategory()
        {
            int i = 0;
            dataGridViewCategory.Rows.Clear();
            CM = new SqlCommand("Select * from CategoryDb", connection);
            connection.Open();
            Dr = CM.ExecuteReader();
            while (Dr.Read())
            {
                i++;
                dataGridViewCategory.Rows.Add(i, Dr[0].ToString(), Dr[1].ToString());
            }
            Dr.Close();
            connection.Close();
        }
        //Edit and Delete Button
        private void dataGridViewCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewCategory.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CategoryModule CategoryModule = new CategoryModule();
                CategoryModule.CategoryIDLabel.Text = dataGridViewCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                CategoryModule.CategoryNameTxtBox.Text = dataGridViewCategory.Rows[e.RowIndex].Cells[2].Value.ToString();
                CategoryModule.SaveButton.Enabled = false;
                CategoryModule.UpdateButton.Enabled = true;
                CategoryModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this Category?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Open();
                    CM = new SqlCommand("Delete from CategoryDb WHERE CategoryName like '" + dataGridViewCategory.Rows[e.RowIndex].Cells[2].Value.ToString() + "' ", connection);
                    CM.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Category has been successfully deleted");
                }
            }
            LoadCategory();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CategoryModule CategoryModule = new CategoryModule();
           CategoryModule.SaveButton.Enabled = true;
           CategoryModule.UpdateButton.Enabled = false;
           CategoryModule.ShowDialog();
            LoadCategory();
        }
        //Hand Cursor for Edit and Delete Button Specifically in Data Grid
        private void dataGridViewCategory_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            string colName = dataGridViewCategory.Columns[e.ColumnIndex].Name;
            if (colName == "Edit" || colName == "Delete") // C# supports two boolean or operators: the single bar | and the double-bar ||. The difference is that | always checks both the left and right conditions, while || only checks the right - side condition if it's necessary (if the left side evaluates to false).
            {
                dataGridViewCategory.Cursor = Cursors.Hand;
            }
            else
            {
                dataGridViewCategory.Cursor = Cursors.Default;
            }
        }
    }
}

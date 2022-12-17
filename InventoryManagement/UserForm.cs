using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class UserForm : Form
    {
        //Connect to SQL DataBase
        SqlConnection connection = new SqlConnection("Data Source=EULIX-LAPTOP;Initial Catalog=PavillionManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand CM = new SqlCommand();
        SqlDataReader Dr;
        public UserForm()
        {
            InitializeComponent();
            LoadUser();
        }
        //Loads Data Grid View Using SQL 
        public void LoadUser()
        {
            int i = 0;
            dataGridView.Rows.Clear();
            CM = new SqlCommand("Select * from UserFormDb", connection);
            connection.Open();
            Dr = CM.ExecuteReader();
            while (Dr.Read())
            {
                i++;
                dataGridView.Rows.Add( i, Dr[0].ToString(), Dr[1].ToString(), Dr[2].ToString(), Dr[3].ToString());
            }
            Dr.Close();
            connection.Close();
        }

        //Add button
        private void AddButton_Click(object sender, System.EventArgs e)
        {
            UserModule userModule = new UserModule();
            userModule.SaveButton.Enabled = true;
            userModule.UpdateButton.Enabled = false;
            userModule.ShowDialog();
            LoadUser();
        }

        //Edit and Delete Button
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            { 
                UserModule userModule = new UserModule();
                userModule.UsernameTxtBox.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.PasswordTxtBox.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.FullNameTxtBox.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.PhoneNumberTxtBox.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                userModule.SaveButton.Enabled = false;
                userModule.UpdateButton.Enabled = true;
                userModule.ShowDialog();
            }
            else if(colName == "Delete") 
            {
                if (MessageBox.Show("Are you sure you want to delete this User?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Open();
                    CM = new SqlCommand("Delete from UserFormDb WHERE Username like '" + dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString() +"' ", connection);
                    CM.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("User has been successfully deleted");
                }
            }
            LoadUser();
        }

        //Hand Cursor for Edit and Delete Button Specifically in Data Grid
        private void dataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            string colName = dataGridView.Columns[e.ColumnIndex].Name;
            if (colName == "Edit" || colName == "Delete") // C# supports two boolean or operators: the single bar | and the double-bar ||. The difference is that | always checks both the left and right conditions, while || only checks the right - side condition if it's necessary (if the left side evaluates to false).
            {
                dataGridView.Cursor = Cursors.Hand;
            }
            else
            {
                dataGridView.Cursor = Cursors.Default;
            }
        }
    }
}

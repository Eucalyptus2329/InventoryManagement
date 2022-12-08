using Dapper;
using System;
using System.Windows.Forms;


namespace InventoryManagement
{
    public partial class UserModule : Form 
    {
        public UserModule()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            UsernameTxt.Clear();
            PasswordTxt.Clear();
            FullNameTxt.Clear();
            PhoneNumberTxt.Clear();
        }
        private void CloseWindowButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                if (MessageBox.Show("Are you sure you want to save this User?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    {
                        string spName = "dbo.SpUserFormDb";
                        DynamicParameters para = new DynamicParameters();
                        para.AddDynamicParams
                            (
                            new
                            {
                                id = 1,
                                Username = user.Username,
                                Password = user.Password,
                                Fullname = user.Fullname,
                                PhoneNumber = user.PhoneNumber
                            });
                        //Insert Function
                        DapperDatabase dbhelper = new DapperDatabase();
                        int InsertQueyry = dbhelper.Execute(spName,para);
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this User?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
            {
                {
                    User user = new User();
                    string spName = "dbo.SpUserFormDb";
                    DynamicParameters para = new DynamicParameters();
                    para.AddDynamicParams
                        (
                        new
                        {
                            id = 2,
                            Username = user.Username,
                            Password = user.Password,
                            Fullname = user.Fullname,
                            PhoneNumber = user.PhoneNumber
                        });
                    //Insert Function
                    DapperDatabase dbhelper = new DapperDatabase();
                    int InsertQueyry = dbhelper.Execute(spName, para);
                }
            }
            Clear();
        }
    }
}

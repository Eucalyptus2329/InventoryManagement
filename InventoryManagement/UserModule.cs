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
                if(MessageBox.Show("Are you sure you want to save this User?","Saving Record",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DapperDatabase dbhelper = new DapperDatabase();
                    int Save = dbhelper.Execute();
                    MessageBox.Show("User has been Successfully Saved");
                    
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}

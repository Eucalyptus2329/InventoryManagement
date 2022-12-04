using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Clear();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}

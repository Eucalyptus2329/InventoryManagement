using System;
using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }
        //To Show Sub Form in Main Form
        private Form activeForm = null;
        private void openChildform(Form childform)
        {
            if(activeForm != null) 
                activeForm.Close();
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle= FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            FormPanel.Controls.Add(childform);
            FormPanel.Tag= childform;
            childform.BringToFront();  // BringToFront() -> front of the z-order
            childform.Show();
        }
        //Add Background Transition When Hovering 
        private void ProductButton_MouseHover(object sender, EventArgs e)
        {
            ProductButton.BackColor = Color.DodgerBlue;
        }

        private void ProductButton_MouseLeave(object sender, EventArgs e)
        {
            ProductButton.BackColor = Color.MediumTurquoise;
        }

        private void CustomerButton_MouseHover(object sender, EventArgs e)
        {
            CustomerButton.BackColor = Color.DodgerBlue;
        }

        private void CustomerButton_MouseLeave(object sender, EventArgs e)
        {
            CustomerButton.BackColor = Color.MediumTurquoise;
        }

        private void UserButton_MouseHover(object sender, EventArgs e)
        {
            UserButton.BackColor = Color.DodgerBlue;
        }

        private void UserButton_MouseLeave(object sender, EventArgs e)
        {
            UserButton.BackColor = Color.MediumTurquoise;   
        }

        private void CategoriesButton_MouseHover(object sender, EventArgs e)
        {
            CategoriesButton.BackColor = Color.DodgerBlue;  
        }

        private void CategoriesButton_MouseLeave(object sender, EventArgs e)
        {
            CategoriesButton.BackColor = Color.MediumTurquoise;
        }

        private void OrderButton_MouseHover(object sender, EventArgs e)
        {
            OrderButton.BackColor = Color.DodgerBlue;
        }

        private void OrderButton_MouseLeave(object sender, EventArgs e)
        {
            OrderButton.BackColor = Color.MediumTurquoise;
        }
        private void UserButton_Click(object sender, EventArgs e)
        {
            openChildform(new UserForm());
        }
        private void CustomerButton_Click(object sender, EventArgs e)
        {
            openChildform(new CustomerForm());
        }
        private void ProductButton_Click(object sender, EventArgs e)
        {
            openChildform(new ProductForm());
        }

        private void CategoriesButton_Click(object sender, EventArgs e)
        {
            openChildform(new CategoryForm());
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            openChildform(new OrderForm());
        }
    }
}

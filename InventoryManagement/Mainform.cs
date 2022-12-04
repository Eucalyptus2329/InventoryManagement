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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }
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
    }
}

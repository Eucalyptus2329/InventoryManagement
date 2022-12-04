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

        private void ProductPanel_MouseHover(object sender, EventArgs e)
        {
            ProductPanel.BackColor = Color.Turquoise;
        }

        private void ProductPanel_MouseLeave(object sender, EventArgs e)
        {
            ProductPanel.BackColor = Color.LightSteelBlue;
        }

        private void ProductLabel_MouseHover(object sender, EventArgs e)
        {

        }
    }
}

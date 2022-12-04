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
    public partial class ButtonImageHover : PictureBox
    {
        public ButtonImageHover()
        {
            InitializeComponent();
        }

        private Image NormalImage;
        private Image SetImage;

        public Image ImageNormal
        {
            get { return NormalImage; }
            set { NormalImage = value; }
        }

        public Image HoverImage
        {
            get { return SetImage; }
            set { SetImage = value; }
        }

        private void ImageHover_MouseHover(object sender, EventArgs e)
        {
            this.Image = SetImage;
        }

        private void ImageHover_MouseLeave(object sender, EventArgs e)
        {
            this.Image = NormalImage;
        }
    }
}

namespace InventoryManagement
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.OrderLabel = new System.Windows.Forms.Label();
            this.CategoriesLabel = new System.Windows.Forms.Label();
            this.UsersLabel = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.OrderImage = new System.Windows.Forms.PictureBox();
            this.CategoriesImage = new System.Windows.Forms.PictureBox();
            this.UsersImage = new System.Windows.Forms.PictureBox();
            this.CustomerImage = new System.Windows.Forms.PictureBox();
            this.ProductImage = new System.Windows.Forms.PictureBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.ProductPanel = new System.Windows.Forms.Panel();
            this.CustomerPanel = new System.Windows.Forms.Panel();
            this.Userspanel = new System.Windows.Forms.Panel();
            this.Categoriespanel = new System.Windows.Forms.Panel();
            this.Orderspanel = new System.Windows.Forms.Panel();
            this.LowerPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.ProductPanel.SuspendLayout();
            this.CustomerPanel.SuspendLayout();
            this.Userspanel.SuspendLayout();
            this.Categoriespanel.SuspendLayout();
            this.Orderspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLabel.ForeColor = System.Drawing.Color.White;
            this.OrderLabel.Location = new System.Drawing.Point(167, 35);
            this.OrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(76, 24);
            this.OrderLabel.TabIndex = 19;
            this.OrderLabel.Text = "Orders";
            // 
            // CategoriesLabel
            // 
            this.CategoriesLabel.AutoSize = true;
            this.CategoriesLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesLabel.ForeColor = System.Drawing.Color.White;
            this.CategoriesLabel.Location = new System.Drawing.Point(143, 35);
            this.CategoriesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoriesLabel.Name = "CategoriesLabel";
            this.CategoriesLabel.Size = new System.Drawing.Size(124, 24);
            this.CategoriesLabel.TabIndex = 18;
            this.CategoriesLabel.Text = "Categories";
            // 
            // UsersLabel
            // 
            this.UsersLabel.AutoSize = true;
            this.UsersLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersLabel.ForeColor = System.Drawing.Color.White;
            this.UsersLabel.Location = new System.Drawing.Point(175, 35);
            this.UsersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsersLabel.Name = "UsersLabel";
            this.UsersLabel.Size = new System.Drawing.Size(60, 24);
            this.UsersLabel.TabIndex = 17;
            this.UsersLabel.Text = "Users";
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.ForeColor = System.Drawing.Color.White;
            this.CustomerLabel.Location = new System.Drawing.Point(147, 35);
            this.CustomerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(116, 24);
            this.CustomerLabel.TabIndex = 16;
            this.CustomerLabel.Text = "Customers";
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.ForeColor = System.Drawing.Color.White;
            this.ProductLabel.Location = new System.Drawing.Point(160, 35);
            this.ProductLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(91, 24);
            this.ProductLabel.TabIndex = 15;
            this.ProductLabel.Text = "Product";
            this.ProductLabel.MouseHover += new System.EventHandler(this.ProductLabel_MouseHover);
            // 
            // OrderImage
            // 
            this.OrderImage.Image = ((System.Drawing.Image)(resources.GetObject("OrderImage.Image")));
            this.OrderImage.Location = new System.Drawing.Point(35, 13);
            this.OrderImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderImage.Name = "OrderImage";
            this.OrderImage.Size = new System.Drawing.Size(75, 64);
            this.OrderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OrderImage.TabIndex = 4;
            this.OrderImage.TabStop = false;
            // 
            // CategoriesImage
            // 
            this.CategoriesImage.Image = ((System.Drawing.Image)(resources.GetObject("CategoriesImage.Image")));
            this.CategoriesImage.Location = new System.Drawing.Point(35, 13);
            this.CategoriesImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategoriesImage.Name = "CategoriesImage";
            this.CategoriesImage.Size = new System.Drawing.Size(75, 64);
            this.CategoriesImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CategoriesImage.TabIndex = 3;
            this.CategoriesImage.TabStop = false;
            // 
            // UsersImage
            // 
            this.UsersImage.Image = ((System.Drawing.Image)(resources.GetObject("UsersImage.Image")));
            this.UsersImage.Location = new System.Drawing.Point(35, 13);
            this.UsersImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsersImage.Name = "UsersImage";
            this.UsersImage.Size = new System.Drawing.Size(75, 64);
            this.UsersImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UsersImage.TabIndex = 2;
            this.UsersImage.TabStop = false;
            // 
            // CustomerImage
            // 
            this.CustomerImage.Image = ((System.Drawing.Image)(resources.GetObject("CustomerImage.Image")));
            this.CustomerImage.Location = new System.Drawing.Point(35, 13);
            this.CustomerImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerImage.Name = "CustomerImage";
            this.CustomerImage.Size = new System.Drawing.Size(75, 64);
            this.CustomerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CustomerImage.TabIndex = 1;
            this.CustomerImage.TabStop = false;
            // 
            // ProductImage
            // 
            this.ProductImage.Image = ((System.Drawing.Image)(resources.GetObject("ProductImage.Image")));
            this.ProductImage.Location = new System.Drawing.Point(35, 15);
            this.ProductImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(75, 64);
            this.ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductImage.TabIndex = 0;
            this.ProductImage.TabStop = false;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Turquoise;
            this.HeaderPanel.Controls.Add(this.TitleLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1924, 142);
            this.HeaderPanel.TabIndex = 2;
            // 
            // ProductPanel
            // 
            this.ProductPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ProductPanel.Controls.Add(this.ProductImage);
            this.ProductPanel.Controls.Add(this.ProductLabel);
            this.ProductPanel.Location = new System.Drawing.Point(0, 142);
            this.ProductPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(400, 100);
            this.ProductPanel.TabIndex = 20;
            this.ProductPanel.MouseLeave += new System.EventHandler(this.ProductPanel_MouseLeave);
            this.ProductPanel.MouseHover += new System.EventHandler(this.ProductPanel_MouseHover);
            // 
            // CustomerPanel
            // 
            this.CustomerPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CustomerPanel.Controls.Add(this.CustomerImage);
            this.CustomerPanel.Controls.Add(this.CustomerLabel);
            this.CustomerPanel.Location = new System.Drawing.Point(0, 241);
            this.CustomerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerPanel.Name = "CustomerPanel";
            this.CustomerPanel.Size = new System.Drawing.Size(400, 100);
            this.CustomerPanel.TabIndex = 21;
            // 
            // Userspanel
            // 
            this.Userspanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Userspanel.Controls.Add(this.UsersImage);
            this.Userspanel.Controls.Add(this.UsersLabel);
            this.Userspanel.Location = new System.Drawing.Point(0, 341);
            this.Userspanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Userspanel.Name = "Userspanel";
            this.Userspanel.Size = new System.Drawing.Size(400, 100);
            this.Userspanel.TabIndex = 22;
            // 
            // Categoriespanel
            // 
            this.Categoriespanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Categoriespanel.Controls.Add(this.CategoriesImage);
            this.Categoriespanel.Controls.Add(this.CategoriesLabel);
            this.Categoriespanel.Location = new System.Drawing.Point(0, 441);
            this.Categoriespanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Categoriespanel.Name = "Categoriespanel";
            this.Categoriespanel.Size = new System.Drawing.Size(400, 100);
            this.Categoriespanel.TabIndex = 22;
            // 
            // Orderspanel
            // 
            this.Orderspanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Orderspanel.Controls.Add(this.OrderLabel);
            this.Orderspanel.Controls.Add(this.OrderImage);
            this.Orderspanel.Location = new System.Drawing.Point(0, 532);
            this.Orderspanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Orderspanel.Name = "Orderspanel";
            this.Orderspanel.Size = new System.Drawing.Size(400, 100);
            this.Orderspanel.TabIndex = 22;
            // 
            // LowerPanel
            // 
            this.LowerPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LowerPanel.Location = new System.Drawing.Point(0, 628);
            this.LowerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LowerPanel.Name = "LowerPanel";
            this.LowerPanel.Size = new System.Drawing.Size(400, 480);
            this.LowerPanel.TabIndex = 23;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(41, 21);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(319, 97);
            this.TitleLabel.TabIndex = 14;
            this.TitleLabel.Text = "Pavillion Management";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1924, 932);
            this.Controls.Add(this.LowerPanel);
            this.Controls.Add(this.Orderspanel);
            this.Controls.Add(this.Categoriespanel);
            this.Controls.Add(this.Userspanel);
            this.Controls.Add(this.CustomerPanel);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Mainform";
            this.Text = "Mainform";
            ((System.ComponentModel.ISupportInitialize)(this.OrderImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.ProductPanel.ResumeLayout(false);
            this.ProductPanel.PerformLayout();
            this.CustomerPanel.ResumeLayout(false);
            this.CustomerPanel.PerformLayout();
            this.Userspanel.ResumeLayout(false);
            this.Userspanel.PerformLayout();
            this.Categoriespanel.ResumeLayout(false);
            this.Categoriespanel.PerformLayout();
            this.Orderspanel.ResumeLayout(false);
            this.Orderspanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.Label CategoriesLabel;
        private System.Windows.Forms.Label UsersLabel;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.PictureBox OrderImage;
        private System.Windows.Forms.PictureBox CategoriesImage;
        private System.Windows.Forms.PictureBox UsersImage;
        private System.Windows.Forms.PictureBox CustomerImage;
        private System.Windows.Forms.PictureBox ProductImage;
        private System.Windows.Forms.Panel ProductPanel;
        private System.Windows.Forms.Panel CustomerPanel;
        private System.Windows.Forms.Panel Userspanel;
        private System.Windows.Forms.Panel Categoriespanel;
        private System.Windows.Forms.Panel Orderspanel;
        private System.Windows.Forms.Panel LowerPanel;
        private System.Windows.Forms.Label TitleLabel;
    }
}
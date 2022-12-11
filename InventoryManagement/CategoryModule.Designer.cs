namespace InventoryManagement
{
    partial class CategoryModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryModule));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.CloseWindowButton = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CategoryNameTxtBox = new System.Windows.Forms.TextBox();
            this.CategoryNameLabel = new System.Windows.Forms.Label();
            this.CategoryIDLabel = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseWindowButton)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Turquoise;
            this.HeaderPanel.Controls.Add(this.CloseWindowButton);
            this.HeaderPanel.Controls.Add(this.TitleLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(582, 99);
            this.HeaderPanel.TabIndex = 2;
            // 
            // CloseWindowButton
            // 
            this.CloseWindowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseWindowButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseWindowButton.Image")));
            this.CloseWindowButton.Location = new System.Drawing.Point(559, 3);
            this.CloseWindowButton.Name = "CloseWindowButton";
            this.CloseWindowButton.Size = new System.Drawing.Size(23, 20);
            this.CloseWindowButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseWindowButton.TabIndex = 16;
            this.CloseWindowButton.TabStop = false;
            this.CloseWindowButton.Click += new System.EventHandler(this.CloseWindowButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(32, 41);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(173, 23);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Category Module";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClearButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(415, 185);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(88, 28);
            this.ClearButton.TabIndex = 32;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.SkyBlue;
            this.UpdateButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(309, 185);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(88, 28);
            this.UpdateButton.TabIndex = 31;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.SaveButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(197, 185);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(88, 28);
            this.SaveButton.TabIndex = 30;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CategoryNameTxtBox
            // 
            this.CategoryNameTxtBox.Location = new System.Drawing.Point(197, 141);
            this.CategoryNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryNameTxtBox.Name = "CategoryNameTxtBox";
            this.CategoryNameTxtBox.Size = new System.Drawing.Size(305, 22);
            this.CategoryNameTxtBox.TabIndex = 28;
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.AutoSize = true;
            this.CategoryNameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNameLabel.Location = new System.Drawing.Point(33, 141);
            this.CategoryNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(131, 20);
            this.CategoryNameLabel.TabIndex = 26;
            this.CategoryNameLabel.Text = "Category Name:";
            // 
            // CategoryIDLabel
            // 
            this.CategoryIDLabel.AutoSize = true;
            this.CategoryIDLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryIDLabel.Location = new System.Drawing.Point(32, 187);
            this.CategoryIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoryIDLabel.Name = "CategoryIDLabel";
            this.CategoryIDLabel.Size = new System.Drawing.Size(95, 20);
            this.CategoryIDLabel.TabIndex = 33;
            this.CategoryIDLabel.Text = "CategoryID";
            this.CategoryIDLabel.Visible = false;
            // 
            // CategoriesModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 238);
            this.Controls.Add(this.CategoryIDLabel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CategoryNameLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CategoryNameTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoriesModuleForm";
            this.Text = "CategoriesModuleForm";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseWindowButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox CloseWindowButton;
        private System.Windows.Forms.Label TitleLabel;
        public System.Windows.Forms.Button ClearButton;
        public System.Windows.Forms.Button UpdateButton;
        public System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.TextBox CategoryNameTxtBox;
        private System.Windows.Forms.Label CategoryNameLabel;
        public System.Windows.Forms.Label CategoryIDLabel;
    }
}
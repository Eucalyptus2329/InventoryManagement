namespace InventoryManagement
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.LoginButton = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.showPasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.ClearLabel = new System.Windows.Forms.Label();
            this.CloseImage = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.DevelopedLabel = new System.Windows.Forms.Label();
            this.CompanyHeader = new System.Windows.Forms.Label();
            this.MainImage = new System.Windows.Forms.PictureBox();
            this.LockImage = new System.Windows.Forms.PictureBox();
            this.UserImage = new System.Windows.Forms.PictureBox();
            this.CloseWindowButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseImage)).BeginInit();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LockImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseWindowButton)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameBox
            // 
            this.UsernameBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameBox.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.UsernameBox.Location = new System.Drawing.Point(495, 229);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameBox.MinimumSize = new System.Drawing.Size(269, 30);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(284, 30);
            this.UsernameBox.TabIndex = 2;
            this.UsernameBox.Text = "Username";
            this.UsernameBox.Enter += new System.EventHandler(this.UsernameBoxEnter);
            this.UsernameBox.Leave += new System.EventHandler(this.UsernameBoxLeave);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Turquoise;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginButton.Location = new System.Drawing.Point(495, 401);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(284, 38);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.PasswordBox.Location = new System.Drawing.Point(495, 290);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordBox.MinimumSize = new System.Drawing.Size(269, 30);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(284, 30);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.Text = "Password";
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            this.PasswordBox.Enter += new System.EventHandler(this.PasswordBoxEnter);
            this.PasswordBox.Leave += new System.EventHandler(this.PasswordBoxLeave);
            // 
            // showPasswordCheckbox
            // 
            this.showPasswordCheckbox.AutoSize = true;
            this.showPasswordCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPasswordCheckbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordCheckbox.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.showPasswordCheckbox.Location = new System.Drawing.Point(601, 356);
            this.showPasswordCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.showPasswordCheckbox.Name = "showPasswordCheckbox";
            this.showPasswordCheckbox.Size = new System.Drawing.Size(142, 24);
            this.showPasswordCheckbox.TabIndex = 5;
            this.showPasswordCheckbox.Text = "Show Password";
            this.showPasswordCheckbox.UseVisualStyleBackColor = true;
            this.showPasswordCheckbox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.HeaderLabel.Location = new System.Drawing.Point(495, 156);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(328, 69);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Login To Your Account";
            // 
            // ClearLabel
            // 
            this.ClearLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.ClearLabel.Location = new System.Drawing.Point(491, 357);
            this.ClearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClearLabel.Name = "ClearLabel";
            this.ClearLabel.Size = new System.Drawing.Size(69, 28);
            this.ClearLabel.TabIndex = 4;
            this.ClearLabel.Text = "Clear";
            this.ClearLabel.Click += new System.EventHandler(this.ClearLabel_Click);
            // 
            // CloseImage
            // 
            this.CloseImage.Location = new System.Drawing.Point(12, 12);
            this.CloseImage.Name = "CloseImage";
            this.CloseImage.Size = new System.Drawing.Size(52, 50);
            this.CloseImage.TabIndex = 7;
            this.CloseImage.TabStop = false;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.Turquoise;
            this.LeftPanel.Controls.Add(this.DevelopedLabel);
            this.LeftPanel.Controls.Add(this.CompanyHeader);
            this.LeftPanel.Controls.Add(this.MainImage);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(411, 558);
            this.LeftPanel.TabIndex = 11;
            // 
            // DevelopedLabel
            // 
            this.DevelopedLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevelopedLabel.ForeColor = System.Drawing.Color.White;
            this.DevelopedLabel.Location = new System.Drawing.Point(86, 380);
            this.DevelopedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DevelopedLabel.Name = "DevelopedLabel";
            this.DevelopedLabel.Size = new System.Drawing.Size(233, 105);
            this.DevelopedLabel.TabIndex = 13;
            this.DevelopedLabel.Text = "Developed By Eulix Chiu @ 2022";
            this.DevelopedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompanyHeader
            // 
            this.CompanyHeader.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyHeader.ForeColor = System.Drawing.Color.White;
            this.CompanyHeader.Location = new System.Drawing.Point(41, 201);
            this.CompanyHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyHeader.Name = "CompanyHeader";
            this.CompanyHeader.Size = new System.Drawing.Size(323, 149);
            this.CompanyHeader.TabIndex = 12;
            this.CompanyHeader.Text = "Welcome to Pavillion Management";
            this.CompanyHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainImage
            // 
            this.MainImage.Image = ((System.Drawing.Image)(resources.GetObject("MainImage.Image")));
            this.MainImage.Location = new System.Drawing.Point(155, 97);
            this.MainImage.Margin = new System.Windows.Forms.Padding(4);
            this.MainImage.Name = "MainImage";
            this.MainImage.Size = new System.Drawing.Size(88, 84);
            this.MainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainImage.TabIndex = 12;
            this.MainImage.TabStop = false;
            // 
            // LockImage
            // 
            this.LockImage.Image = ((System.Drawing.Image)(resources.GetObject("LockImage.Image")));
            this.LockImage.Location = new System.Drawing.Point(436, 280);
            this.LockImage.Margin = new System.Windows.Forms.Padding(4);
            this.LockImage.Name = "LockImage";
            this.LockImage.Size = new System.Drawing.Size(35, 38);
            this.LockImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LockImage.TabIndex = 13;
            this.LockImage.TabStop = false;
            // 
            // UserImage
            // 
            this.UserImage.Image = ((System.Drawing.Image)(resources.GetObject("UserImage.Image")));
            this.UserImage.Location = new System.Drawing.Point(436, 223);
            this.UserImage.Margin = new System.Windows.Forms.Padding(4);
            this.UserImage.Name = "UserImage";
            this.UserImage.Size = new System.Drawing.Size(35, 38);
            this.UserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserImage.TabIndex = 14;
            this.UserImage.TabStop = false;
            // 
            // CloseWindowButton
            // 
            this.CloseWindowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseWindowButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseWindowButton.Image")));
            this.CloseWindowButton.Location = new System.Drawing.Point(803, 0);
            this.CloseWindowButton.Margin = new System.Windows.Forms.Padding(4);
            this.CloseWindowButton.Name = "CloseWindowButton";
            this.CloseWindowButton.Size = new System.Drawing.Size(35, 27);
            this.CloseWindowButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseWindowButton.TabIndex = 15;
            this.CloseWindowButton.TabStop = false;
            this.CloseWindowButton.Click += new System.EventHandler(this.CloseWindowButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(835, 558);
            this.Controls.Add(this.CloseWindowButton);
            this.Controls.Add(this.UserImage);
            this.Controls.Add(this.LockImage);
            this.Controls.Add(this.ClearLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.showPasswordCheckbox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseImage)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LockImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseWindowButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.CheckBox showPasswordCheckbox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label ClearLabel;
        private System.Windows.Forms.PictureBox CloseImage;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label CompanyHeader;
        private System.Windows.Forms.PictureBox MainImage;
        private System.Windows.Forms.PictureBox UserImage;
        private System.Windows.Forms.PictureBox LockImage;
        private System.Windows.Forms.Label DevelopedLabel;
        private System.Windows.Forms.PictureBox CloseWindowButton;
        public System.Windows.Forms.Button LoginButton;
    }
}


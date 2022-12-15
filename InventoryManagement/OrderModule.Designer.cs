namespace InventoryManagement
{
    partial class OrderModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderModule));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.CloseWindowButton = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.CustomerIDBox = new System.Windows.Forms.TextBox();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.CustomerNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchCustomerBox = new System.Windows.Forms.TextBox();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.UDQuantity = new System.Windows.Forms.NumericUpDown();
            this.ClearButton = new System.Windows.Forms.Button();
            this.OrderInsertButton = new System.Windows.Forms.Button();
            this.OrderDateLabel = new System.Windows.Forms.Label();
            this.dateTimeOrder = new System.Windows.Forms.DateTimePicker();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductNameBox = new System.Windows.Forms.TextBox();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ProductIDBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchProductBox = new System.Windows.Forms.TextBox();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuanitity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderID = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseWindowButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.LeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
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
            this.HeaderPanel.Size = new System.Drawing.Size(1038, 99);
            this.HeaderPanel.TabIndex = 28;
            // 
            // CloseWindowButton
            // 
            this.CloseWindowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseWindowButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseWindowButton.Image")));
            this.CloseWindowButton.Location = new System.Drawing.Point(1015, 0);
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
            this.TitleLabel.Size = new System.Drawing.Size(138, 23);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Order Module";
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCustomer.ColumnHeadersHeight = 30;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.CustomerID,
            this.CustomerName});
            this.dataGridViewCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewCustomer.EnableHeadersVisualStyles = false;
            this.dataGridViewCustomer.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowHeadersVisible = false;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(276, 236);
            this.dataGridViewCustomer.TabIndex = 29;
            this.dataGridViewCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "No.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 53;
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Width = 102;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.White;
            this.LeftPanel.Controls.Add(this.OrderID);
            this.LeftPanel.Controls.Add(this.CustomerIDLabel);
            this.LeftPanel.Controls.Add(this.CustomerIDBox);
            this.LeftPanel.Controls.Add(this.CustomerNameLabel);
            this.LeftPanel.Controls.Add(this.CustomerNameBox);
            this.LeftPanel.Controls.Add(this.label2);
            this.LeftPanel.Controls.Add(this.SearchCustomerBox);
            this.LeftPanel.Controls.Add(this.CustomerLabel);
            this.LeftPanel.Controls.Add(this.dataGridViewCustomer);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 99);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(276, 556);
            this.LeftPanel.TabIndex = 30;
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDLabel.ForeColor = System.Drawing.Color.Black;
            this.CustomerIDLabel.Location = new System.Drawing.Point(16, 342);
            this.CustomerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(103, 20);
            this.CustomerIDLabel.TabIndex = 37;
            this.CustomerIDLabel.Text = "Customer ID:";
            // 
            // CustomerIDBox
            // 
            this.CustomerIDBox.Location = new System.Drawing.Point(20, 365);
            this.CustomerIDBox.Name = "CustomerIDBox";
            this.CustomerIDBox.Size = new System.Drawing.Size(242, 22);
            this.CustomerIDBox.TabIndex = 36;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.ForeColor = System.Drawing.Color.Black;
            this.CustomerNameLabel.Location = new System.Drawing.Point(16, 410);
            this.CustomerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(131, 20);
            this.CustomerNameLabel.TabIndex = 35;
            this.CustomerNameLabel.Text = "Customer Name:";
            // 
            // CustomerNameBox
            // 
            this.CustomerNameBox.Location = new System.Drawing.Point(20, 435);
            this.CustomerNameBox.Name = "CustomerNameBox";
            this.CustomerNameBox.Size = new System.Drawing.Size(242, 22);
            this.CustomerNameBox.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 292);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Search Box:";
            // 
            // SearchCustomerBox
            // 
            this.SearchCustomerBox.Location = new System.Drawing.Point(116, 292);
            this.SearchCustomerBox.Name = "SearchCustomerBox";
            this.SearchCustomerBox.Size = new System.Drawing.Size(146, 22);
            this.SearchCustomerBox.TabIndex = 30;
            this.SearchCustomerBox.TextChanged += new System.EventHandler(this.SearchCustomerBox_TextChanged);
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.CustomerLabel.Location = new System.Drawing.Point(9, 256);
            this.CustomerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(110, 23);
            this.CustomerLabel.TabIndex = 17;
            this.CustomerLabel.Text = "CUSTOMER";
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.White;
            this.RightPanel.Controls.Add(this.UDQuantity);
            this.RightPanel.Controls.Add(this.ClearButton);
            this.RightPanel.Controls.Add(this.OrderInsertButton);
            this.RightPanel.Controls.Add(this.OrderDateLabel);
            this.RightPanel.Controls.Add(this.dateTimeOrder);
            this.RightPanel.Controls.Add(this.ProductNameLabel);
            this.RightPanel.Controls.Add(this.ProductNameBox);
            this.RightPanel.Controls.Add(this.ProductIDLabel);
            this.RightPanel.Controls.Add(this.ProductIDBox);
            this.RightPanel.Controls.Add(this.TotalLabel);
            this.RightPanel.Controls.Add(this.TotalBox);
            this.RightPanel.Controls.Add(this.PriceLabel);
            this.RightPanel.Controls.Add(this.PriceBox);
            this.RightPanel.Controls.Add(this.QuantityLabel);
            this.RightPanel.Controls.Add(this.label1);
            this.RightPanel.Controls.Add(this.SearchProductBox);
            this.RightPanel.Controls.Add(this.ProductLabel);
            this.RightPanel.Controls.Add(this.dataGridViewProduct);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(292, 99);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(746, 556);
            this.RightPanel.TabIndex = 31;
            // 
            // UDQuantity
            // 
            this.UDQuantity.Location = new System.Drawing.Point(545, 398);
            this.UDQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UDQuantity.Name = "UDQuantity";
            this.UDQuantity.Size = new System.Drawing.Size(154, 22);
            this.UDQuantity.TabIndex = 51;
            this.UDQuantity.ValueChanged += new System.EventHandler(this.UDQuantity_ValueChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClearButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(592, 503);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(107, 40);
            this.ClearButton.TabIndex = 50;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // OrderInsertButton
            // 
            this.OrderInsertButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.OrderInsertButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderInsertButton.ForeColor = System.Drawing.Color.White;
            this.OrderInsertButton.Location = new System.Drawing.Point(467, 503);
            this.OrderInsertButton.Margin = new System.Windows.Forms.Padding(4);
            this.OrderInsertButton.Name = "OrderInsertButton";
            this.OrderInsertButton.Size = new System.Drawing.Size(107, 40);
            this.OrderInsertButton.TabIndex = 48;
            this.OrderInsertButton.Text = "Order Insert";
            this.OrderInsertButton.UseVisualStyleBackColor = false;
            this.OrderInsertButton.Click += new System.EventHandler(this.OrderInsertButton_Click);
            // 
            // OrderDateLabel
            // 
            this.OrderDateLabel.AutoSize = true;
            this.OrderDateLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDateLabel.ForeColor = System.Drawing.Color.Black;
            this.OrderDateLabel.Location = new System.Drawing.Point(19, 478);
            this.OrderDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderDateLabel.Name = "OrderDateLabel";
            this.OrderDateLabel.Size = new System.Drawing.Size(96, 20);
            this.OrderDateLabel.TabIndex = 47;
            this.OrderDateLabel.Text = "Order Date:";
            // 
            // dateTimeOrder
            // 
            this.dateTimeOrder.CustomFormat = "dd/MM/yyyy";
            this.dateTimeOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeOrder.Location = new System.Drawing.Point(23, 503);
            this.dateTimeOrder.Name = "dateTimeOrder";
            this.dateTimeOrder.Size = new System.Drawing.Size(239, 22);
            this.dateTimeOrder.TabIndex = 46;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.ForeColor = System.Drawing.Color.Black;
            this.ProductNameLabel.Location = new System.Drawing.Point(19, 410);
            this.ProductNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(119, 20);
            this.ProductNameLabel.TabIndex = 45;
            this.ProductNameLabel.Text = "Product Name:";
            // 
            // ProductNameBox
            // 
            this.ProductNameBox.Location = new System.Drawing.Point(20, 435);
            this.ProductNameBox.Name = "ProductNameBox";
            this.ProductNameBox.Size = new System.Drawing.Size(242, 22);
            this.ProductNameBox.TabIndex = 44;
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDLabel.ForeColor = System.Drawing.Color.Black;
            this.ProductIDLabel.Location = new System.Drawing.Point(19, 341);
            this.ProductIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(91, 20);
            this.ProductIDLabel.TabIndex = 39;
            this.ProductIDLabel.Text = "Product ID:";
            // 
            // ProductIDBox
            // 
            this.ProductIDBox.Location = new System.Drawing.Point(20, 366);
            this.ProductIDBox.Name = "ProductIDBox";
            this.ProductIDBox.Size = new System.Drawing.Size(242, 22);
            this.ProductIDBox.TabIndex = 38;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.ForeColor = System.Drawing.Color.Black;
            this.TotalLabel.Location = new System.Drawing.Point(441, 437);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(46, 20);
            this.TotalLabel.TabIndex = 43;
            this.TotalLabel.Text = "Total:";
            // 
            // TotalBox
            // 
            this.TotalBox.Location = new System.Drawing.Point(542, 435);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(157, 22);
            this.TotalBox.TabIndex = 42;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.Color.Black;
            this.PriceLabel.Location = new System.Drawing.Point(441, 361);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(50, 20);
            this.PriceLabel.TabIndex = 41;
            this.PriceLabel.Text = "Price:";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(542, 359);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(157, 22);
            this.PriceBox.TabIndex = 40;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.ForeColor = System.Drawing.Color.Black;
            this.QuantityLabel.Location = new System.Drawing.Point(441, 398);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(75, 20);
            this.QuantityLabel.TabIndex = 39;
            this.QuantityLabel.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(298, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Search Box:";
            // 
            // SearchProductBox
            // 
            this.SearchProductBox.Location = new System.Drawing.Point(399, 254);
            this.SearchProductBox.Name = "SearchProductBox";
            this.SearchProductBox.Size = new System.Drawing.Size(310, 22);
            this.SearchProductBox.TabIndex = 31;
            this.SearchProductBox.TextChanged += new System.EventHandler(this.SearchProductBox_TextChanged);
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.ProductLabel.Location = new System.Drawing.Point(16, 256);
            this.ProductLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(97, 23);
            this.ProductLabel.TabIndex = 30;
            this.ProductLabel.Text = "PRODUCT";
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewProduct.ColumnHeadersHeight = 30;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ProductID,
            this.ProductName,
            this.ProductQuanitity,
            this.ProductPrice,
            this.ProductDescription,
            this.Category});
            this.dataGridViewProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewProduct.EnableHeadersVisualStyles = false;
            this.dataGridViewProduct.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewProduct.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersVisible = false;
            this.dataGridViewProduct.Size = new System.Drawing.Size(746, 236);
            this.dataGridViewProduct.TabIndex = 3;
            this.dataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "No.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 53;
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.Width = 92;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            // 
            // ProductQuanitity
            // 
            this.ProductQuanitity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductQuanitity.HeaderText = "Quantity";
            this.ProductQuanitity.Name = "ProductQuanitity";
            this.ProductQuanitity.Width = 84;
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Width = 63;
            // 
            // ProductDescription
            // 
            this.ProductDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductDescription.HeaderText = "Product Description";
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.Width = 151;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.Width = 89;
            // 
            // OrderID
            // 
            this.OrderID.AutoSize = true;
            this.OrderID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderID.ForeColor = System.Drawing.Color.Black;
            this.OrderID.Location = new System.Drawing.Point(13, 505);
            this.OrderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(68, 20);
            this.OrderID.TabIndex = 38;
            this.OrderID.Text = "OrderID";
            this.OrderID.Visible = false;
            // 
            // OrderModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 655);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderModule";
            this.Text = "OrderModule";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseWindowButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox CloseWindowButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuanitity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox SearchCustomerBox;
        public System.Windows.Forms.TextBox SearchProductBox;
        private System.Windows.Forms.Label CustomerIDLabel;
        public System.Windows.Forms.TextBox CustomerIDBox;
        private System.Windows.Forms.Label CustomerNameLabel;
        public System.Windows.Forms.TextBox CustomerNameBox;
        private System.Windows.Forms.Label OrderDateLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        public System.Windows.Forms.TextBox ProductNameBox;
        private System.Windows.Forms.Label ProductIDLabel;
        public System.Windows.Forms.TextBox ProductIDBox;
        private System.Windows.Forms.Label TotalLabel;
        public System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.Label PriceLabel;
        public System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label QuantityLabel;
        public System.Windows.Forms.Button ClearButton;
        public System.Windows.Forms.Button OrderInsertButton;
        public System.Windows.Forms.DateTimePicker dateTimeOrder;
        public System.Windows.Forms.NumericUpDown UDQuantity;
        public System.Windows.Forms.Label OrderID;
    }
}
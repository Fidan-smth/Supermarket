namespace Supermarket
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.selling_panel1 = new System.Windows.Forms.Panel();
            this.refresh_button8 = new System.Windows.Forms.Button();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Order_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.Label();
            this.amount_label4 = new System.Windows.Forms.Label();
            this.Add_product_button1 = new System.Windows.Forms.Button();
            this.SellerName = new System.Windows.Forms.Label();
            this.ProdQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Product2_dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.Label();
            this.Bills_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.print_button6 = new System.Windows.Forms.Button();
            this.add_button4 = new System.Windows.Forms.Button();
            this.BillId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selectcategory_comboBox2 = new System.Windows.Forms.ComboBox();
            this.selling_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product2_dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bills_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // selling_panel1
            // 
            this.selling_panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.selling_panel1.Controls.Add(this.refresh_button8);
            this.selling_panel1.Controls.Add(this.ProdPrice);
            this.selling_panel1.Controls.Add(this.ProdName);
            this.selling_panel1.Controls.Add(this.label6);
            this.selling_panel1.Controls.Add(this.Order_dataGridView1);
            this.selling_panel1.Controls.Add(this.Amount);
            this.selling_panel1.Controls.Add(this.amount_label4);
            this.selling_panel1.Controls.Add(this.Add_product_button1);
            this.selling_panel1.Controls.Add(this.SellerName);
            this.selling_panel1.Controls.Add(this.ProdQuantity);
            this.selling_panel1.Controls.Add(this.label9);
            this.selling_panel1.Controls.Add(this.label8);
            this.selling_panel1.Controls.Add(this.Product2_dataGridView2);
            this.selling_panel1.Controls.Add(this.Date);
            this.selling_panel1.Controls.Add(this.selectcategory_comboBox2);
            this.selling_panel1.Controls.Add(this.Bills_dataGridView1);
            this.selling_panel1.Controls.Add(this.print_button6);
            this.selling_panel1.Controls.Add(this.add_button4);
            this.selling_panel1.Controls.Add(this.BillId);
            this.selling_panel1.Controls.Add(this.label3);
            this.selling_panel1.Controls.Add(this.label1);
            this.selling_panel1.Controls.Add(this.label2);
            this.selling_panel1.Location = new System.Drawing.Point(112, 27);
            this.selling_panel1.Name = "selling_panel1";
            this.selling_panel1.Size = new System.Drawing.Size(1089, 645);
            this.selling_panel1.TabIndex = 1;
            this.selling_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // refresh_button8
            // 
            this.refresh_button8.BackColor = System.Drawing.Color.White;
            this.refresh_button8.FlatAppearance.BorderSize = 0;
            this.refresh_button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_button8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_button8.ForeColor = System.Drawing.Color.ForestGreen;
            this.refresh_button8.Location = new System.Drawing.Point(247, 302);
            this.refresh_button8.Name = "refresh_button8";
            this.refresh_button8.Size = new System.Drawing.Size(120, 33);
            this.refresh_button8.TabIndex = 35;
            this.refresh_button8.Text = "Refresh";
            this.refresh_button8.UseVisualStyleBackColor = false;
            this.refresh_button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // ProdPrice
            // 
            this.ProdPrice.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ProdPrice.Location = new System.Drawing.Point(1195, 44);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(15, 32);
            this.ProdPrice.TabIndex = 33;
            this.ProdPrice.Visible = false;
            // 
            // ProdName
            // 
            this.ProdName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ProdName.Location = new System.Drawing.Point(155, 109);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(212, 32);
            this.ProdName.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(707, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 34);
            this.label6.TabIndex = 31;
            this.label6.Text = "Sells list";
            // 
            // Order_dataGridView1
            // 
            this.Order_dataGridView1.AllowUserToOrderColumns = true;
            this.Order_dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Order_dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Order_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Order_dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PName,
            this.Price,
            this.Quantity,
            this.Total});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Order_dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.Order_dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.Order_dataGridView1.Location = new System.Drawing.Point(446, 83);
            this.Order_dataGridView1.Name = "Order_dataGridView1";
            this.Order_dataGridView1.RowHeadersVisible = false;
            this.Order_dataGridView1.RowHeadersWidth = 51;
            this.Order_dataGridView1.RowTemplate.Height = 24;
            this.Order_dataGridView1.Size = new System.Drawing.Size(630, 186);
            this.Order_dataGridView1.TabIndex = 30;
            // 
            // ID
            // 
            this.ID.HeaderText = "ProdID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // PName
            // 
            this.PName.HeaderText = "ProdName";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            this.PName.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "ProdPrice";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "ProdQuantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "ProdTotal";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.ForeColor = System.Drawing.Color.White;
            this.Amount.Location = new System.Drawing.Point(807, 272);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(43, 34);
            this.Amount.TabIndex = 29;
            this.Amount.Text = "Rs";
            // 
            // amount_label4
            // 
            this.amount_label4.AutoSize = true;
            this.amount_label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_label4.ForeColor = System.Drawing.Color.White;
            this.amount_label4.Location = new System.Drawing.Point(642, 272);
            this.amount_label4.Name = "amount_label4";
            this.amount_label4.Size = new System.Drawing.Size(130, 34);
            this.amount_label4.TabIndex = 28;
            this.amount_label4.Text = "Amount ";
            this.amount_label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Add_product_button1
            // 
            this.Add_product_button1.BackColor = System.Drawing.Color.White;
            this.Add_product_button1.FlatAppearance.BorderSize = 0;
            this.Add_product_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_product_button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_product_button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.Add_product_button1.Location = new System.Drawing.Point(155, 194);
            this.Add_product_button1.Name = "Add_product_button1";
            this.Add_product_button1.Size = new System.Drawing.Size(212, 38);
            this.Add_product_button1.TabIndex = 27;
            this.Add_product_button1.Text = "Add Product";
            this.Add_product_button1.UseVisualStyleBackColor = false;
            this.Add_product_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SellerName
            // 
            this.SellerName.AutoSize = true;
            this.SellerName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerName.ForeColor = System.Drawing.Color.White;
            this.SellerName.Location = new System.Drawing.Point(26, 23);
            this.SellerName.Name = "SellerName";
            this.SellerName.Size = new System.Drawing.Size(62, 23);
            this.SellerName.TabIndex = 25;
            this.SellerName.Text = "Seller";
            // 
            // ProdQuantity
            // 
            this.ProdQuantity.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ProdQuantity.Location = new System.Drawing.Point(155, 147);
            this.ProdQuantity.Name = "ProdQuantity";
            this.ProdQuantity.Size = new System.Drawing.Size(212, 32);
            this.ProdQuantity.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(26, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1136, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Price";
            this.label8.Visible = false;
            // 
            // Product2_dataGridView2
            // 
            this.Product2_dataGridView2.AllowUserToOrderColumns = true;
            this.Product2_dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Product2_dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Product2_dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Product2_dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Product2_dataGridView2.DefaultCellStyle = dataGridViewCellStyle10;
            this.Product2_dataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.Product2_dataGridView2.Location = new System.Drawing.Point(29, 337);
            this.Product2_dataGridView2.Name = "Product2_dataGridView2";
            this.Product2_dataGridView2.RowHeadersVisible = false;
            this.Product2_dataGridView2.RowHeadersWidth = 51;
            this.Product2_dataGridView2.RowTemplate.Height = 24;
            this.Product2_dataGridView2.Size = new System.Drawing.Size(338, 295);
            this.Product2_dataGridView2.TabIndex = 20;
            this.Product2_dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Product2_dataGridView2_CellContentClick);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.White;
            this.Date.Location = new System.Drawing.Point(969, 23);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(57, 23);
            this.Date.TabIndex = 19;
            this.Date.Text = "DATE";
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // Bills_dataGridView1
            // 
            this.Bills_dataGridView1.AllowUserToOrderColumns = true;
            this.Bills_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Bills_dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Bills_dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.Bills_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Bills_dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.Bills_dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.Bills_dataGridView1.Location = new System.Drawing.Point(446, 374);
            this.Bills_dataGridView1.Name = "Bills_dataGridView1";
            this.Bills_dataGridView1.RowHeadersVisible = false;
            this.Bills_dataGridView1.RowHeadersWidth = 51;
            this.Bills_dataGridView1.RowTemplate.Height = 24;
            this.Bills_dataGridView1.Size = new System.Drawing.Size(630, 197);
            this.Bills_dataGridView1.TabIndex = 16;
            this.Bills_dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Bills_dataGridView1_CellContentClick);
            // 
            // print_button6
            // 
            this.print_button6.BackColor = System.Drawing.Color.White;
            this.print_button6.FlatAppearance.BorderSize = 0;
            this.print_button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print_button6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_button6.ForeColor = System.Drawing.Color.ForestGreen;
            this.print_button6.Location = new System.Drawing.Point(813, 583);
            this.print_button6.Name = "print_button6";
            this.print_button6.Size = new System.Drawing.Size(100, 43);
            this.print_button6.TabIndex = 14;
            this.print_button6.Text = "Print";
            this.print_button6.UseVisualStyleBackColor = false;
            this.print_button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // add_button4
            // 
            this.add_button4.BackColor = System.Drawing.Color.White;
            this.add_button4.FlatAppearance.BorderSize = 0;
            this.add_button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button4.ForeColor = System.Drawing.Color.ForestGreen;
            this.add_button4.Location = new System.Drawing.Point(648, 583);
            this.add_button4.Name = "add_button4";
            this.add_button4.Size = new System.Drawing.Size(100, 43);
            this.add_button4.TabIndex = 5;
            this.add_button4.Text = "ADD";
            this.add_button4.UseVisualStyleBackColor = false;
            this.add_button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BillId
            // 
            this.BillId.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BillId.Location = new System.Drawing.Point(1200, 41);
            this.BillId.Name = "BillId";
            this.BillId.Size = new System.Drawing.Size(10, 32);
            this.BillId.TabIndex = 11;
            this.BillId.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "ProdName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1072, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "CategoryID";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(459, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "SELLING";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(12, 610);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Logout";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // selectcategory_comboBox2
            // 
            this.selectcategory_comboBox2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectcategory_comboBox2.ForeColor = System.Drawing.Color.ForestGreen;
            this.selectcategory_comboBox2.FormattingEnabled = true;
            this.selectcategory_comboBox2.Items.AddRange(new object[] {
            "Meet",
            "Vegetable"});
            this.selectcategory_comboBox2.Location = new System.Drawing.Point(29, 302);
            this.selectcategory_comboBox2.Name = "selectcategory_comboBox2";
            this.selectcategory_comboBox2.Size = new System.Drawing.Size(212, 29);
            this.selectcategory_comboBox2.TabIndex = 17;
            this.selectcategory_comboBox2.Text = "Select Category";
            this.selectcategory_comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.selectcategory_comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 671);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.selling_panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.selling_panel1.ResumeLayout(false);
            this.selling_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product2_dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bills_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel selling_panel1;
        private System.Windows.Forms.DataGridView Bills_dataGridView1;
        private System.Windows.Forms.Button print_button6;
        private System.Windows.Forms.Button add_button4;
        private System.Windows.Forms.TextBox BillId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Product2_dataGridView2;
        private System.Windows.Forms.TextBox ProdQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label SellerName;
        private System.Windows.Forms.Button Add_product_button1;
        private System.Windows.Forms.Label amount_label4;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Order_dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.TextBox ProdPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button refresh_button8;
        private System.Windows.Forms.ComboBox selectcategory_comboBox2;
    }
}
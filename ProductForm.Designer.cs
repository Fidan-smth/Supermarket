namespace Supermarket
{
    partial class ProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.product_panel1 = new System.Windows.Forms.Panel();
            this.selectcategory_comboBox2 = new System.Windows.Forms.ComboBox();
            this.product_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete_button7 = new System.Windows.Forms.Button();
            this.edit_button6 = new System.Windows.Forms.Button();
            this.Add_button4 = new System.Windows.Forms.Button();
            this.SelectCategory = new System.Windows.Forms.ComboBox();
            this.categorylabel6 = new System.Windows.Forms.Label();
            this.ProdID = new System.Windows.Forms.TextBox();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.ProdQuantity = new System.Windows.Forms.TextBox();
            this.price_label5 = new System.Windows.Forms.Label();
            this.quantity_label4 = new System.Windows.Forms.Label();
            this.name_label3 = new System.Windows.Forms.Label();
            this.id_label1 = new System.Windows.Forms.Label();
            this.products_label2 = new System.Windows.Forms.Label();
            this.sellers_button1 = new System.Windows.Forms.Button();
            this.category_button2 = new System.Windows.Forms.Button();
            this.exit_button5 = new System.Windows.Forms.Button();
            this.logout_label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.product_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // product_panel1
            // 
            this.product_panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.product_panel1.Controls.Add(this.selectcategory_comboBox2);
            this.product_panel1.Controls.Add(this.product_dataGridView1);
            this.product_panel1.Controls.Add(this.delete_button7);
            this.product_panel1.Controls.Add(this.edit_button6);
            this.product_panel1.Controls.Add(this.Add_button4);
            this.product_panel1.Controls.Add(this.SelectCategory);
            this.product_panel1.Controls.Add(this.categorylabel6);
            this.product_panel1.Controls.Add(this.ProdID);
            this.product_panel1.Controls.Add(this.ProdPrice);
            this.product_panel1.Controls.Add(this.ProdName);
            this.product_panel1.Controls.Add(this.ProdQuantity);
            this.product_panel1.Controls.Add(this.price_label5);
            this.product_panel1.Controls.Add(this.quantity_label4);
            this.product_panel1.Controls.Add(this.name_label3);
            this.product_panel1.Controls.Add(this.id_label1);
            this.product_panel1.Controls.Add(this.products_label2);
            this.product_panel1.Location = new System.Drawing.Point(204, 47);
            this.product_panel1.Name = "product_panel1";
            this.product_panel1.Size = new System.Drawing.Size(1062, 625);
            this.product_panel1.TabIndex = 0;
            // 
            // selectcategory_comboBox2
            // 
            this.selectcategory_comboBox2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectcategory_comboBox2.ForeColor = System.Drawing.Color.ForestGreen;
            this.selectcategory_comboBox2.FormattingEnabled = true;
            this.selectcategory_comboBox2.Items.AddRange(new object[] {
            "Admin",
            "Seller"});
            this.selectcategory_comboBox2.Location = new System.Drawing.Point(758, 77);
            this.selectcategory_comboBox2.Name = "selectcategory_comboBox2";
            this.selectcategory_comboBox2.Size = new System.Drawing.Size(212, 29);
            this.selectcategory_comboBox2.TabIndex = 17;
            this.selectcategory_comboBox2.Text = "Select Category";
            this.selectcategory_comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.selectcategory_comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // product_dataGridView1
            // 
            this.product_dataGridView1.AllowUserToOrderColumns = true;
            this.product_dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.product_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.product_dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.product_dataGridView1.Location = new System.Drawing.Point(407, 112);
            this.product_dataGridView1.Name = "product_dataGridView1";
            this.product_dataGridView1.RowHeadersVisible = false;
            this.product_dataGridView1.RowHeadersWidth = 51;
            this.product_dataGridView1.RowTemplate.Height = 24;
            this.product_dataGridView1.Size = new System.Drawing.Size(563, 462);
            this.product_dataGridView1.TabIndex = 16;
            this.product_dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // delete_button7
            // 
            this.delete_button7.BackColor = System.Drawing.Color.White;
            this.delete_button7.FlatAppearance.BorderSize = 0;
            this.delete_button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button7.ForeColor = System.Drawing.Color.ForestGreen;
            this.delete_button7.Location = new System.Drawing.Point(248, 398);
            this.delete_button7.Name = "delete_button7";
            this.delete_button7.Size = new System.Drawing.Size(126, 43);
            this.delete_button7.TabIndex = 15;
            this.delete_button7.Text = "DELETE";
            this.delete_button7.UseVisualStyleBackColor = false;
            this.delete_button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // edit_button6
            // 
            this.edit_button6.BackColor = System.Drawing.Color.White;
            this.edit_button6.FlatAppearance.BorderSize = 0;
            this.edit_button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button6.ForeColor = System.Drawing.Color.ForestGreen;
            this.edit_button6.Location = new System.Drawing.Point(129, 398);
            this.edit_button6.Name = "edit_button6";
            this.edit_button6.Size = new System.Drawing.Size(113, 43);
            this.edit_button6.TabIndex = 14;
            this.edit_button6.Text = "EDIT";
            this.edit_button6.UseVisualStyleBackColor = false;
            this.edit_button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Add_button4
            // 
            this.Add_button4.BackColor = System.Drawing.Color.White;
            this.Add_button4.FlatAppearance.BorderSize = 0;
            this.Add_button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_button4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_button4.ForeColor = System.Drawing.Color.ForestGreen;
            this.Add_button4.Location = new System.Drawing.Point(23, 398);
            this.Add_button4.Name = "Add_button4";
            this.Add_button4.Size = new System.Drawing.Size(100, 43);
            this.Add_button4.TabIndex = 5;
            this.Add_button4.Text = "ADD";
            this.Add_button4.UseVisualStyleBackColor = false;
            this.Add_button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SelectCategory
            // 
            this.SelectCategory.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCategory.ForeColor = System.Drawing.Color.ForestGreen;
            this.SelectCategory.FormattingEnabled = true;
            this.SelectCategory.Items.AddRange(new object[] {
            "Admin",
            "Seller"});
            this.SelectCategory.Location = new System.Drawing.Point(149, 338);
            this.SelectCategory.Name = "SelectCategory";
            this.SelectCategory.Size = new System.Drawing.Size(212, 29);
            this.SelectCategory.TabIndex = 13;
            this.SelectCategory.Text = "Select Category";
            this.SelectCategory.SelectedIndexChanged += new System.EventHandler(this.SelectCategory_SelectedIndexChanged);
            // 
            // categorylabel6
            // 
            this.categorylabel6.AutoSize = true;
            this.categorylabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorylabel6.ForeColor = System.Drawing.Color.White;
            this.categorylabel6.Location = new System.Drawing.Point(25, 339);
            this.categorylabel6.Name = "categorylabel6";
            this.categorylabel6.Size = new System.Drawing.Size(117, 23);
            this.categorylabel6.TabIndex = 12;
            this.categorylabel6.Text = "CATEGORY";
            // 
            // ProdID
            // 
            this.ProdID.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ProdID.Location = new System.Drawing.Point(149, 119);
            this.ProdID.Name = "ProdID";
            this.ProdID.Size = new System.Drawing.Size(212, 32);
            this.ProdID.TabIndex = 11;
            // 
            // ProdPrice
            // 
            this.ProdPrice.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ProdPrice.Location = new System.Drawing.Point(149, 273);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(212, 32);
            this.ProdPrice.TabIndex = 10;
            // 
            // ProdName
            // 
            this.ProdName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ProdName.Location = new System.Drawing.Point(149, 174);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(212, 32);
            this.ProdName.TabIndex = 9;
            // 
            // ProdQuantity
            // 
            this.ProdQuantity.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ProdQuantity.Location = new System.Drawing.Point(149, 224);
            this.ProdQuantity.Name = "ProdQuantity";
            this.ProdQuantity.Size = new System.Drawing.Size(212, 32);
            this.ProdQuantity.TabIndex = 6;
            this.ProdQuantity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // price_label5
            // 
            this.price_label5.AutoSize = true;
            this.price_label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label5.ForeColor = System.Drawing.Color.White;
            this.price_label5.Location = new System.Drawing.Point(25, 270);
            this.price_label5.Name = "price_label5";
            this.price_label5.Size = new System.Drawing.Size(65, 23);
            this.price_label5.TabIndex = 5;
            this.price_label5.Text = "PRICE";
            // 
            // quantity_label4
            // 
            this.quantity_label4.AutoSize = true;
            this.quantity_label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_label4.ForeColor = System.Drawing.Color.White;
            this.quantity_label4.Location = new System.Drawing.Point(25, 221);
            this.quantity_label4.Name = "quantity_label4";
            this.quantity_label4.Size = new System.Drawing.Size(104, 23);
            this.quantity_label4.TabIndex = 4;
            this.quantity_label4.Text = "QUANTITY";
            // 
            // name_label3
            // 
            this.name_label3.AutoSize = true;
            this.name_label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label3.ForeColor = System.Drawing.Color.White;
            this.name_label3.Location = new System.Drawing.Point(25, 174);
            this.name_label3.Name = "name_label3";
            this.name_label3.Size = new System.Drawing.Size(68, 23);
            this.name_label3.TabIndex = 3;
            this.name_label3.Text = "NAME";
            // 
            // id_label1
            // 
            this.id_label1.AutoSize = true;
            this.id_label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label1.ForeColor = System.Drawing.Color.White;
            this.id_label1.Location = new System.Drawing.Point(25, 118);
            this.id_label1.Name = "id_label1";
            this.id_label1.Size = new System.Drawing.Size(30, 23);
            this.id_label1.TabIndex = 2;
            this.id_label1.Text = "ID";
            // 
            // products_label2
            // 
            this.products_label2.AutoSize = true;
            this.products_label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_label2.ForeColor = System.Drawing.Color.White;
            this.products_label2.Location = new System.Drawing.Point(371, 20);
            this.products_label2.Name = "products_label2";
            this.products_label2.Size = new System.Drawing.Size(253, 34);
            this.products_label2.TabIndex = 1;
            this.products_label2.Text = "Manage Products";
            this.products_label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sellers_button1
            // 
            this.sellers_button1.FlatAppearance.BorderSize = 0;
            this.sellers_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellers_button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellers_button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.sellers_button1.Location = new System.Drawing.Point(29, 231);
            this.sellers_button1.Name = "sellers_button1";
            this.sellers_button1.Size = new System.Drawing.Size(147, 43);
            this.sellers_button1.TabIndex = 0;
            this.sellers_button1.Text = "Sellers";
            this.sellers_button1.UseVisualStyleBackColor = true;
            this.sellers_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // category_button2
            // 
            this.category_button2.FlatAppearance.BorderSize = 0;
            this.category_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_button2.ForeColor = System.Drawing.Color.ForestGreen;
            this.category_button2.Location = new System.Drawing.Point(1, 280);
            this.category_button2.Name = "category_button2";
            this.category_button2.Size = new System.Drawing.Size(197, 43);
            this.category_button2.TabIndex = 1;
            this.category_button2.Text = "Categories";
            this.category_button2.UseVisualStyleBackColor = true;
            this.category_button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // exit_button5
            // 
            this.exit_button5.FlatAppearance.BorderSize = 0;
            this.exit_button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button5.ForeColor = System.Drawing.Color.ForestGreen;
            this.exit_button5.Location = new System.Drawing.Point(1123, 6);
            this.exit_button5.Name = "exit_button5";
            this.exit_button5.Size = new System.Drawing.Size(77, 35);
            this.exit_button5.TabIndex = 4;
            this.exit_button5.Text = "X";
            this.exit_button5.UseVisualStyleBackColor = true;
            this.exit_button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // logout_label7
            // 
            this.logout_label7.AutoSize = true;
            this.logout_label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.logout_label7.Location = new System.Drawing.Point(25, 616);
            this.logout_label7.Name = "logout_label7";
            this.logout_label7.Size = new System.Drawing.Size(76, 23);
            this.logout_label7.TabIndex = 33;
            this.logout_label7.Text = "Logout";
            this.logout_label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 671);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logout_label7);
            this.Controls.Add(this.exit_button5);
            this.Controls.Add(this.category_button2);
            this.Controls.Add(this.sellers_button1);
            this.Controls.Add(this.product_panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.product_panel1.ResumeLayout(false);
            this.product_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel product_panel1;
        private System.Windows.Forms.Button sellers_button1;
        private System.Windows.Forms.Button category_button2;
        private System.Windows.Forms.Button exit_button5;
        private System.Windows.Forms.Label price_label5;
        private System.Windows.Forms.Label quantity_label4;
        private System.Windows.Forms.Label name_label3;
        private System.Windows.Forms.Label id_label1;
        private System.Windows.Forms.Label products_label2;
        private System.Windows.Forms.TextBox ProdID;
        private System.Windows.Forms.TextBox ProdPrice;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.TextBox ProdQuantity;
        private System.Windows.Forms.Label categorylabel6;
        private System.Windows.Forms.ComboBox SelectCategory;
        private System.Windows.Forms.Button delete_button7;
        private System.Windows.Forms.Button edit_button6;
        private System.Windows.Forms.Button Add_button4;
        private System.Windows.Forms.ComboBox selectcategory_comboBox2;
        private System.Windows.Forms.DataGridView product_dataGridView1;
        private System.Windows.Forms.Label logout_label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
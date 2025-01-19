namespace Supermarket
{
    partial class CategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.categorylabel2 = new System.Windows.Forms.Label();
            this.IDlabel1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.CategoryDescription = new System.Windows.Forms.TextBox();
            this.CategoryName = new System.Windows.Forms.TextBox();
            this.CategoryID = new System.Windows.Forms.TextBox();
            this.add_button4 = new System.Windows.Forms.Button();
            this.edit_button6 = new System.Windows.Forms.Button();
            this.delete_button7 = new System.Windows.Forms.Button();
            this.Category_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.category_panel1 = new System.Windows.Forms.Panel();
            this.productsbutton2 = new System.Windows.Forms.Button();
            this.seller_button1 = new System.Windows.Forms.Button();
            this.exit_button8 = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Category_dataGridView1)).BeginInit();
            this.category_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // categorylabel2
            // 
            this.categorylabel2.AutoSize = true;
            this.categorylabel2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorylabel2.ForeColor = System.Drawing.Color.White;
            this.categorylabel2.Location = new System.Drawing.Point(379, 20);
            this.categorylabel2.Name = "categorylabel2";
            this.categorylabel2.Size = new System.Drawing.Size(285, 34);
            this.categorylabel2.TabIndex = 1;
            this.categorylabel2.Text = "Manage Categories";
            // 
            // IDlabel1
            // 
            this.IDlabel1.AutoSize = true;
            this.IDlabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel1.ForeColor = System.Drawing.Color.White;
            this.IDlabel1.Location = new System.Drawing.Point(25, 118);
            this.IDlabel1.Name = "IDlabel1";
            this.IDlabel1.Size = new System.Drawing.Size(30, 23);
            this.IDlabel1.TabIndex = 2;
            this.IDlabel1.Text = "ID";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(25, 174);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(68, 23);
            this.name.TabIndex = 3;
            this.name.Text = "NAME";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.White;
            this.description.Location = new System.Drawing.Point(25, 221);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(135, 23);
            this.description.TabIndex = 4;
            this.description.Text = "DESCRIPTION";
            // 
            // CategoryDescription
            // 
            this.CategoryDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryDescription.Location = new System.Drawing.Point(166, 221);
            this.CategoryDescription.Name = "CategoryDescription";
            this.CategoryDescription.Size = new System.Drawing.Size(212, 32);
            this.CategoryDescription.TabIndex = 6;
            // 
            // CategoryName
            // 
            this.CategoryName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryName.Location = new System.Drawing.Point(166, 174);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(212, 32);
            this.CategoryName.TabIndex = 9;
            // 
            // CategoryID
            // 
            this.CategoryID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryID.Location = new System.Drawing.Point(166, 118);
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.Size = new System.Drawing.Size(212, 32);
            this.CategoryID.TabIndex = 11;
            this.CategoryID.TextChanged += new System.EventHandler(this.CategoryID_TextChanged);
            // 
            // add_button4
            // 
            this.add_button4.BackColor = System.Drawing.Color.White;
            this.add_button4.FlatAppearance.BorderSize = 0;
            this.add_button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button4.ForeColor = System.Drawing.Color.ForestGreen;
            this.add_button4.Location = new System.Drawing.Point(30, 284);
            this.add_button4.Name = "add_button4";
            this.add_button4.Size = new System.Drawing.Size(100, 43);
            this.add_button4.TabIndex = 5;
            this.add_button4.Text = "ADD";
            this.add_button4.UseVisualStyleBackColor = false;
            this.add_button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // edit_button6
            // 
            this.edit_button6.BackColor = System.Drawing.Color.White;
            this.edit_button6.FlatAppearance.BorderSize = 0;
            this.edit_button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button6.ForeColor = System.Drawing.Color.ForestGreen;
            this.edit_button6.Location = new System.Drawing.Point(149, 284);
            this.edit_button6.Name = "edit_button6";
            this.edit_button6.Size = new System.Drawing.Size(100, 43);
            this.edit_button6.TabIndex = 14;
            this.edit_button6.Text = "EDIT";
            this.edit_button6.UseVisualStyleBackColor = false;
            this.edit_button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // delete_button7
            // 
            this.delete_button7.BackColor = System.Drawing.Color.White;
            this.delete_button7.FlatAppearance.BorderSize = 0;
            this.delete_button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button7.ForeColor = System.Drawing.Color.ForestGreen;
            this.delete_button7.Location = new System.Drawing.Point(268, 284);
            this.delete_button7.Name = "delete_button7";
            this.delete_button7.Size = new System.Drawing.Size(110, 43);
            this.delete_button7.TabIndex = 15;
            this.delete_button7.Text = "DELETE";
            this.delete_button7.UseVisualStyleBackColor = false;
            this.delete_button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Category_dataGridView1
            // 
            this.Category_dataGridView1.AllowUserToOrderColumns = true;
            this.Category_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Category_dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Category_dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Category_dataGridView1.ColumnHeadersHeight = 25;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Category_dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Category_dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.Category_dataGridView1.Location = new System.Drawing.Point(407, 112);
            this.Category_dataGridView1.Name = "Category_dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Category_dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Category_dataGridView1.RowHeadersVisible = false;
            this.Category_dataGridView1.RowHeadersWidth = 51;
            this.Category_dataGridView1.RowTemplate.Height = 24;
            this.Category_dataGridView1.Size = new System.Drawing.Size(563, 462);
            this.Category_dataGridView1.TabIndex = 16;
            this.Category_dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Category_dataGridView1_CellContentClick);
            // 
            // category_panel1
            // 
            this.category_panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.category_panel1.Controls.Add(this.Category_dataGridView1);
            this.category_panel1.Controls.Add(this.delete_button7);
            this.category_panel1.Controls.Add(this.edit_button6);
            this.category_panel1.Controls.Add(this.add_button4);
            this.category_panel1.Controls.Add(this.CategoryID);
            this.category_panel1.Controls.Add(this.CategoryName);
            this.category_panel1.Controls.Add(this.CategoryDescription);
            this.category_panel1.Controls.Add(this.description);
            this.category_panel1.Controls.Add(this.name);
            this.category_panel1.Controls.Add(this.IDlabel1);
            this.category_panel1.Controls.Add(this.categorylabel2);
            this.category_panel1.Location = new System.Drawing.Point(204, 47);
            this.category_panel1.Name = "category_panel1";
            this.category_panel1.Size = new System.Drawing.Size(996, 625);
            this.category_panel1.TabIndex = 2;
            // 
            // productsbutton2
            // 
            this.productsbutton2.FlatAppearance.BorderSize = 0;
            this.productsbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsbutton2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsbutton2.ForeColor = System.Drawing.Color.ForestGreen;
            this.productsbutton2.Location = new System.Drawing.Point(1, 280);
            this.productsbutton2.Name = "productsbutton2";
            this.productsbutton2.Size = new System.Drawing.Size(197, 43);
            this.productsbutton2.TabIndex = 18;
            this.productsbutton2.Text = "Products";
            this.productsbutton2.UseVisualStyleBackColor = true;
            this.productsbutton2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // seller_button1
            // 
            this.seller_button1.FlatAppearance.BorderSize = 0;
            this.seller_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seller_button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seller_button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.seller_button1.Location = new System.Drawing.Point(29, 231);
            this.seller_button1.Name = "seller_button1";
            this.seller_button1.Size = new System.Drawing.Size(148, 43);
            this.seller_button1.TabIndex = 17;
            this.seller_button1.Text = "Sellers";
            this.seller_button1.UseVisualStyleBackColor = true;
            this.seller_button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // exit_button8
            // 
            this.exit_button8.FlatAppearance.BorderSize = 0;
            this.exit_button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button8.ForeColor = System.Drawing.Color.ForestGreen;
            this.exit_button8.Location = new System.Drawing.Point(1123, 6);
            this.exit_button8.Name = "exit_button8";
            this.exit_button8.Size = new System.Drawing.Size(77, 35);
            this.exit_button8.TabIndex = 20;
            this.exit_button8.Text = "X";
            this.exit_button8.UseVisualStyleBackColor = true;
            this.exit_button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.ForestGreen;
            this.logout.Location = new System.Drawing.Point(25, 616);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(76, 23);
            this.logout.TabIndex = 34;
            this.logout.Text = "Logout";
            this.logout.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 671);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.exit_button8);
            this.Controls.Add(this.category_panel1);
            this.Controls.Add(this.productsbutton2);
            this.Controls.Add(this.seller_button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Category_dataGridView1)).EndInit();
            this.category_panel1.ResumeLayout(false);
            this.category_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categorylabel2;
        private System.Windows.Forms.Label IDlabel1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TextBox CategoryDescription;
        private System.Windows.Forms.TextBox CategoryName;
        private System.Windows.Forms.TextBox CategoryID;
        private System.Windows.Forms.Button add_button4;
        private System.Windows.Forms.Button edit_button6;
        private System.Windows.Forms.Button delete_button7;
        private System.Windows.Forms.DataGridView Category_dataGridView1;
        private System.Windows.Forms.Panel category_panel1;
        private System.Windows.Forms.Button productsbutton2;
        private System.Windows.Forms.Button seller_button1;
        private System.Windows.Forms.Button exit_button8;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
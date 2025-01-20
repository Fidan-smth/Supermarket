using SuperMarket_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Supermarket
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=Supermarket;Integrated Security=True");

        private void populate() // populates the products data grid from db
        {
            Con.Open();
            string query = "select ProductName,ProductPrice, ProductQuantity from ProductTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            Product2_dataGridView2.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populatebills() // populates the bill data grid from db
        {
            Con.Open();
            string query = "select * from BillTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            Bills_dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void fillcombo() // fills combo box with the categories from db
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CategoryName from CategoryTable", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryName", typeof(string));
            dt.Load(rdr);
            selectcategory_comboBox2.ValueMember = "CategoryName";
            selectcategory_comboBox2.DataSource = dt;
            Con.Close();
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
            fillcombo();
            SellerName.Text = LoginForm.SellerName;
        }

        private void Product2_dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdName.Text = Product2_dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Date.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            if (
               string.IsNullOrWhiteSpace(SellerName.Text) || string.IsNullOrWhiteSpace(Date.Text) || string.IsNullOrWhiteSpace(Amount.Text))
            {
                MessageBox.Show("Missing information. Please fill in all fields.");
            }
            else
            {
                try
                {
                   
                    using (SqlConnection Con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=Supermarket;Integrated Security=True")
)
                    {
                        Con.Open();
                        string query = "INSERT INTO BillTable (SellerName, Date, Amount) VALUES (@SellerName, @Date, @Amount)";
                        using (SqlCommand cmd = new SqlCommand(query, Con))
                        {
                            cmd.Parameters.AddWithValue("@SellerName", SellerName.Text);
                            cmd.Parameters.AddWithValue("@Date", Date.Text); 
                            cmd.Parameters.AddWithValue("@Amount", decimal.Parse(Amount.Text)); 

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Order added successfully!");
                        }
                    }

                    populatebills();

                    BillId.Text = string.Empty;
                    SellerName.Text = string.Empty;
                    Date.Text = string.Empty;
                    Amount.Text = string.Empty;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid input format. Please enter valid values for each field.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }


        private void Bills_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int yPos = 100;  
            int rowHeight = 30;  
            int pageWidth = e.PageBounds.Width;  
            int leftMargin = 50;
            e.Graphics.DrawString("SuperMarket Receipt", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(pageWidth / 2 - 120, yPos));
            yPos += 40;  

            foreach (DataGridViewRow row in Bills_dataGridView1.Rows)
            {
                if (row.IsNewRow) continue; 

                e.Graphics.DrawString("Bill ID: " + row.Cells[0].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(leftMargin, yPos));
                e.Graphics.DrawString("Seller Name: " + row.Cells[1].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(leftMargin, yPos + 30));
                e.Graphics.DrawString("Date: " + row.Cells[2].Value.ToString(),new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(leftMargin, yPos + 60));
                e.Graphics.DrawString("Total Amount: " + row.Cells[3].Value.ToString(),new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(leftMargin, yPos + 90));

                yPos += rowHeight + 120;  

                if (yPos > e.PageSettings.PrintableArea.Height - 100)
                {
                    e.HasMorePages = true;
                    return;  
                }
            }

            e.HasMorePages = false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
           
            printPreviewDialog1.Document = printDocument1;  
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e) // it handles category selection and updates products according to category
        {
           
            Con.Open();
            string query = "SELECT ProductName, ProductPrice, ProductQuantity FROM ProductTable WHERE ProductCategory = @Category";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            sda.SelectCommand.Parameters.AddWithValue("@Category", selectcategory_comboBox2.SelectedValue.ToString());
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Product2_dataGridView2.DataSource = ds.Tables[0];
            Con.Close();
        }
        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "select ProductName, ProductPrice, ProductQuantity from ProductTable";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                Product2_dataGridView2.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        int total2 = 0, n = 0;

        private void Date_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ProdName.Text == "" || ProdQuantity.Text == "")
            {
                MessageBox.Show("Missing data");
            }
            else
            {
                string price = "0"; 
                try
                {
                    using (SqlConnection Con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=Supermarket;Integrated Security=True"))
                    {
                        Con.Open();
                        string query = "SELECT ProductPrice, ProductQuantity FROM ProductTable WHERE ProductName = @ProductName";
                        using (SqlCommand cmd = new SqlCommand(query, Con))
                        {
                            cmd.Parameters.AddWithValue("@ProductName", ProdName.Text);
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                price = reader["ProductPrice"].ToString();
                                int currentQuantity = Convert.ToInt32(reader["ProductQuantity"]);
                                int quantitySold = Convert.ToInt32(ProdQuantity.Text);

                                if (currentQuantity < quantitySold)
                                {
                                    MessageBox.Show("Not enough stock for this product.");
                                    return;
                                }

                                int newQuantity = currentQuantity - quantitySold;
                                reader.Close(); 

                                string updateQuery = "UPDATE ProductTable SET ProductQuantity = @NewQuantity WHERE ProductName = @ProductName";
                                using (SqlCommand updateCmd = new SqlCommand(updateQuery, Con))
                                {
                                    updateCmd.Parameters.AddWithValue("@NewQuantity", newQuantity);
                                    updateCmd.Parameters.AddWithValue("@ProductName", ProdName.Text);
                                    updateCmd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Product not found.");
                                return;
                            }
                        }
                    }
                    // add product to order list
                    int total = Convert.ToInt32(price) * Convert.ToInt32(ProdQuantity.Text);
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(Order_dataGridView1);
                    newRow.Cells[0].Value = n + 1;
                    newRow.Cells[1].Value = ProdName.Text;
                    newRow.Cells[2].Value = price;
                    newRow.Cells[3].Value = ProdQuantity.Text;
                    newRow.Cells[4].Value = Convert.ToInt32(price) * Convert.ToInt32(ProdQuantity.Text);
                    Order_dataGridView1.Rows.Add(newRow);
                    n++;
                    total2 = total2 + total;
                    Amount.Text = "" + total2;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
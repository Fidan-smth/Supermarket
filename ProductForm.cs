using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SuperMarket_Management;
namespace Supermarket
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=Supermarket;Integrated Security=True");


        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            ProdID.Text = product_dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            ProdName.Text = product_dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            ProdQuantity.Text = product_dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            ProdPrice.Text = product_dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string selectedCategory = product_dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            SelectCategory.SelectedValue = selectedCategory;
        }

        private void SelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void fillcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CategoryName from CategoryTable",Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryName", typeof(string));
            dt.Load(rdr);
            SelectCategory.ValueMember = "CategoryName";
            SelectCategory.DataSource = dt;
            selectcategory_comboBox2.ValueMember = "CategoryName";
            selectcategory_comboBox2.DataSource = dt;
            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from ProductTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            product_dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            fillcombo();
            populate(); 
        }

        private void button4_Click(object sender, EventArgs e) // handles 'add' button click
        {

            try
            {
                if (string.IsNullOrWhiteSpace(ProdName.Text) || string.IsNullOrWhiteSpace(ProdPrice.Text) ||string.IsNullOrWhiteSpace(ProdQuantity.Text))
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "INSERT INTO ProductTable (ProductName, ProductCategory, ProductPrice, ProductQuantity) " +
                                   "VALUES (@ProdName, @ProdCategory, @ProdPrice, @ProdQuantity)";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@ProdName", ProdName.Text);
                    cmd.Parameters.AddWithValue("@ProdCategory", SelectCategory.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@ProdPrice", int.Parse(ProdPrice.Text));
                    cmd.Parameters.AddWithValue("@ProdQuantity", int.Parse(ProdQuantity.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product added successfully!");

                    Con.Close();

                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button7_Click(object sender, EventArgs e) // handles 'delete' button click
        {
            try
            {
                if (ProdID.Text == "")
                {
                    MessageBox.Show("Select the product to delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from ProductTable where ProductID=" + ProdID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deleted succesfully!");
                    Con.Close();
                    populate();
                    ProdID.Text = "";
                    ProdName.Text = "";
                    ProdPrice.Text = "";
                    ProdQuantity.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellerForm sel = new SellerForm();
            sel.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e) // handles 'edit' button clcik
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ProdID.Text) ||string.IsNullOrWhiteSpace(ProdName.Text) ||string.IsNullOrWhiteSpace(ProdPrice.Text) ||string.IsNullOrWhiteSpace(ProdQuantity.Text))
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "UPDATE ProductTable " + "SET ProductName = @ProductName, " + "ProductQuantity = @ProductQuantity, " +
                                   "ProductPrice = @ProductPrice, " + "ProductCategory = @ProductCategory " +   "WHERE ProductID = @ProductID";

                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.Parameters.AddWithValue("@ProductID", int.Parse(ProdID.Text));
                    cmd.Parameters.AddWithValue("@ProductName", ProdName.Text);
                    cmd.Parameters.AddWithValue("@ProductQuantity", int.Parse(ProdQuantity.Text));
                    cmd.Parameters.AddWithValue("@ProductPrice", int.Parse(ProdPrice.Text));
                    cmd.Parameters.AddWithValue("@ProductCategory", SelectCategory.SelectedValue.ToString());  

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product successfully updated!");

                    Con.Close();

                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string selectedCategory = selectcategory_comboBox2.SelectedValue.ToString();
            string query = "select * from ProductTable where ProductCategory = @ProductCategory";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@ProductCategory", selectedCategory);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            product_dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
        
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}

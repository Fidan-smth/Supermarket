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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=Supermarket;Integrated Security=True");

        private void CategoryID_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(CategoryName.Text) ||string.IsNullOrWhiteSpace(CategoryDescription.Text))
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();

                    string query = "INSERT INTO CategoryTable (CategoryName, CategoryDescription) " +
                                   "VALUES (@CategoryName, @CategoryDescription)";

                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.Parameters.AddWithValue("@CategoryName", CategoryName.Text);
                    cmd.Parameters.AddWithValue("@CategoryDescription", CategoryDescription.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Category added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add category.");
                    }

                    Con.Close();
                    populate(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void populate()
        {
            Con.Open();
            string query = "select * from CategoryTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            Category_dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Category_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            CategoryID.Text = Category_dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            CategoryName.Text = Category_dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            CategoryDescription.Text = Category_dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategoryID.Text == "")
                {
                    MessageBox.Show("Select the category to delete");
                }else
                {
                    Con.Open();
                    string query = "delete from CategoryTable where CategoryID=" + CategoryID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category deleted succesfully!");                   
                    Con.Close();
                    populate();
                }
            }catch( Exception ex ) 
            {
                MessageBox.Show(ex.Message );
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CategoryID.Text) ||string.IsNullOrWhiteSpace(CategoryDescription.Text) ||string.IsNullOrWhiteSpace(CategoryName.Text))
                {
                    MessageBox.Show("Missing information");
                }
                else if (!int.TryParse(CategoryID.Text, out int categoryId))
                {
                    MessageBox.Show("Invalid Category ID. Please enter a valid number.");
                }
                else
                {
                    Con.Open();
                    string query = "UPDATE CategoryTable SET CategoryName = @CategoryName, CategoryDescription = @CategoryDescription WHERE CategoryID = @CategoryID";

                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                    cmd.Parameters.AddWithValue("@CategoryName", CategoryName.Text);
                    cmd.Parameters.AddWithValue("@CategoryDescription", CategoryDescription.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Category successfully updated!");
                    }
                    else
                    {
                        MessageBox.Show("No category found with the provided ID.");
                    }

                    Con.Close();
                    populate();  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
           prod.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm sel = new SellerForm();
            sel.Show();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SellerForm sel = new SellerForm();
            sel.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            SellerForm sel = new SellerForm();
            sel.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ProductForm prod = new ProductForm();
            prod.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

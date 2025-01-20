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
using SuperMarket_Management;
namespace Supermarket
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=Supermarket;Integrated Security=True");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SellerID.Text = Seller_dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            SellerName.Text = Seller_dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            SellerAge.Text = Seller_dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            SellerPhone.Text = Seller_dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            SellerPassword.Text = Seller_dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM SellerTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Seller_dataGridView1.DataSource = ds.Tables[0];
            Con.Close();

        }


        private void button7_Click(object sender, EventArgs e)// handles 'delete' button click
        {
            try
            {
                if (SellerID.Text == "")
                {
                    MessageBox.Show("Select Seller to delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from SellerTable where SellerID=" + SellerID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller deleted succesfully!");
                    Con.Close();
                    populate();
                    SellerID.Text = "";
                    SellerName.Text = "";
                    SellerPassword.Text = "";
                    SellerPhone.Text = "";
                    SellerAge.Text = "";
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e) //handles 'add' button click
        {
            try
            {
                if (string.IsNullOrWhiteSpace(SellerName.Text) ||string.IsNullOrWhiteSpace(SellerAge.Text) ||
                    string.IsNullOrWhiteSpace(SellerPhone.Text) || string.IsNullOrWhiteSpace(SellerPassword.Text))
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "INSERT INTO SellerTable (SellerName, SellerAge, SellerPhone, SellerPassword) " +
                                   "VALUES (@SellerName, @SellerAge, @SellerPhone, @SellerPassword)";

                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.Parameters.AddWithValue("@SellerName", SellerName.Text);
                    cmd.Parameters.AddWithValue("@SellerAge", int.Parse(SellerAge.Text));
                    cmd.Parameters.AddWithValue("@SellerPhone", SellerPhone.Text);
                    cmd.Parameters.AddWithValue("@SellerPassword", SellerPassword.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Seller added successfully!");

                    Con.Close();
                    populate();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please enter valid values.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)//handles 'edit' button click
        {
            try
            {
                if (string.IsNullOrWhiteSpace(SellerID.Text) ||string.IsNullOrWhiteSpace(SellerName.Text) ||
                    string.IsNullOrWhiteSpace(SellerAge.Text) || string.IsNullOrWhiteSpace(SellerPassword.Text) 
                    ||string.IsNullOrWhiteSpace(SellerPhone.Text))
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();

                    string query = "UPDATE SellerTable " +"SET SellerName = @SellerName, " +"SellerAge = @SellerAge, " 
                                   +"SellerPassword = @SellerPassword, " + "SellerPhone = @SellerPhone " +"WHERE SellerID = @SellerID";

                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.Parameters.AddWithValue("@SellerID", int.Parse(SellerID.Text));
                    cmd.Parameters.AddWithValue("@SellerName", SellerName.Text);
                    cmd.Parameters.AddWithValue("@SellerAge", int.Parse(SellerAge.Text));
                    cmd.Parameters.AddWithValue("@SellerPassword", SellerPassword.Text);
                    cmd.Parameters.AddWithValue("@SellerPhone", SellerPhone.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Seller successfully updated!");

                    Con.Close();
                    populate();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();
        }

    }
}

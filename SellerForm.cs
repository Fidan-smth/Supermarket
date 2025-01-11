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
using System.Data.SqlClient;
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
            SellerID.Text = Seller_dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            SellerName.Text = Seller_dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            SellerAge.Text = Seller_dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            SellerPhone.Text = Seller_dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            SellerPassword.Text = Seller_dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
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
                    // populate();
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
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into SellerTable values(" + SellerID.Text + ", '" + SellerName.Text + "'," + SellerAge.Text + "," + SellerPhone.Text + " ,'" + SellerPassword.Text+ "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller added succesfully!");
                Con.Close();
                //populate();
                SellerID.Text = "";
                SellerName.Text = "";
                SellerPassword.Text = "";
                SellerPhone.Text = "";
                SellerAge.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellerID.Text == "" || SellerName.Text == "" || SellerAge.Text == "" || SellerPassword.Text == ""|| SellerPhone.Text=="")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "UPDATE SellerTable " +
                "SET SellerName = '" + SellerName.Text + "', " +
                "SellerAge = '" + SellerAge.Text + "', " +
                "SellerPassword = '" + SellerPassword.Text + "', " +
                "SellerPhone = '" + SellerPhone.Text + "' " +
                "WHERE SellerID = '" + SellerID.Text + "';";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller succesfully updated!");
                    Con.Close();
                    //populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }
        /* private void populate()
{
// Open the database connection
Con.Open();

// Query to select all records from the SellerTable
string query = "SELECT * FROM SellerTable";

// Create a SqlDataAdapter to fetch the data
SqlDataAdapter adapter = new SqlDataAdapter(query, Con);

// Create a SqlCommandBuilder for automatically generating SQL commands
SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

// Fill the data into a DataSet
var ds = new DataSet();
adapter.Fill(ds);

// Bind the data to the DataGridView
Seller_dataGridView1.DataSource = ds.Tables[0];

// Close the database connection
Con.Close();
}
private void Form_Load(object sender, EventArgs e)
{
populate();
}
*/



    }
}

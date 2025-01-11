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
                Con.Open();
                string query = "insert into CategoryTable values(" + CategoryID.Text + ", '" + CategoryName.Text + "','" + CategoryDescription.Text + "' )";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category added succesfully!");
                Con.Close();
                populate();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            CategoryID.Text = Category_dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            CategoryName.Text = Category_dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            CategoryDescription.Text = Category_dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
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
                    string query = "delete from Categorytable where CatagoryID=" + CategoryID.Text + "";
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
                if (CategoryID.Text == "" || CategoryDescription.Text==""|| CategoryName.Text=="")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "update Categorytable set CategoryName='" +CategoryName.Text+"', CategoryDescription='"+CategoryDescription.Text+"' where CatID ="+CategoryID.Text+";";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category succesfully updated!");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            Form1 login = new Form1();
            login.Show();
        }
    }
}

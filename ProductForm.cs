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
            ProdID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ProdName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            ProdQuantity.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            SelectCategory.SelectedValue = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
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
            comboBox2.ValueMember = "CategoryName";
            comboBox2.DataSource = dt;
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
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            fillcombo();
            populate(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();
                string query = "insert into ProductTable values(" + ProdID.Text + ", '" + ProdPrice.Text + "'," + ProdName.Text + ","+ProdQuantity.Text+" ,'"+SelectCategory.SelectedValue.ToString()+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added succesfully!");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
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
                    string query = "delete from ProductTable where ProdID=" + ProdID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deleted succesfully!");
                    Con.Close();
                    populate();
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdID.Text == "" || ProdName.Text == "" || ProdPrice.Text == ""|| ProdQuantity.Text== "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "UPDATE ProductTable " +"SET ProdName = '" + ProdName.Text + "', " +"ProdID = '" + ProdID.Text + "', " + "ProdQuantity = '" + ProdQuantity.Text + "', " +
               "ProdPrice = '" + ProdPrice.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product succesfully updated!");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select * from ProductTable where ProductCategory= " + comboBox2.SelectedValue.ToString();
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
        
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}

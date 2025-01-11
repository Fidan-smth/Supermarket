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

        private void populate()
        {
            Con.Open();
            string query = "select ProductName, ProductQuantity from ProductTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            Product2_dataGridView2.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populatebills()
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
       
        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
            fillcombo();
            SellerName.Text = Form1.SellerName;
        }

        private void Product2_dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdName.Text = Product2_dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            ProdPrice.Text = Product2_dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Date.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        int total2 = 0, n=0;

        private void button4_Click(object sender, EventArgs e)
        {
            if (BillId.Text == "")
            {
                MessageBox.Show("Missing bill id");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BillTable values(" + BillId.Text + ", '" + SellerName.Text + "'," + Date.Text + "," + Amount.Text + " )";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order added succesfully!");
                    Con.Close();
                    populatebills();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
          

        private void Bills_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("SuperMarket", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill ID:" + Bills_dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 70));
            e.Graphics.DrawString("Seller Name:" + Bills_dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("Date:" + Bills_dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount:" + Bills_dataGridView1.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK) {
                printDocument1.Print();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select ProductName, ProductQuantity from ProductTable" + comboBox2.SelectedValue;
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Product2_dataGridView2.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void fillcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CategoryName from CategoryTable", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryName", typeof(string));
            dt.Load(rdr);
            //SelectCategory.ValueMember = "CategoryName";
            //SelectCategory.DataSource = dt;
            comboBox2.ValueMember = "CategoryName";
            comboBox2.DataSource = dt;
            Con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ProdName.Text =="" || ProdQuantity.Text== "")
            {
                MessageBox.Show("Missing data");
            }
            else
            {
                int  total = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQuantity.Text);
                DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(Order_dataGridView1);
            newRow.Cells[0].Value = n+ 1;
            newRow.Cells[1].Value = ProdName.Text;
            newRow.Cells[2].Value = ProdPrice.Text;
            newRow.Cells[3].Value = ProdQuantity.Text;
            newRow.Cells[4].Value = Convert.ToInt32(ProdPrice.Text)* Convert.ToInt32(ProdQuantity.Text);
            Order_dataGridView1.Rows.Add(newRow);
                n++;
            total2 = total2 + total;
            Amount.Text = "" + total2;
            }
        }
    }
    }


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

namespace SuperMarket_Management
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static string SellerName = "";
        SqlConnection Con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=SuperMarket_;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Enter username and password");
            }
            else
            {
                if (SelectRole.SelectedIndex > -1)
                {
                    if (SelectRole.SelectedItem.ToString() == "Admin")
                    {
                        if (Username.Text == "Admin" && Password.Text == "Admin")
                        {
                            Form2 prod = new Form2();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are the admin, enter the correct Id and password");
                        }
                    }
                    else
                    {
                        Con.Open(); // Open the connection
                        string query = "SELECT COUNT(*) FROM SellerTable WHERE SellerName = @SellerName AND SellerPassword = @SellerPassword";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.Parameters.AddWithValue("@SellerName", Username.Text);
                        cmd.Parameters.AddWithValue("@SellerPassword", Password.Text);

                        // Execute the query and get the count
                        int result = (int)cmd.ExecuteScalar();

                        if (result == 1)
                        {
                            SellerName = Username.Text; // Store the seller's name globally
                            SellingForm selling = new SellingForm();
                            selling.Show();
                            this.Hide(); // Hide the current form
                        }
                        else
                        {
                            MessageBox.Show("Wrong username or password");
                        }

                        Con.Close(); // Close the connection
                    }


                }
                else
                {
                    MessageBox.Show("Select a role");
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Username.Text = "";
            Password.Text = "";
        }

        private void SelectRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Username_label_Click(object sender, EventArgs e)
        {

        }
    }
}


using Project_Marketplace;
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

namespace WinFormsApp1
{
    public partial class Blogin : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=SUDIPTO;Initial Catalog=ProjectMarketplace;Integrated Security=True");
        public Blogin()
        {
            InitializeComponent();
        }

        private void BLoginbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Bloginusername.Text) || string.IsNullOrWhiteSpace(Bloginpassword.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Return to prevent further execution
            }

            try
            {
                using (SqlConnection connect = new SqlConnection(@"Data Source=SUDIPTO;Initial Catalog=ProjectMarketplace;Integrated Security=True"))
                {
                    string selectData = "SELECT * FROM buyer WHERE busername = @busername AND bpassword = @bpassword";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@busername", Bloginusername.Text);
                        cmd.Parameters.AddWithValue("@bpassword", Bloginpassword.Text);

                        connect.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Close();
                            MessageBox.Show("Logged In successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ProjectBuy mForm = new ProjectBuy();
                            mForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            reader.Close();
                            MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception details for debugging
                MessageBox.Show($"Error Connecting: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
            }
        }

        private void screateaccount_Click(object sender, EventArgs e)
        {
            Bsignup form = new Bsignup();
            form.Show();
            this.Hide();
        }

        private void Blogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomePage form = new WelcomePage();
            form.Show();
            this.Hide();
        }
    }
}

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
using WinFormsApp1;

namespace Project_Marketplace
{
    public partial class ALogin : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=SUDIPTO;Initial Catalog=ProjectMarketplace;Integrated Security=True");
        public ALogin()
        {
            InitializeComponent();
        }

        private void ALoginbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Aloginusername.Text) || string.IsNullOrWhiteSpace(Aloginpassword.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Return to prevent further execution
            }

            try
            {
                using (SqlConnection connect = new SqlConnection(@"Data Source=SUDIPTO;Initial Catalog=ProjectMarketplace;Integrated Security=True"))
                {
                    string selectData = "SELECT * FROM admin WHERE ausername = @ausername AND apassword = @apassword";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@ausername", Aloginusername.Text);
                        cmd.Parameters.AddWithValue("@apassword", Aloginpassword.Text);

                        connect.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Close();
                            MessageBox.Show("Logged In successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            AdminPage mForm = new AdminPage();
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

        private void ALogin_Load(object sender, EventArgs e)
        {

        }

        private void screateaccount_Click(object sender, EventArgs e)
        {
            WelcomePage Form = new WelcomePage();
            Form.Show();
            this.Hide();
        }
    }
}

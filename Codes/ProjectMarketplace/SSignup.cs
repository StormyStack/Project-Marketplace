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
    public partial class SSignup : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=SUDIPTO;Initial Catalog=ProjectMarketplace;Integrated Security=True");
        public SSignup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SLogin Form = new SLogin();
            Form.Show();
            this.Hide();
        }

        private void SSignupbutton_Click(object sender, EventArgs e)
        {
            if (Ssignupemail.Text == "" || Ssignupusername.Text == "" || Ssignuppass.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();
                    string checkUsernameQuery = "SELECT * FROM seller WHERE susername = @susername";
                    SqlCommand checkUsernameCmd = new SqlCommand(checkUsernameQuery, connect);
                    checkUsernameCmd.Parameters.AddWithValue("@susername", Ssignupusername.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(checkUsernameCmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count >= 1)
                    {
                        MessageBox.Show(Ssignupusername.Text + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string insertDataQuery = "INSERT INTO seller (semail, susername, spassword, date_created) " +
                                                 "VALUES (@semail, @susername, @spassword, @date)";
                        SqlCommand insertCmd = new SqlCommand(insertDataQuery, connect);
                        insertCmd.Parameters.AddWithValue("@semail", Ssignupemail.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@susername", Ssignupusername.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@spassword", Ssignuppass.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@date", DateTime.Today);

                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // TO SWITCH THE FORM 
                            SLogin lForm = new SLogin();
                            lForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            WelcomePage Form = new WelcomePage();
            Form.Show();
            this.Hide();
        }
    }
}

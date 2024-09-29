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
    public partial class Bsignup : Form

    {
        public Bsignup()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=SUDIPTO;Initial Catalog=ProjectMarketplace;Integrated Security=True");
        private void BSignupbutton_Click(object sender, EventArgs e)
        {
            if (Bsignupemail.Text == "" || Bsignupusername.Text == "" || Bsignuppass.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();
                    string checkUsernameQuery = "SELECT * FROM Buyer WHERE busername = @busername";
                    SqlCommand checkUsernameCmd = new SqlCommand(checkUsernameQuery, connect);
                    checkUsernameCmd.Parameters.AddWithValue("@busername", Bsignupusername.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(checkUsernameCmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count >= 1)
                    {
                        MessageBox.Show(Bsignupusername.Text + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string insertDataQuery = "INSERT INTO buyer (bemail, busername, bpassword, date_created) " +
                                                 "VALUES (@bemail, @busername, @bpassword, @date)";
                        SqlCommand insertCmd = new SqlCommand(insertDataQuery, connect);
                        insertCmd.Parameters.AddWithValue("@bemail", Bsignupemail.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@busername", Bsignupusername.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@bpassword", Bsignuppass.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@date", DateTime.Today);

                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // TO SWITCH THE FORM 
                            Blogin lForm = new Blogin();
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

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            WelcomePage Form = new WelcomePage();
            Form.Show();
            this.Hide();
        }
    }
}

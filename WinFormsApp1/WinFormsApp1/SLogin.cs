using Project_Marketplace;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SLogin : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=SUDIPTO;Initial Catalog=ProjectMarketplace;Integrated Security=True");

        public SLogin()
        {
            InitializeComponent();
        }

        private void SLoginbutton_Click(object sender, EventArgs e)
        {
            if (Sloginusername.Text == "" || Sloginpassword.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connect = new SqlConnection(@"Data Source=SUDIPTO;Initial Catalog=ProjectMarketplace;Integrated Security=True"))
                {
                    string selectData = "SELECT sid FROM seller WHERE susername = @susername AND spassword = @spassword";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@susername", Sloginusername.Text);
                        cmd.Parameters.AddWithValue("@spassword", Sloginpassword.Text);

                        connect.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            int sellerId = reader.GetInt32(0);

                            MessageBox.Show("Logged in successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            projectsell mForm = new projectsell(sellerId);
                            mForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Connecting: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
            }
        }

        private void screateaccount_Click(object sender, EventArgs e)
        {
            SSignup form = new SSignup();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomePage Form = new WelcomePage();
            Form.Show();
            this.Hide();
        }
    }
}

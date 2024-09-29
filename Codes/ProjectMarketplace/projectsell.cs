using Project_Marketplace;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class projectsell : Form
    {
        private int sellerId;
        private int sellkey = 0;
        private SqlConnection connect = new SqlConnection(@"Data Source=SUDIPTO;Initial Catalog=ProjectMarketplace;Integrated Security=True");

        public projectsell(int loggedInSellerId)
        {
            InitializeComponent();
            sellerId = loggedInSellerId;
        }

        private void populate()
        {
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM SellerTbl", connect))
                {
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    SellerDGV.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating data: " + ex.Message);
            }
        }

        private void projectsell_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Pnametxt.Text) || string.IsNullOrWhiteSpace(Ctgrytxt.Text) || string.IsNullOrWhiteSpace(Pricetxt.Text))
            {
                MessageBox.Show("Missing Data");
                return;
            }

            if (!decimal.TryParse(Pricetxt.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            try
            {
                connect.Open();
                string query = "INSERT INTO SellerTbl (ProjectName, Price, Category, sid) VALUES (@ProjectName, @Price, @Category, @SellerId); SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@ProjectName", Pnametxt.Text);
                    cmd.Parameters.AddWithValue("@Category", Ctgrytxt.Text);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@SellerId", sellerId);

                    var newProjectId = Convert.ToInt32(cmd.ExecuteScalar());
                    MessageBox.Show($"Project Successfully Added with ID: {newProjectId}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding project: " + ex.Message);
            }
            finally
            {
                connect.Close();
                populate();
                clear();
            }
        }

        private void clear()
        {
            Pnametxt.Text = "";
            Ctgrytxt.Text = "";
            Pricetxt.Text = "";
            sellkey = 0;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (sellkey == 0)
            {
                MessageBox.Show("Please select a project to edit.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Pnametxt.Text) || string.IsNullOrWhiteSpace(Ctgrytxt.Text) || string.IsNullOrWhiteSpace(Pricetxt.Text))
            {
                MessageBox.Show("Missing Data");
                return;
            }

            if (!decimal.TryParse(Pricetxt.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=SUDIPTO;Initial Catalog=ProjectMarketplace;Integrated Security=True"))
                {
                    Con.Open();
                    string query = "UPDATE SellerTbl SET ProjectName=@ProjectName, Category=@Category, Price=@Price WHERE ProjectId=@ProjectId";
                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@ProjectName", Pnametxt.Text);
                        cmd.Parameters.AddWithValue("@Category", Ctgrytxt.Text);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@ProjectId", sellkey);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Project Successfully Updated");
                            populate();
                            clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update project. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating project: " + ex.Message);
            }
        }

        private void SellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = SellerDGV.Rows[e.RowIndex];

                if (row.Cells[0].Value != null)
                {
                    sellkey = Convert.ToInt32(row.Cells[0].Value);
                    Pnametxt.Text = row.Cells[1].Value?.ToString() ?? "";
                    Ctgrytxt.Text = row.Cells[2].Value?.ToString() ?? "";
                    Pricetxt.Text = row.Cells[3].Value?.ToString() ?? "";

                }
                else
                {
                    MessageBox.Show("Project ID is not available in the selected row.");
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void DltBtn_Click(object sender, EventArgs e)
        {
            if (sellkey == 0)
            {
                MessageBox.Show("Select The Project Info To be Deleted");
                return;
            }

            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=SUDIPTO;Initial Catalog=ProjectMarketplace;Integrated Security=True"))
                {
                    Con.Open();
                    string query = "DELETE FROM SellerTbl WHERE ProjectId = @ProjectId";
                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@ProjectId", sellkey);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Project Deleted Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the project. Project ID may not exist.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting project: " + ex.Message);
            }
            finally
            {
                populate();
                clear();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            SLogin Form = new SLogin();
            Form.Show();
            this.Hide();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            WelcomePage Form = new WelcomePage();
            Form.Show();
            this.Hide();
        }

        private void Pnametxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void Pricetxt_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

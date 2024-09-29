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
    public partial class ProjectBuy : Form
    {
        private int selectedProjectId = -1;
        SqlConnection connect = new SqlConnection(@"Data Source=SUDIPTO;Initial Catalog=ProjectMarketplace;Integrated Security=True");

        public ProjectBuy()
        {
            InitializeComponent();
        }

        private void ProjectBuy_Load(object sender, EventArgs e)
        {
            BuyerDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BuyerDGV.MultiSelect = false;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(@"Data Source=SUDIPTO;Initial Catalog=ProjectMarketplace;Integrated Security=True"))
                {
                    connect.Open();
                    string query = "SELECT * FROM BuyerView";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    BuyerDGV.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuyerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && BuyerDGV.Rows[e.RowIndex].Cells["ProjectID"].Value != null)
            {
                BuyerDGV.Rows[e.RowIndex].Selected = true;

                selectedProjectId = Convert.ToInt32(BuyerDGV.Rows[e.RowIndex].Cells["ProjectID"].Value);
                string projectName = BuyerDGV.Rows[e.RowIndex].Cells["ProjectName"].Value.ToString();

                MessageBox.Show($"Selected Project: {projectName} (ID: {selectedProjectId})", "Project Selected");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchQuery = Pnametxt.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                MessageBox.Show("Please enter a search query.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SqlConnection connect = new SqlConnection(@"Data Source=SUDIPTO;Initial Catalog=ProjectMarketplace;Integrated Security=True"))
                {
                    connect.Open();
                    string query = "SELECT * FROM BuyerView WHERE ProjectName LIKE @search OR ProjectName LIKE @search";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + searchQuery + "%");

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        BuyerDGV.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            if (selectedProjectId != -1)
            {
                try
                {
                    using (SqlConnection connect = new SqlConnection(@"Data Source=SUDIPTO;Initial Catalog=ProjectMarketplace;Integrated Security=True"))
                    {
                        connect.Open();
                        string deleteQuery = "DELETE FROM SellerTbl WHERE ProjectID = @ProjectId";

                        using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@ProjectID", selectedProjectId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Project purchased successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                                selectedProjectId = -1;
                            }
                            else
                            {
                                MessageBox.Show("An error occurred while purchasing the project.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a project to purchase.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            PaymentMethod gotopay = new PaymentMethod();
            gotopay.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Blogin Form = new Blogin();
            Form.Show();
            this.Hide();
        }
    }
}

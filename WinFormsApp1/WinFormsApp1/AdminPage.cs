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
    public partial class AdminPage : Form
    {
        private int Sid = -1;
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            LoadData1();
            LoadData2();
            LoadData3();
        }
        private void LoadData1()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(@"Data Source=SUDIPTO;Initial Catalog=ProjectMarketplace;Integrated Security=True"))
                {
                    connect.Open();
                    string query = "SELECT [sid], [semail], [susername], [date_created] FROM seller";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    SellerInfoDGV.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadData2()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(@"Data Source=SUDIPTO;Initial Catalog=ProjectMarketplace;Integrated Security=True"))
                {
                    connect.Open();
                    string query = "SELECT [bid], [bemail], [busername], [date_created] FROM buyer";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    BuyerInfoDGV.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadData3()
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

                    ProjectDGV.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackbksBtn_Click(object sender, EventArgs e)
        {
            ALogin gotoalogin = new ALogin();
            gotoalogin.Show();
            this.Hide();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            WelcomePage Form = new WelcomePage();
            Form.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SellerInfoDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && SellerInfoDGV.Rows[e.RowIndex].Cells["sid"].Value != null)
            {
                SellerInfoDGV.Rows[e.RowIndex].Selected = true;

                Sid = Convert.ToInt32(SellerInfoDGV.Rows[e.RowIndex].Cells["sid"].Value);
                string SellerName = SellerInfoDGV.Rows[e.RowIndex].Cells["susername"].Value.ToString();
                MessageBox.Show($"Selected Seller: {SellerName} (ID: {Sid})", "Project Selected");
            }
        }

        private void ProjectDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Sid == -1)
            {
                MessageBox.Show("Please select a seller to delete.", "No Seller Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection Con = new SqlConnection(@"Data Source=SUDIPTO;Initial Catalog=ProjectMarketplace;Integrated Security=True"))
            {
                try
                {
                    Con.Open();
                    string query = "DELETE FROM Seller WHERE Sid = @sid";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@sid", Sid);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Seller deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData1();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the seller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

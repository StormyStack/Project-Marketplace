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

namespace Project_Marketplace
{
    public partial class Nagad : Form
    {
        public Nagad()
        {
            InitializeComponent();
        }
        private void populate()
        {
            connect.Open();
            string query = "select * from NagadTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            connect.Close();
        }

        int sellkey = 0;
        SqlConnection connect = new SqlConnection(@"Data Source=SUDIPTO;Initial Catalog=ProjectMarketplace;Integrated Security=True");

        private void ConfirmngdBtn_Click(object sender, EventArgs e)
        {
            string mobileNumber = NagadnmbrTxt.Text.Trim();
            string bkashPin = NagadPassTxt.Text.Trim();

            // Check if the mobile number is not 11 digits
            if (mobileNumber.Length != 11)
            {
                MessageBox.Show("Please enter a correct 11-digit mobile number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if the mobile number is invalid
            }

            // Check if any required data is missing
            if (string.IsNullOrEmpty(mobileNumber) || string.IsNullOrEmpty(bkashPin))
            {
                MessageBox.Show("Missing Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if data is missing
            }

            // Proceed with bkashInfo if validations are successful
            if (bkashInfo())
            {
                // If bkashInfo is successful, show the confirmation message
                MessageBox.Show("Thank you for ordering from Project Marketplace.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WelcomePage welcomeForm = new WelcomePage();
                welcomeForm.Show();
                this.Hide();
            }
        }

        private bool bkashInfo()
        {
            try
            {
                connect.Open();
                string query = "INSERT INTO NagadTbl (NagadNum, NagadPass) VALUES (@NagadNum, @NagadPass)";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@NagadNum", NagadnmbrTxt.Text);
                cmd.Parameters.AddWithValue("@NagadPass", NagadPassTxt.Text);

                cmd.ExecuteNonQuery(); // Execute the query

                connect.Close();
                populate();
                clear();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }
        private void clear()
        {

            NagadnmbrTxt.Text = "";
            sellkey = 0;

            NagadPassTxt.Text = "";

        }
        private void BackngdBtn_Click(object sender, EventArgs e)
        {
            PaymentMethod paymentForm = new PaymentMethod();
            paymentForm.Show();
            this.Hide();
        }

        private void NagadnmbrTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

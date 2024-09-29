using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace Project_Marketplace
{
    public partial class StartProject : Form
    {
        public StartProject()
        {
            InitializeComponent();
            getStartbtn.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            getStartbtn.Enabled = checkBox1.Checked;
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            // Check if the checkbox is checked
            if (checkBox1.Checked)
            {
                // Proceed with the action since the user agreed to the terms and conditions
                MessageBox.Show("You have agreed to the terms and conditions and can now get started!");
            }
            else
            {
                // Show a message box indicating that the user needs to agree to the terms and conditions
                MessageBox.Show("Please agree to the terms and conditions to proceed.", "Terms and Conditions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            WelcomePage form = new WelcomePage();
            form.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
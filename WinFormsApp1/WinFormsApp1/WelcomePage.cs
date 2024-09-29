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
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void Adminbtn_Click(object sender, EventArgs e)
        {
            ALogin form = new ALogin();
            form.Show();
            this.Hide();
        }

        private void SellerBtn_Click(object sender, EventArgs e)
        {
            SLogin form = new SLogin();
            form.Show();
            this.Hide();
        }

        private void BuyerBtn_Click(object sender, EventArgs e)
        {
            Blogin form = new Blogin();
            form.Show();
            this.Hide();
        }
    }
}

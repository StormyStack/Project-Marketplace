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
    public partial class PaymentMethod : Form
    {
        public PaymentMethod()
        {
            InitializeComponent();
        }

        private void bksCB_CheckedChanged(object sender, EventArgs e)
        {
            Bkash bkashForm = new Bkash();
            bkashForm.Show();
            this.Hide();
        }

        private void ngdCB_CheckedChanged(object sender, EventArgs e)
        {
            Nagad nagadForm = new Nagad();
            nagadForm.Show();
            this.Hide();
        }

        private void BackngdBtn_Click(object sender, EventArgs e)
        {
            ProjectBuy gotobuyer = new ProjectBuy();
            gotobuyer.Show();
            this.Hide();
        }
    }
}

using Household_Registration_System.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Household_Registration_System
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        public static string paymentInstallment;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHouse house = new frmHouse();
            house.Show();
        }

        private void firstInstallmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set payment Installment
            paymentInstallment = "First Installment";
            //Open Form
            frmPayment payment = new frmPayment();
            payment.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Household_Registration_System.UI
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            //get paymentInstallment and Set on Combobox
            string paymentInstallment = frmDashboard.paymentInstallment;
            int paymentAmount = frmDashboard.paymentAmount;
            //Set on Combobox
            cmbPaymentInstallment.Text = paymentInstallment;
            txtPaymentAmount.Text = paymentAmount.ToString();
            //Display Victims on DAta Grid View Based on paymentInstallment
        }
    }
}

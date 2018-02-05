using Household_Registration_System.BLL;
using Household_Registration_System.DAL;
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
        //get paymentInstallment and Set on Combobox
        string paymentInstallment = frmDashboard.paymentInstallment;
        int paymentAmount = frmDashboard.paymentAmount;
        string paymentNo;

        paymentDAL pdal = new paymentDAL();
        houseDAL hdal = new houseDAL();
        victimDAL vdal = new victimDAL();
        private void frmPayment_Load(object sender, EventArgs e)
        {
            //Set on Combobox
            cmbPaymentInstallment.Text = paymentInstallment;
            txtPaymentAmount.Text = paymentAmount.ToString();

            //Display Victims on DAta Grid View Based on paymentInstallment
            if(paymentInstallment=="First Installment")
            {
                paymentNo = "payment1";
            }
            else if(paymentInstallment == "Second Installment")
            {
                paymentNo = "payment2";
            }
            else if(paymentInstallment == "Third Installment")
            {
                paymentNo = "payment3";
            }

            //Now Displaying Victims based on payment Number
            DataTable dt = pdal.SelectPayment(paymentNo);
            dgvVictims.DataSource = dt;
        }

        private void cmbPaymentInstallment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the Installment Number
            string InstallmentNumber = cmbPaymentInstallment.Text;

            if (InstallmentNumber == "First Installment")
            {
                paymentNo = "payment1";
                txtPaymentAmount.Text = 50000.ToString();
            }
            else if (InstallmentNumber == "Second Installment")
            {
                paymentNo = "payment2";
                txtPaymentAmount.Text = 80000.ToString();
            }
            else if (InstallmentNumber == "Third Installment")
            {
                paymentNo = "payment3";
                txtPaymentAmount.Text = 70000.ToString();
            }

            //Now Displaying Victims based on payment Number
            DataTable dt = pdal.SelectPayment(paymentNo);
            dgvVictims.DataSource = dt;
        }

        private void dgvVictims_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            
            txtFullName.Text=dgvVictims.Rows[rowindex].Cells[0].Value.ToString();
            txtHouseGrade.Text = dgvVictims.Rows[rowindex].Cells[1].Value.ToString();
            
            //Get photo path First
            string photo= dgvVictims.Rows[rowindex].Cells[5].Value.ToString();
            if (photo != "")
            {
                //Display Image 
                pictureBoxProfilePhoto.Image = new Bitmap(photo);
            }

            txtVictimID.Text= dgvVictims.Rows[rowindex].Cells[7].Value.ToString();

            //Now Shwing House Address Based on House ID
            int house_id= int.Parse(dgvVictims.Rows[rowindex].Cells[6].Value.ToString());
            houseBLL hbd = hdal.GetDistrictByHouseID(house_id);
            string district = hbd.district;

            houseBLL hbv = hdal.GetVDCByHouseID(house_id);
            string vdc = hbv.vdc;

            houseBLL hbw = hdal.GetWardNoByHouseID(house_id);
            string ward = hbw.ward_no;

            houseBLL hbt = hdal.GetToleByHouseID(house_id);
            string tole = hbt.tole;

            txtAddress.Text = district + ", " + vdc + " - " + ward + ", " + tole;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            //Get payment Number, Payment Amount and Victim ID

            int victim_id = int.Parse(txtVictimID.Text);
            int paymentAmount = int.Parse(txtPaymentAmount.Text);

            bool success = vdal.UpdatePayment(paymentNo,paymentAmount,victim_id);
            if(success==true)
            {
                MessageBox.Show("Payment Successful. Thank You.");

                //Update Data GridView
                //Now Displaying Victims based on payment Number
                DataTable dt = pdal.SelectPayment(paymentNo);
                dgvVictims.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Payment Failed. Please Try Again.");
            }
        }
    }
}

﻿using Household_Registration_System.UI;
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
        public static int paymentAmount;
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
            paymentAmount = 50000;
            //Open Form
            frmPayment payment = new frmPayment();
            payment.Show();
        }

        private void secondInstallmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set payment Installment
            paymentInstallment = "Second Installment";
            paymentAmount = 80000;
            //Open Form
            frmPayment payment = new frmPayment();
            payment.Show();
        }

        private void thirdInstallmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set payment Installment
            paymentInstallment = "Third Installment";
            paymentAmount = 70000;
            //Open Form
            frmPayment payment = new frmPayment();
            payment.Show();
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllVictims allVictims = new frmAllVictims();
            allVictims.Show();
        }
    }
}

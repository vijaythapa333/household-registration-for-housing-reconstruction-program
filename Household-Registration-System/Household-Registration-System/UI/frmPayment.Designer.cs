﻿namespace Household_Registration_System.UI
{
    partial class frmPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.dgvVictims = new System.Windows.Forms.DataGridView();
            this.cmbPaymentInstallment = new System.Windows.Forms.ComboBox();
            this.lblInstallment = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtHouseGrade = new System.Windows.Forms.TextBox();
            this.lblHouseGrade = new System.Windows.Forms.Label();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.pictureBoxProfilePhoto = new System.Windows.Forms.PictureBox();
            this.txtVictimID = new System.Windows.Forms.TextBox();
            this.lblVictimID = new System.Windows.Forms.Label();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVictims)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFooter.BackgroundImage")));
            this.panelFooter.Controls.Add(this.btnPay);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 565);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1111, 76);
            this.panelFooter.TabIndex = 8;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(500, 13);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(112, 51);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Colaborate-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(473, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(147, 20);
            this.lblHeader.TabIndex = 10;
            this.lblHeader.Text = "FUND PAYMENT";
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1061, 12);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(38, 35);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 9;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // dgvVictims
            // 
            this.dgvVictims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVictims.Location = new System.Drawing.Point(500, 103);
            this.dgvVictims.Name = "dgvVictims";
            this.dgvVictims.Size = new System.Drawing.Size(582, 434);
            this.dgvVictims.TabIndex = 11;
            this.dgvVictims.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVictims_RowHeaderMouseClick);
            // 
            // cmbPaymentInstallment
            // 
            this.cmbPaymentInstallment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentInstallment.FormattingEnabled = true;
            this.cmbPaymentInstallment.Items.AddRange(new object[] {
            "First Installment",
            "Second Installment",
            "Third Installment"});
            this.cmbPaymentInstallment.Location = new System.Drawing.Point(654, 62);
            this.cmbPaymentInstallment.Name = "cmbPaymentInstallment";
            this.cmbPaymentInstallment.Size = new System.Drawing.Size(428, 28);
            this.cmbPaymentInstallment.TabIndex = 12;
            this.cmbPaymentInstallment.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentInstallment_SelectedIndexChanged);
            // 
            // lblInstallment
            // 
            this.lblInstallment.AutoSize = true;
            this.lblInstallment.BackColor = System.Drawing.Color.Transparent;
            this.lblInstallment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallment.ForeColor = System.Drawing.Color.White;
            this.lblInstallment.Location = new System.Drawing.Point(496, 65);
            this.lblInstallment.Name = "lblInstallment";
            this.lblInstallment.Size = new System.Drawing.Size(136, 20);
            this.lblInstallment.TabIndex = 13;
            this.lblInstallment.Text = "Select Installment";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(169, 106);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(256, 26);
            this.txtFullName.TabIndex = 15;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(21, 108);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(80, 20);
            this.lblFullName.TabIndex = 14;
            this.lblFullName.Text = "Full Name";
            // 
            // txtHouseGrade
            // 
            this.txtHouseGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHouseGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHouseGrade.Location = new System.Drawing.Point(169, 146);
            this.txtHouseGrade.Name = "txtHouseGrade";
            this.txtHouseGrade.ReadOnly = true;
            this.txtHouseGrade.Size = new System.Drawing.Size(256, 26);
            this.txtHouseGrade.TabIndex = 17;
            // 
            // lblHouseGrade
            // 
            this.lblHouseGrade.AutoSize = true;
            this.lblHouseGrade.BackColor = System.Drawing.Color.Transparent;
            this.lblHouseGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseGrade.ForeColor = System.Drawing.Color.White;
            this.lblHouseGrade.Location = new System.Drawing.Point(21, 148);
            this.lblHouseGrade.Name = "lblHouseGrade";
            this.lblHouseGrade.Size = new System.Drawing.Size(105, 20);
            this.lblHouseGrade.TabIndex = 16;
            this.lblHouseGrade.Text = "House Grade";
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentAmount.Location = new System.Drawing.Point(169, 298);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.ReadOnly = true;
            this.txtPaymentAmount.Size = new System.Drawing.Size(256, 26);
            this.txtPaymentAmount.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Payment Amount";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(169, 187);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(256, 91);
            this.txtAddress.TabIndex = 19;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(21, 189);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 18;
            this.lblAddress.Text = "Address";
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.BackColor = System.Drawing.Color.Transparent;
            this.lblProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.Color.White;
            this.lblProfile.Location = new System.Drawing.Point(27, 427);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(99, 20);
            this.lblProfile.TabIndex = 22;
            this.lblProfile.Text = "Profile Photo";
            // 
            // pictureBoxProfilePhoto
            // 
            this.pictureBoxProfilePhoto.Location = new System.Drawing.Point(169, 342);
            this.pictureBoxProfilePhoto.Name = "pictureBoxProfilePhoto";
            this.pictureBoxProfilePhoto.Size = new System.Drawing.Size(256, 195);
            this.pictureBoxProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePhoto.TabIndex = 23;
            this.pictureBoxProfilePhoto.TabStop = false;
            // 
            // txtVictimID
            // 
            this.txtVictimID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVictimID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVictimID.Location = new System.Drawing.Point(169, 62);
            this.txtVictimID.Name = "txtVictimID";
            this.txtVictimID.ReadOnly = true;
            this.txtVictimID.Size = new System.Drawing.Size(256, 26);
            this.txtVictimID.TabIndex = 25;
            // 
            // lblVictimID
            // 
            this.lblVictimID.AutoSize = true;
            this.lblVictimID.BackColor = System.Drawing.Color.Transparent;
            this.lblVictimID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVictimID.ForeColor = System.Drawing.Color.White;
            this.lblVictimID.Location = new System.Drawing.Point(21, 64);
            this.lblVictimID.Name = "lblVictimID";
            this.lblVictimID.Size = new System.Drawing.Size(73, 20);
            this.lblVictimID.TabIndex = 24;
            this.lblVictimID.Text = "Victim ID";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1111, 641);
            this.Controls.Add(this.txtVictimID);
            this.Controls.Add(this.lblVictimID);
            this.Controls.Add(this.pictureBoxProfilePhoto);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtHouseGrade);
            this.Controls.Add(this.lblHouseGrade);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblInstallment);
            this.Controls.Add(this.cmbPaymentInstallment);
            this.Controls.Add(this.dgvVictims);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.panelFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fund Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVictims)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.DataGridView dgvVictims;
        private System.Windows.Forms.ComboBox cmbPaymentInstallment;
        private System.Windows.Forms.Label lblInstallment;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtHouseGrade;
        private System.Windows.Forms.Label lblHouseGrade;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.PictureBox pictureBoxProfilePhoto;
        private System.Windows.Forms.TextBox txtVictimID;
        private System.Windows.Forms.Label lblVictimID;
    }
}
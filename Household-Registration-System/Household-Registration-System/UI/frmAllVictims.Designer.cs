namespace Household_Registration_System.UI
{
    partial class frmAllVictims
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllVictims));
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBoxProfilePhoto = new System.Windows.Forms.PictureBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.txtFirstPayment = new System.Windows.Forms.TextBox();
            this.lblFirstPayment = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtHouseGrade = new System.Windows.Forms.TextBox();
            this.lblHouseGrade = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblInstallment = new System.Windows.Forms.Label();
            this.dgvVictims = new System.Windows.Forms.DataGridView();
            this.txtSecondPayment = new System.Windows.Forms.TextBox();
            this.lblSecondPayment = new System.Windows.Forms.Label();
            this.txtThirdPayment = new System.Windows.Forms.TextBox();
            this.lblThirdPayment = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVictims)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Colaborate-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(453, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(115, 20);
            this.lblHeader.TabIndex = 12;
            this.lblHeader.Text = "ALL VICTIMS";
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1041, 9);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(38, 35);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 11;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFooter.BackgroundImage")));
            this.panelFooter.Controls.Add(this.btnClose);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 557);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1102, 76);
            this.panelFooter.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(500, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 51);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBoxProfilePhoto
            // 
            this.pictureBoxProfilePhoto.Location = new System.Drawing.Point(168, 346);
            this.pictureBoxProfilePhoto.Name = "pictureBoxProfilePhoto";
            this.pictureBoxProfilePhoto.Size = new System.Drawing.Size(256, 195);
            this.pictureBoxProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePhoto.TabIndex = 36;
            this.pictureBoxProfilePhoto.TabStop = false;
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.BackColor = System.Drawing.Color.Transparent;
            this.lblProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.Color.White;
            this.lblProfile.Location = new System.Drawing.Point(26, 431);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(99, 20);
            this.lblProfile.TabIndex = 35;
            this.lblProfile.Text = "Profile Photo";
            // 
            // txtFirstPayment
            // 
            this.txtFirstPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstPayment.Location = new System.Drawing.Point(168, 243);
            this.txtFirstPayment.Name = "txtFirstPayment";
            this.txtFirstPayment.ReadOnly = true;
            this.txtFirstPayment.Size = new System.Drawing.Size(256, 26);
            this.txtFirstPayment.TabIndex = 34;
            // 
            // lblFirstPayment
            // 
            this.lblFirstPayment.AutoSize = true;
            this.lblFirstPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstPayment.ForeColor = System.Drawing.Color.White;
            this.lblFirstPayment.Location = new System.Drawing.Point(20, 245);
            this.lblFirstPayment.Name = "lblFirstPayment";
            this.lblFirstPayment.Size = new System.Drawing.Size(106, 20);
            this.lblFirstPayment.TabIndex = 33;
            this.lblFirstPayment.Text = "First Payment";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(168, 132);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(256, 91);
            this.txtAddress.TabIndex = 32;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(20, 134);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 31;
            this.lblAddress.Text = "Address";
            // 
            // txtHouseGrade
            // 
            this.txtHouseGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHouseGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHouseGrade.Location = new System.Drawing.Point(168, 91);
            this.txtHouseGrade.Name = "txtHouseGrade";
            this.txtHouseGrade.ReadOnly = true;
            this.txtHouseGrade.Size = new System.Drawing.Size(256, 26);
            this.txtHouseGrade.TabIndex = 30;
            // 
            // lblHouseGrade
            // 
            this.lblHouseGrade.AutoSize = true;
            this.lblHouseGrade.BackColor = System.Drawing.Color.Transparent;
            this.lblHouseGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseGrade.ForeColor = System.Drawing.Color.White;
            this.lblHouseGrade.Location = new System.Drawing.Point(20, 93);
            this.lblHouseGrade.Name = "lblHouseGrade";
            this.lblHouseGrade.Size = new System.Drawing.Size(105, 20);
            this.lblHouseGrade.TabIndex = 29;
            this.lblHouseGrade.Text = "House Grade";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(168, 51);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(256, 26);
            this.txtFullName.TabIndex = 28;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(20, 53);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(80, 20);
            this.lblFullName.TabIndex = 27;
            this.lblFullName.Text = "Full Name";
            // 
            // lblInstallment
            // 
            this.lblInstallment.AutoSize = true;
            this.lblInstallment.BackColor = System.Drawing.Color.Transparent;
            this.lblInstallment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallment.ForeColor = System.Drawing.Color.White;
            this.lblInstallment.Location = new System.Drawing.Point(492, 53);
            this.lblInstallment.Name = "lblInstallment";
            this.lblInstallment.Size = new System.Drawing.Size(60, 20);
            this.lblInstallment.TabIndex = 26;
            this.lblInstallment.Text = "Search";
            // 
            // dgvVictims
            // 
            this.dgvVictims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVictims.Location = new System.Drawing.Point(496, 91);
            this.dgvVictims.Name = "dgvVictims";
            this.dgvVictims.Size = new System.Drawing.Size(582, 450);
            this.dgvVictims.TabIndex = 24;
            this.dgvVictims.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVictims_RowHeaderMouseClick);
            // 
            // txtSecondPayment
            // 
            this.txtSecondPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecondPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondPayment.Location = new System.Drawing.Point(168, 275);
            this.txtSecondPayment.Name = "txtSecondPayment";
            this.txtSecondPayment.ReadOnly = true;
            this.txtSecondPayment.Size = new System.Drawing.Size(256, 26);
            this.txtSecondPayment.TabIndex = 38;
            // 
            // lblSecondPayment
            // 
            this.lblSecondPayment.AutoSize = true;
            this.lblSecondPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblSecondPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondPayment.ForeColor = System.Drawing.Color.White;
            this.lblSecondPayment.Location = new System.Drawing.Point(20, 277);
            this.lblSecondPayment.Name = "lblSecondPayment";
            this.lblSecondPayment.Size = new System.Drawing.Size(130, 20);
            this.lblSecondPayment.TabIndex = 37;
            this.lblSecondPayment.Text = "Second Payment";
            // 
            // txtThirdPayment
            // 
            this.txtThirdPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThirdPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThirdPayment.Location = new System.Drawing.Point(168, 305);
            this.txtThirdPayment.Name = "txtThirdPayment";
            this.txtThirdPayment.ReadOnly = true;
            this.txtThirdPayment.Size = new System.Drawing.Size(256, 26);
            this.txtThirdPayment.TabIndex = 40;
            // 
            // lblThirdPayment
            // 
            this.lblThirdPayment.AutoSize = true;
            this.lblThirdPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblThirdPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdPayment.ForeColor = System.Drawing.Color.White;
            this.lblThirdPayment.Location = new System.Drawing.Point(20, 307);
            this.lblThirdPayment.Name = "lblThirdPayment";
            this.lblThirdPayment.Size = new System.Drawing.Size(131, 20);
            this.lblThirdPayment.TabIndex = 39;
            this.lblThirdPayment.Text = "Payment Amount";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(558, 51);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(520, 26);
            this.txtSearch.TabIndex = 41;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmAllVictims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1102, 633);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtThirdPayment);
            this.Controls.Add(this.lblThirdPayment);
            this.Controls.Add(this.txtSecondPayment);
            this.Controls.Add(this.lblSecondPayment);
            this.Controls.Add(this.pictureBoxProfilePhoto);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.txtFirstPayment);
            this.Controls.Add(this.lblFirstPayment);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtHouseGrade);
            this.Controls.Add(this.lblHouseGrade);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblInstallment);
            this.Controls.Add(this.dgvVictims);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBoxClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAllVictims";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Victims";
            this.Load += new System.EventHandler(this.frmAllVictims_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVictims)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBoxProfilePhoto;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.TextBox txtFirstPayment;
        private System.Windows.Forms.Label lblFirstPayment;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtHouseGrade;
        private System.Windows.Forms.Label lblHouseGrade;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblInstallment;
        private System.Windows.Forms.DataGridView dgvVictims;
        private System.Windows.Forms.TextBox txtSecondPayment;
        private System.Windows.Forms.Label lblSecondPayment;
        private System.Windows.Forms.TextBox txtThirdPayment;
        private System.Windows.Forms.Label lblThirdPayment;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
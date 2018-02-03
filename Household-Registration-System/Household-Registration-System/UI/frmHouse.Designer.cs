namespace Household_Registration_System.UI
{
    partial class frmHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHouse));
            this.panelFooter = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.txtDisctrict = new System.Windows.Forms.TextBox();
            this.txtVDC = new System.Windows.Forms.TextBox();
            this.lblVdc = new System.Windows.Forms.Label();
            this.txtWardNo = new System.Windows.Forms.TextBox();
            this.lblWardNo = new System.Windows.Forms.Label();
            this.txtTole = new System.Windows.Forms.TextBox();
            this.lblTole = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.txtAltitude = new System.Windows.Forms.TextBox();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFooter.BackgroundImage")));
            this.panelFooter.Controls.Add(this.btnNext);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 387);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(444, 76);
            this.panelFooter.TabIndex = 0;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(394, 9);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(38, 35);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Colaborate-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(145, 22);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(159, 20);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "REGISTER HOUSE";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.BackColor = System.Drawing.Color.Transparent;
            this.lblDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.ForeColor = System.Drawing.Color.White;
            this.lblDistrict.Location = new System.Drawing.Point(30, 64);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(58, 20);
            this.lblDistrict.TabIndex = 3;
            this.lblDistrict.Text = "District";
            // 
            // txtDisctrict
            // 
            this.txtDisctrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisctrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisctrict.Location = new System.Drawing.Point(130, 62);
            this.txtDisctrict.Name = "txtDisctrict";
            this.txtDisctrict.Size = new System.Drawing.Size(276, 26);
            this.txtDisctrict.TabIndex = 4;
            // 
            // txtVDC
            // 
            this.txtVDC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVDC.Location = new System.Drawing.Point(130, 109);
            this.txtVDC.Name = "txtVDC";
            this.txtVDC.Size = new System.Drawing.Size(276, 26);
            this.txtVDC.TabIndex = 6;
            // 
            // lblVdc
            // 
            this.lblVdc.AutoSize = true;
            this.lblVdc.BackColor = System.Drawing.Color.Transparent;
            this.lblVdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVdc.ForeColor = System.Drawing.Color.White;
            this.lblVdc.Location = new System.Drawing.Point(30, 107);
            this.lblVdc.Name = "lblVdc";
            this.lblVdc.Size = new System.Drawing.Size(43, 20);
            this.lblVdc.TabIndex = 5;
            this.lblVdc.Text = "VDC";
            // 
            // txtWardNo
            // 
            this.txtWardNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWardNo.Location = new System.Drawing.Point(130, 156);
            this.txtWardNo.Name = "txtWardNo";
            this.txtWardNo.Size = new System.Drawing.Size(276, 26);
            this.txtWardNo.TabIndex = 8;
            // 
            // lblWardNo
            // 
            this.lblWardNo.AutoSize = true;
            this.lblWardNo.BackColor = System.Drawing.Color.Transparent;
            this.lblWardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWardNo.ForeColor = System.Drawing.Color.White;
            this.lblWardNo.Location = new System.Drawing.Point(30, 150);
            this.lblWardNo.Name = "lblWardNo";
            this.lblWardNo.Size = new System.Drawing.Size(71, 20);
            this.lblWardNo.TabIndex = 7;
            this.lblWardNo.Text = "Ward No";
            // 
            // txtTole
            // 
            this.txtTole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTole.Location = new System.Drawing.Point(130, 202);
            this.txtTole.Name = "txtTole";
            this.txtTole.Size = new System.Drawing.Size(276, 26);
            this.txtTole.TabIndex = 10;
            // 
            // lblTole
            // 
            this.lblTole.AutoSize = true;
            this.lblTole.BackColor = System.Drawing.Color.Transparent;
            this.lblTole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTole.ForeColor = System.Drawing.Color.White;
            this.lblTole.Location = new System.Drawing.Point(30, 193);
            this.lblTole.Name = "lblTole";
            this.lblTole.Size = new System.Drawing.Size(39, 20);
            this.lblTole.TabIndex = 9;
            this.lblTole.Text = "Tole";
            // 
            // txtLatitude
            // 
            this.txtLatitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatitude.Location = new System.Drawing.Point(130, 238);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(276, 26);
            this.txtLatitude.TabIndex = 12;
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.BackColor = System.Drawing.Color.Transparent;
            this.lblLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitude.ForeColor = System.Drawing.Color.White;
            this.lblLatitude.Location = new System.Drawing.Point(30, 236);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(67, 20);
            this.lblLatitude.TabIndex = 11;
            this.lblLatitude.Text = "Latitude";
            // 
            // txtLongitude
            // 
            this.txtLongitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongitude.Location = new System.Drawing.Point(130, 279);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(276, 26);
            this.txtLongitude.TabIndex = 14;
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.BackColor = System.Drawing.Color.Transparent;
            this.lblLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitude.ForeColor = System.Drawing.Color.White;
            this.lblLongitude.Location = new System.Drawing.Point(30, 279);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(80, 20);
            this.lblLongitude.TabIndex = 13;
            this.lblLongitude.Text = "Longitude";
            // 
            // txtAltitude
            // 
            this.txtAltitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltitude.Location = new System.Drawing.Point(130, 322);
            this.txtAltitude.Name = "txtAltitude";
            this.txtAltitude.Size = new System.Drawing.Size(276, 26);
            this.txtAltitude.TabIndex = 16;
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.BackColor = System.Drawing.Color.Transparent;
            this.lblAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltitude.ForeColor = System.Drawing.Color.White;
            this.lblAltitude.Location = new System.Drawing.Point(30, 322);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(63, 20);
            this.lblAltitude.TabIndex = 15;
            this.lblAltitude.Text = "Altitude";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(166, 13);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 51);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // frmHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(444, 463);
            this.Controls.Add(this.txtAltitude);
            this.Controls.Add(this.lblAltitude);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.txtTole);
            this.Controls.Add(this.lblTole);
            this.Controls.Add(this.txtWardNo);
            this.Controls.Add(this.lblWardNo);
            this.Controls.Add(this.txtVDC);
            this.Controls.Add(this.lblVdc);
            this.Controls.Add(this.txtDisctrict);
            this.Controls.Add(this.lblDistrict);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.panelFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "House Details";
            this.panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.TextBox txtDisctrict;
        private System.Windows.Forms.TextBox txtVDC;
        private System.Windows.Forms.Label lblVdc;
        private System.Windows.Forms.TextBox txtWardNo;
        private System.Windows.Forms.Label lblWardNo;
        private System.Windows.Forms.TextBox txtTole;
        private System.Windows.Forms.Label lblTole;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.TextBox txtAltitude;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Button btnNext;
    }
}
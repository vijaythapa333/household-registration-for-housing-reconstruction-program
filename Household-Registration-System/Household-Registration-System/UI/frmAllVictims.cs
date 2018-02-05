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
    public partial class frmAllVictims : Form
    {
        public frmAllVictims()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        victimDAL vdal = new victimDAL();
        houseConditionDAL hcdal = new houseConditionDAL();
        houseDAL hdal = new houseDAL();
        private void frmAllVictims_Load(object sender, EventArgs e)
        {
            DataTable dt = vdal.AllVictims();
            dgvVictims.DataSource = dt;
        }

        private void dgvVictims_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;

            txtFullName.Text = dgvVictims.Rows[RowIndex].Cells[0].Value.ToString();
            txtFirstPayment.Text = dgvVictims.Rows[RowIndex].Cells[1].Value.ToString();
            txtSecondPayment.Text = dgvVictims.Rows[RowIndex].Cells[2].Value.ToString();
            txtThirdPayment.Text = dgvVictims.Rows[RowIndex].Cells[3].Value.ToString();

            //For Displaying Profile Picture
            string photo= dgvVictims.Rows[RowIndex].Cells[4].Value.ToString();
            if(photo != "")
            {
                //Display Image 
                pictureBoxProfilePhoto.Image = new Bitmap(photo);
            }

            //For Displaying House Grade and house Address
            int house_id= int.Parse(dgvVictims.Rows[RowIndex].Cells[5].Value.ToString());
            houseConditionBLL hcb = hcdal.GetHouseGradeByHouseId(house_id);
            txtHouseGrade.Text = hcb.damage_grade;

            //Dislaying House Address Based on house_id
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if(keywords!="")
            {
                DataTable dt = vdal.Search(keywords);
                dgvVictims.DataSource = dt;
            }
            else
            {
                DataTable dt = vdal.AllVictims();
                dgvVictims.DataSource = dt;
            }
        }
    }
}

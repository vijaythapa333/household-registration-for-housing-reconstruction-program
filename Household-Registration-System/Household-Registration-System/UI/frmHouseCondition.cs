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
    public partial class frmHouseCondition : Form
    {
        public frmHouseCondition()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        houseConditionBLL hc = new houseConditionBLL();
        houseConditionDAL hcdal = new houseConditionDAL();

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Get the Details from UI
            hc.no_of_flats_before = txtNoOfFlatsBefore.Text;
            hc.no_of_flats_after = txtNoOfFlatsAfter.Text;
            hc.life_span_of_house = txtLifeSpanOfhouse.Text;
            hc.area_of_house = txtAreaOfhouse.Text;
            hc.surface_of_house = cmbSurfaceOfHouse.Text;
            hc.base_of_house = cmbBaseOfHouse.Text;
            hc.super_structure_of_house = cmbSuperStructure.Text;
            hc.materials_for_other_floors = cmbMaterialsForOtherFloors.Text;
            hc.roof_of_house = cmbRoofOfHouse.Text;
            hc.position_of_house = cmbPositionOfHouse.Text;
            hc.plan_configuration = cmbPlanConfiguration.Text;
            hc.house_analysed_part = cmbHouseAnalysedPart.Text;
            hc.damage_grade = cmbDamageGrade.Text;
            hc.technical_assistance = cmbTechnicalAssistance.Text;
            hc.started_maintenance = cmbStartedMaintenance.Text;
            hc.other_dangers = cmbOtherDangers.Text;
            //House ID get from previous submission
            hc.house_id = 1;
            hc.added_date = DateTime.Now;

            bool success = hcdal.Insert(hc);
            if(success==true)
            {
                //House Condition Registered Successfully
                MessageBox.Show("House Condition Registered Successfully Proceed to Final Step.");

                //Then Close this Form
                this.Hide();

                //Open House Owner Details
                frmVictim victim = new frmVictim();
                victim.Show();
            }
            else
            {
                //Failed to REgister House Condition
                MessageBox.Show("Failed to Register House Condition. Try Again.");
            }
            

            
        }
    }
}

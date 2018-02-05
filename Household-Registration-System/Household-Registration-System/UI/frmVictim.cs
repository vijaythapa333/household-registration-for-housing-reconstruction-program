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
    public partial class frmVictim : Form
    {
        public frmVictim()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        victimBLL v = new victimBLL();
        victimDAL vdal = new victimDAL();

        static string photoPath;

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Get all the Data from Form
            v.full_name = txtFullName.Text;
            v.dob = dtpDOB.Text;
            v.family_members = txtFamilyMembers.Text;
            v.father_name = txtFathersName.Text;
            v.grand_father_name = txtGrandFathersName.Text;

            //Get the path of Selected image
            v.photo = photoPath;

            //Get the house id and house Condition ID form the previous forms
            v.house_id = frmHouse.house_id;
            v.house_condition_id = frmHouseCondition.house_condition_id;
            v.added_date = DateTime.Now;
            v.payment1 = 0;
            v.payment2 = 0;
            v.payment3 = 0;

            bool success = vdal.Insert(v);
            if(success==true)
            {
                //Victim Registered Successfully
                MessageBox.Show("House Owner Registered Successfully. Process Completed. Thank you.");
                //Close This Form
                this.Hide();
            }
            else
            {
                //Failed to REgister Victim
                MessageBox.Show("Failed to Register House Owner. Please Try Again.");
            }
            

            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            browse.Filter= "Images|*.png;*.jpg;*.jpeg;*.gif";
            if(browse.ShowDialog()==DialogResult.OK)
            {
                photoPath = browse.FileName;
                pictureBoxPhoto.Image= new Bitmap(browse.FileName);
            }
        }
    }
}

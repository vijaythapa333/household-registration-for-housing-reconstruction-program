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
    public partial class frmHouse : Form
    {
        public frmHouse()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        houseBLL h = new houseBLL();
        houseDAL hdal = new houseDAL();

        public static int house_id;

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Get all the Data from UI
            h.district = txtDisctrict.Text;
            h.vdc = txtVDC.Text;
            h.ward_no = txtWardNo.Text;
            h.tole = txtTole.Text;
            h.latitude = txtLatitude.Text;
            h.longitude = txtLongitude.Text;
            h.altitude = txtAltitude.Text;
            h.added_date = DateTime.Now;

            bool success = hdal.Insert(h);
            if(success==true)
            {
                //House Registered Successfully
                MessageBox.Show("House Registerd Successfully. Proceed to Next Step.");

                //Get the Latest House ID and set it to house_id
                houseBLL hb = hdal.GetLastinsertedHouseId();
                house_id = hb.house_id;

                //Close this form if House Registration Success
                this.Hide();

                //Open House Condition Form if Success
                frmHouseCondition houseCondition = new frmHouseCondition();
                houseCondition.Show();
            }
            else
            {
                //FAiled to Register House
                MessageBox.Show("Failed to Register House. Try Again.");
            }
            
        }
    }
}

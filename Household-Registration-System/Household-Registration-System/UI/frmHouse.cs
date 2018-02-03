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

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Save The Data First

            //Close this form if House Registration Success
            this.Hide();

            //Open House Condition Form if Success
            frmHouseCondition houseCondition = new frmHouseCondition();
            houseCondition.Show();
        }
    }
}

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

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Save all the House Condition Details First

            //Then Close this Form
            this.Hide();

            //Open House Owner Details
            frmVictim victim = new frmVictim();
            victim.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household_Registration_System.BLL
{
    class victimBLL
    {
        public int victim_id { get; set; }
        public string full_name { get; set; }
        public string dob { get; set; }
        public string family_members { get; set; }
        public string father_name { get; set; }
        public string grand_father_name { get; set; }
        public string photo { get; set; }
        public int house_id { get; set; }
        public int house_condition_id { get; set; }
        public DateTime added_date { get; set; }
        public int payment1 { get; set; }
        public int payment2 { get; set; }
        public int payment3 { get; set; }
    }
}

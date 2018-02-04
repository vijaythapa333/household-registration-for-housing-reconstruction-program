using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household_Registration_System.BLL
{
    class houseConditionBLL
    {
        public int house_condition_id { get; set; }
        public string no_of_flats_before { get; set; }
        public string no_of_flats_after { get; set; }
        public string life_span_of_house { get; set; }
        public string area_of_house { get; set; }
        public string surface_of_house { get; set; }
        public string base_of_house { get; set; }
        public string super_structure_of_house { get; set; }
        public string materials_for_other_floors { get; set; }
        public string roof_of_house { get; set; }
        public string position_of_house { get; set; }
        public string plan_configuration { get; set; }
        public string house_analysed_part { get; set; }
        public string damage_grade { get; set; }
        public string technical_assistance { get; set; }
        public string started_maintenance { get; set; }
        public string other_dangers { get; set; }
        public int house_id { get; set; }
        public DateTime added_date { get; set; }

    }
}

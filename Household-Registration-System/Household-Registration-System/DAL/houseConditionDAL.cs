using Household_Registration_System.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Household_Registration_System.DAL
{
    class houseConditionDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region INSERT METHOD TO REGISTER HOUSE CONDITION
        public bool Insert(houseConditionBLL h)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            bool isSuccess = false;

            try
            {
                string sql = "INSERT INTO tbl_house_condition (no_of_flats_before, no_of_flats_after, life_span_of_house, area_of_house, surface_of_house, base_of_house, super_structure_of_house, materials_for_other_floors, roof_of_house, position_of_house, plan_configuration, house_analysed_part, damage_grade, started_maintenance, other_dangers, house_id, added_date, technical_assistance) VALUES (@no_of_flats_before, @no_of_flats_after, @life_span_of_house, @area_of_house, @surface_of_house, @base_of_house, @super_structure_of_house, @materials_for_other_floors, @roof_of_house, @position_of_house, @plan_configuration, @house_analysed_part, @damage_grade, @started_maintenance, @other_dangers, @house_id, @added_date, @technical_assistance)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@no_of_flats_before", h.no_of_flats_before);
                cmd.Parameters.AddWithValue("@no_of_flats_after", h.no_of_flats_after);
                cmd.Parameters.AddWithValue("@life_span_of_house", h.life_span_of_house);
                cmd.Parameters.AddWithValue("@area_of_house", h.area_of_house);
                cmd.Parameters.AddWithValue("@surface_of_house", h.surface_of_house);
                cmd.Parameters.AddWithValue("@base_of_house", h.base_of_house);
                cmd.Parameters.AddWithValue("@super_structure_of_house", h.super_structure_of_house);
                cmd.Parameters.AddWithValue("@materials_for_other_floors", h.materials_for_other_floors);
                cmd.Parameters.AddWithValue("@roof_of_house", h.roof_of_house);
                cmd.Parameters.AddWithValue("@position_of_house", h.position_of_house);
                cmd.Parameters.AddWithValue("@plan_configuration", h.plan_configuration);
                cmd.Parameters.AddWithValue("@house_analysed_part", h.house_analysed_part);
                cmd.Parameters.AddWithValue("@damage_grade",h.damage_grade);
                cmd.Parameters.AddWithValue("@started_maintenance", h.started_maintenance);
                cmd.Parameters.AddWithValue("@other_dangers", h.other_dangers);
                cmd.Parameters.AddWithValue("@house_id", h.house_id);
                cmd.Parameters.AddWithValue("@added_date", h.added_date);
                cmd.Parameters.AddWithValue("@technical_assistance", h.technical_assistance);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    //House Condition Registered Successfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to REgister house Condition
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
           
        }
        #endregion
    }
}

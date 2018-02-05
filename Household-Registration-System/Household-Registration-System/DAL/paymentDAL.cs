using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Household_Registration_System.DAL
{
    class paymentDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region METHOD TO SEECT DETAILS BASED ON PAYMENT
        public DataTable SelectPayment(string payment)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT tbl_victim.full_name,tbl_house_condition.damage_grade,tbl_victim.payment1,tbl_victim.payment2,tbl_victim.payment3,tbl_victim.photo,tbl_victim.house_id,tbl_victim.victim_id FROM tbl_victim,tbl_house_condition WHERE tbl_victim.house_id=tbl_house_condition.house_id AND (tbl_house_condition.damage_grade='Grade 3' OR tbl_house_condition.damage_grade='Grade 4' OR tbl_house_condition.damage_grade='Grade 5') AND tbl_victim." + payment+"=0";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                conn.Open();

                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        #endregion
    }
}

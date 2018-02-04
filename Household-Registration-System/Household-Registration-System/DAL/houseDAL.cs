using Household_Registration_System.BLL;
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
    class houseDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Method to Register New House
        public bool Insert(houseBLL h)
        {
            //DAtabase Connection First
            SqlConnection conn = new SqlConnection(myconnstrng);
            //Define Bool value and set its default value to false
            bool isSuccess = false;

            try
            {
                //SQL Query to Insert DAta
                string sql = "INSERT INTO tbl_house (district, vdc, ward_no, tole, latitude, longitude, altitude, added_date) VALUES (@district, @vdc, @ward_no, @tole, @latitude, @longitude, @altitude, @added_date)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@district", h.district);
                cmd.Parameters.AddWithValue("@vdc", h.vdc);
                cmd.Parameters.AddWithValue("@ward_no", h.ward_no);
                cmd.Parameters.AddWithValue("@tole", h.tole);
                cmd.Parameters.AddWithValue("@latitude", h.latitude);
                cmd.Parameters.AddWithValue("@longitude", h.longitude);
                cmd.Parameters.AddWithValue("@altitude", h.altitude);
                cmd.Parameters.AddWithValue("@added_date", h.added_date);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    //Data Inserted Successfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Insert DAta
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Database Connection Close
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region Method to Get Last Inserted house_id
        public houseBLL GetLastinsertedHouseId()
        {
            houseBLL h = new houseBLL();
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT MAX(house_id) AS house_id FROM tbl_house";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();

                adapter.Fill(dt);
                if(dt.Rows.Count>0)
                {
                    h.house_id = int.Parse(dt.Rows[0]["house_id"].ToString());
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
            return h;
        }
        #endregion
    }
}

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
    class victimDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Method to Insert House Owner
        public bool Insert(victimBLL v)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            bool isSuccess = false;

            try
            {
                string sql = "INSERT INTO tbl_victim (full_name, dob, family_members, father_name, grand_father_name, photo, house_id, house_condition_id, added_date, payment1, payment2, payment3) VALUES (@full_name, @dob, @family_members, @father_name, @grand_father_name, @photo, @house_id, @house_condition_id, @added_date, @payment1, @payment2, @payment3)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@full_name", v.full_name);
                cmd.Parameters.AddWithValue("@dob", v.dob);
                cmd.Parameters.AddWithValue("@family_members", v.family_members);
                cmd.Parameters.AddWithValue("@father_name", v.father_name);
                cmd.Parameters.AddWithValue("@grand_father_name", v.grand_father_name);
                cmd.Parameters.AddWithValue("@photo", v.photo);
                cmd.Parameters.AddWithValue("@house_id", v.house_id);
                cmd.Parameters.AddWithValue("@house_condition_id", v.house_condition_id);
                cmd.Parameters.AddWithValue("@added_date", v.added_date);
                cmd.Parameters.AddWithValue("@payment1", v.payment1);
                cmd.Parameters.AddWithValue("@payment2", v.payment2);
                cmd.Parameters.AddWithValue("@payment3", v.payment3);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    //Victim ID Registered
                    isSuccess = true;
                }
                else
                {
                    //Failed to Register Victim
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
        #region METHOD TO DISPLAY ALL VICTIMS
        public DataTable AllVictims()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT full_name, payment1, payment2, payment3, photo, house_id FROM tbl_victim";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                conn.Open();

                adapter.Fill(dt);
            }
            catch(Exception ex)
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
        #region METHOD TO SEARCH VICTIM
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT full_name, payment1, payment2, payment3, photo, house_id FROM tbl_victim WHERE full_name LIKE '%"+keywords+"%'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                conn.Open();

                adapter.Fill(dt);
            }
            catch(Exception ex)
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
        #region METHOD TO UPDATE PAYMENT
        public bool UpdatePayment(string paymentNo, int paymentAmount,int victim_id)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            bool isSuccess = false;

            try
            {
                string sql = "UPDATE tbl_victim SET "+paymentNo+"="+paymentAmount+" WHERE victim_id="+victim_id;

                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
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

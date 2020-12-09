using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace AdminBanHang.DAL
{
    public class ComboDAL
    {
        public static DataTable GetAllCombo()
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select * from Combo";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }
        public static string pathImage(int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select Image from Combo where Id=" + id;
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                return dt.Rows[0][0].ToString();
            }
        }
        public static ArrayList ListIDProduct(int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select Product_Id from ComboProduct where Combo_Id=" + id;
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                ArrayList temp = new ArrayList();
                foreach(DataRow row in dt.Rows)
                {
                    temp.Add(row.Field<int>("Product_Id"));
                }
                return temp;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminBanHang.DTO;

namespace AdminBanHang.DAL
{
    public class CustomerDAL
    {
        public static DataTable getAllCustomer()
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select * from Customer";
                SqlCommand com = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                conn.Close();
                return dt;
            }    
        }
        public static DataTable Search(string name, string phone)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select * from Customer where (FirstName like N'%" + name + "%' or LastName like N'%" + name + "%') and Phone like '%" + phone + "%'";
                SqlCommand com = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }
        public static void ChangeStatus(int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select status from Customer where Id = "+id;
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                if(dt.Rows[0][0].ToString().Equals("Active"))
                    sql = "Update Customer set status = 'Block' where Id="+id;
                else
                    sql = "Update Customer set status = 'Active' where Id="+id;
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}

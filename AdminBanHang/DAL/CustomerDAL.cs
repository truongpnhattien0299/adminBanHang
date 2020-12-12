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
    }
}

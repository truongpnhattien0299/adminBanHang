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
        private static SqlConnection conn = DBConnection.GetConnection();
        public static DataTable getAllCustomer()
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
}

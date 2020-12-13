using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminBanHang.DAL
{
    public class ThongkeDAL
    {
        public static ArrayList GetYear()
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select Distinct year(CreateDay) year from Invoice";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                ArrayList list = new ArrayList();
                foreach(DataRow row in dt.Rows)
                {
                    list.Add(row.Field<int>("year"));
                }
                return list;
            }    
        }

        public static int GetTotal(int month, int year)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select TotalMoney  from Invoice where YEAR(CreateDay) = "+ year +" and MONTH(CreateDay) = "+month;
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                int total = 0;
                foreach (DataRow row in dt.Rows)
                {
                    total += int.Parse(row.Field<string>("TotalMoney"));
                }
                return total;
            }
        }

        public static ArrayList GetIdHd(int month, int year)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select Id from Invoice where YEAR(CreateDay) = " + year + " and MONTH(CreateDay) = " + month;
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                ArrayList list = new ArrayList();
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(row.Field<int>("Id"));
                }
                return list;
            }
        }
    }
}

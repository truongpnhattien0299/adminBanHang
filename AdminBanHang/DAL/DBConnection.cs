using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminBanHang.DAL
{
    class DBConnection
    {
        private static string datasource = @"DESKTOP-8MU02PV\SQLEXPRESS";
        private static string database = "BanHang";
        public static SqlConnection GetConnection()
        {
            string connection_string = @"Data Source="+ datasource +";Initial Catalog="+ database +";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection_string);
            return conn;
        }
    }
}

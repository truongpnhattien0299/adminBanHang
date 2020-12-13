using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace AdminBanHang.DAL
{
    class DBConnection
    {
        private static string datasource = @"DESKTOP-8MU02PV\SQLEXPRESS";
        private static string database = "BanHang";
        public static string folder_product = @"E:\All\";
        public static string folder_combo = @"E:\All1\";
        public static SqlConnection GetConnection()
        {
            string connection_string = @"Data Source="+ datasource +";Initial Catalog="+ database +";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection_string);
            return conn;
        }
        public static string  HashPassword(string pass)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pass));
            byte[] result = md5.Hash;
            StringBuilder stringBuilder = new StringBuilder();
            for(int i=0; i< result.Length; i++)
            {
                stringBuilder.Append(result[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }
        public static string FormatDate(DateTime date)
        {
            int day = date.Day;
            int month = date.Month;
            int year = date.Year;
            return month + "/" + day + "/" + year;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminBanHang.DAL
{
    class ProductDAL
    {
        private static SqlConnection conn = DBConnection.GetConnection();
        public static DataTable GetAllProduct()
        {
            conn.Open();
            string sql = "select * from Product, Category, Taxonomy where Product.Category_ID = Category.Id and Taxonomy.Id = Category.Taxonomy_Id";
            SqlCommand com = new SqlCommand(sql, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}

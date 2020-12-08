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
    class ProductDAL
    {
        public static DataTable GetAllProduct()
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select * from Product, Category, Taxonomy where Product.Category_ID = Category.Id and Taxonomy.Id = Category.Taxonomy_Id";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static List<Category> GetAllCategory()
        {
            using(SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select * from Category";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                List<Category> list = new List<Category>();
                foreach (DataRow item in dt.Rows)
                {
                    Category category = new Category();
                    category.Id = item.Field<int>("Id");
                    category.CategoryName = item.Field<string>("CategoryName");
                    category.Taxonomy_Id = item.Field<int>("Taxonomy_Id");
                    list.Add(category);
                }
                conn.Close();
                return list;
            }    
        }
        public static void AddProduct(Product product)
        {
            using(SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string productname = product.productname;
                string image = product.image;
                int amount = product.amount;
                int price = product.price;
                string detail = product.detail;
                int category_id = product.categoryid;

                string sql = @"INSERT INTO Product VALUES" +
                                "('" + productname + "'," + category_id + "," + amount + "," + price +
                                ",'" + detail + "','" + image +"')";
                SqlCommand com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();
                conn.Close();
            }    

        }    
    }
}

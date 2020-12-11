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
    public class LapDonHangDAL
    {
        public static Product GetProduct(int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                Product product = new Product();
                conn.Open();
                string sql = "select * from Product where Id="+ id;
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                conn.Close();
                product.id = int.Parse(dt.Rows[0][0].ToString());
                product.productname = dt.Rows[0][1].ToString();
                product.categoryid = int.Parse(dt.Rows[0][2].ToString());
                product.amount = int.Parse(dt.Rows[0][3].ToString());
                product.price = int.Parse(dt.Rows[0][4].ToString());
                product.detail = dt.Rows[0][5].ToString();
                product.image = dt.Rows[0][6].ToString();
                return product;
            }
        }
        public static Combo GetCombo(int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                Combo combo = new Combo();
                conn.Open();
                string sql = "select * from Combo where Id=" + id;
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                conn.Close();
                combo.Id = int.Parse(dt.Rows[0][0].ToString());
                combo.comboName = dt.Rows[0][1].ToString();
                combo.dayStart = DateTime.Parse(dt.Rows[0][2].ToString());
                combo.dayEnd = DateTime.Parse(dt.Rows[0][3].ToString());
                combo.total = int.Parse(dt.Rows[0][4].ToString());
                combo.discountMoney = dt.Rows[0][6].ToString();
                combo.image = dt.Rows[0][7].ToString();
                return combo;
            }
        }
    }
}

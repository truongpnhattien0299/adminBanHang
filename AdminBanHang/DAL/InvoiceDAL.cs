using System.Data;
using System.Data.SqlClient;

namespace AdminBanHang.DAL
{
    public class InvoiceDAL
    {
        public static DataTable GetAllInvoice()
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select * from invoice, Customer where Invoice.Customer_Id = Customer.id";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }
        public static DataTable GetInvoiceDetail(int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select * from InvoiceDetail where Invoice_Id = "+id;
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }
        public static DataTable Search(string status, int code, string namecus)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "";
                if (code != -1)
                sql = "select * from invoice as i, Customer as c where i.Customer_Id = c.id " +
                                "and i.status like N'%"+ status +"%' " +
                                "and (c.FirstName like N'%"+ namecus +"%' " +
                                "or c.LastName like N'%"+ namecus +"%') " +
                                "and i.Id = "+code;
                else
                    sql = "select * from invoice as i, Customer as c where i.Customer_Id = c.id " +
                                "and i.status like N'%" + status + "%' " +
                                "and (c.FirstName like N'%" + namecus + "%' " +
                                "or c.LastName like N'%" + namecus + "%') ";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }
        public static void UpdateStatus(int id, string s)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = @"UPDATE Invoice SET status = '" + s + "' WHERE Id =" + id;
                SqlCommand com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}

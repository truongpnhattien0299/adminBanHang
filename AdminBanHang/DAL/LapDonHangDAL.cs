using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using AdminBanHang.DTO;

namespace AdminBanHang.DAL
{
    public class LapDonHangDAL
    {
        private static readonly Random _random = new Random();
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

        public static void AddKhach(string firstname, string lastname, string phone, string address)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string username = RandomUsername();
                string password = DBConnection.HashPassword(phone);
                string email = username + "@gmail.com";
                string gender = "Male";
                string day = DBConnection.FormatDate(DateTime.Now);
                int isNew = 2;
                string status = "Active";
                string sql = "insert into Customer VALUES ('" +username+"','"+password + "','" + email + "',N'" + firstname
                                               + "',N'" + lastname + "','" + gender + "','" + day + "',N'" + address + "','" + phone
                                               + "','" + day + "'," + isNew + ",N'" + status+"')";
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }
        public static int getIdCustommer()
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select MAX(Id) From Customer";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                conn.Close();
                return int.Parse(dt.Rows[0][0].ToString());
            }
        }
        public static void AddInvoice(Invoice invoice)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                int cusid = invoice.customer_id;
                string totalmoney = invoice.totalmoney;
                string amount = invoice.amount;
                string createday = DBConnection.FormatDate(invoice.creatday);
                string note = invoice.ordernote;
                string postcode = invoice.postcode;
                string address = invoice.customeraddress;
                string status = invoice.status;
                string sql = "insert into Invoice VALUES (" + cusid + ",'" + totalmoney + "','" + amount + "','" + createday
                                               + "','" + note + "','" + postcode + "',N'" + address + "','" + status+"')";
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }
        public static int getIdInvoice()
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select MAX(Id) From Invoice";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                conn.Close();
                return int.Parse(dt.Rows[0][0].ToString());
            }
        }
        public static void AddInvoiceDetail(string products, string combos)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "insert into InvoiceDetail VALUES ("+getIdInvoice()+",N'" + products +"',N'" + combos + "')";
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }
        private static int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
        private static string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);

            // Unicode/ASCII Letters are divided into two blocks
            // (Letters 65–90 / 97–122):
            // The first group containing the uppercase letters and
            // the second group containing the lowercase.  

            // char is a single Unicode character  
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length=26  

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }
        private static string RandomUsername()
        {
            var passwordBuilder = new StringBuilder();

            // 4-Letters lower case   
            passwordBuilder.Append(RandomString(4, true));

            // 4-Digits between 1000 and 9999  
            passwordBuilder.Append(RandomNumber(1000, 9999));

            // 2-Letters upper case  
            passwordBuilder.Append(RandomString(2));
            return passwordBuilder.ToString();
        }
    }
}

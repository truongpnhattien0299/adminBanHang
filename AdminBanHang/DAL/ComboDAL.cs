using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using AdminBanHang.DTO;

namespace AdminBanHang.DAL
{
    public class ComboDAL
    {
        public static DataTable GetAllCombo()
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select * from Combo";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }
        public static string pathImage(int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select Image from Combo where Id=" + id;
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                return dt.Rows[0][0].ToString();
            }
        }
        public static void AddCombo(Combo combo)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string comboname = combo.comboName;
                string image = combo.image;
                DateTime daystart = combo.dayStart;
                DateTime dayend = combo.dayEnd;
                int total = combo.total;
                string discountmoney = combo.discountMoney;

                string sql = @"INSERT INTO Combo VALUES" +
                                "(N'" + comboname + "','" + daystart + "','" + dayend + "'," + total +
                                ", N'', N'" + discountmoney + "', N'" + image + "')";
                SqlCommand com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();
                conn.Close();
            }
        }
        public static void AddComboProduct(ComboProduct comboProduct)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select MAX(Id) from Combo";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                int combo_id = int .Parse(dt.Rows[0][0].ToString());
                int product_id = comboProduct.product_id;

                sql = @"INSERT INTO ComboProduct VALUES(" + combo_id + ", " + product_id + ")";
                SqlCommand com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();

                conn.Close();
            }
        }
        public static void EditCombo(Combo combo, int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string comboname = combo.comboName;
                string image = combo.image;
                string daystart = FormatDate(combo.dayStart);
                string dayend = FormatDate(combo.dayEnd);
                int total = combo.total;
                string discountmoney = combo.discountMoney;
                string sql = @"UPDATE Combo SET ComboName = N'" + comboname
                                                  + "', DayStart = '" + daystart
                                                  + "', DayEnd = '" + dayend
                                                  + "', Total = " + total
                                                  + ", Discount = N'" + 0
                                                  + "', DiscountMoney = N'" + discountmoney
                                                  + "', Image = N'" + image
                            + "' WHERE Id =" + id;
                try
                {
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                conn.Close();
            }
        }
        public static DataTable Search(DateTime start, DateTime end, string text)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select * from Combo where DayStart>='"+ FormatDate(start) +"' and DayEnd <='"+ FormatDate(end) +"' and ComboName like N'%"+ text +"%'";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }    
        private static string FormatDate(DateTime date)
        {
            int day = date.Day;
            int month = date.Month;
            int year = date.Year;
            return month + "/" + day + "/" + year;

        }
        public static void EditComboProduct(ArrayList list, int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select * from ComboProduct where Combo_Id="+id;
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                foreach(DataRow row in dt.Rows)
                {
                    if(list.Count==0)
                    {
                        sql = "DELETE FROM ComboProduct WHERE Id= " + row.Field<int>("Id");
                        command = new SqlCommand(sql, conn);
                        command.ExecuteNonQuery();
                        continue;
                    }    
                    int flag = -1;
                    foreach (int item in list)
                    {
                        if(row.Field<int>("Product_Id") == item)
                        {
                            flag = 0; // có phần tử trong cơ sở dữ liệu rồi
                            list.Remove(item);
                            break;
                        }    
                    }
                    if (flag == -1) // nếu chưa có thì update
                    {
                        sql = @"UPDATE ComboProduct SET Product_Id = " + list[0]
                                + " WHERE Id =" + row.Field<int>("Id");
                        command = new SqlCommand(sql, conn);
                        command.ExecuteNonQuery();
                        list.RemoveAt(0);
                    }
                }
                if(list.Count!=0) // nếu trong list vẫn còn phần tử thì Thêm vào csdl
                {
                    foreach(int item in list)
                    {
                        sql = @"INSERT INTO ComboProduct VALUES(" + id + ", " + item + ")";
                        command = new SqlCommand(sql, conn);
                        command.ExecuteNonQuery();
                    }    
                    
                }    
                conn.Close();
            }
        }

        public static void DeleteCombo(int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM ComboProduct WHERE Combo_Id= " + id;
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                sql = "DELETE FROM Combo WHERE Id= " + id;
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        /* == Lấy id sản phẩm trong bảng ComboProduct */
        public static ArrayList ListIDProduct(int id) 
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select Product_Id from ComboProduct where Combo_Id=" + id;
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                ArrayList temp = new ArrayList();
                foreach(DataRow row in dt.Rows)
                {
                    temp.Add(row.Field<int>("Product_Id"));
                }
                return temp;
            }
        }
    }
}

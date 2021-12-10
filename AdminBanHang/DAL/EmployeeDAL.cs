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
    public class EmployeeDAL
    {

        public static bool Login(string username, string password)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select count(*) from Emplopyee where Username='" + username + "' and Password='" + DBConnection.HashPassword(password) + "' and status = 'Active'";
                SqlCommand com = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                conn.Close();
                if (dt.Rows[0][0].ToString().Equals("1"))
                    return true;
                return false;
            }
        }
        public static DataTable getAllEmployee()
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select * from Emplopyee";
                SqlCommand com = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }
        public static bool Trung(string username)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select count(*) from Emplopyee where Username='" + username + "'";
                SqlCommand com = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                conn.Close();
                int countrow = int.Parse(dt.Rows[0][0].ToString());
                if (countrow > 0)
                    return true;
                return false;
            }
        }
        public static void addEmployee(Employee employee)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string username = employee.username;
                string firstname = employee.firstname;
                string lastname = employee.lastname;
                string gender = employee.gender;
                string address = employee.address;
                int role = employee.role;
                DateTime dob = employee.birthday;
                string password = DBConnection.HashPassword(dob.Day.ToString("dd") + dob.Month.ToString("MM") + dob.Year.ToString());
                string joindate = DBConnection.FormatDate(employee.joindate);

                string sql = @"INSERT INTO Emplopyee VALUES" +
                "('" + username + "','" + password + "',N'" + firstname + "',N'" + lastname +
                "','" + gender + "','" + DBConnection.FormatDate(dob) + "',N'" + address + "','" + joindate + "'," + role + ", 'Active')";
                SqlCommand com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();
                conn.Close();
            }
        }
        public static void editEmployee(Employee employee)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string username = employee.username;
                string firstname = employee.firstname;
                string lastname = employee.lastname;
                string gender = employee.gender;
                string address = employee.address;
                int role = employee.role;
                string dob = DBConnection.FormatDate(employee.birthday);
                string joindate = DBConnection.FormatDate(employee.joindate);
                string sql = @"UPDATE Emplopyee SET FirstName = N'" + firstname
                                                  + "', LastName = N'" + lastname
                                                  + "', Gender = '" + gender
                                                  + "', Birthdate = '" + dob
                                                  + "', Address = N'" + address
                                                  + "', JoinDate = '" + joindate
                                                  + "', Role = " + role
                                + " WHERE Username = '" + username + "'";
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }
        public static void ChangeStatus(string username)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select status from Emplopyee where Username='" + username + "'";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                string status = "Active";
                if (dt.Rows[0][0].ToString().Equals("Active"))
                    status = "Block";
                sql = @"UPDATE Emplopyee SET Status = '" + status + "' WHERE Username = '" + username + "'";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }
        public static void ResetPass(string username)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select Birthdate from Emplopyee where Username='" + username + "'";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                DateTime dob = DateTime.Parse(dt.Rows[0][0].ToString());
                string day = dob.Day.ToString();
                if (int.Parse(day) < 10)
                    day = "0" + day;
                string month = dob.Month.ToString();
                if (int.Parse(month) < 10)
                    month = "0" + month;
                string password = day + month + dob.Year.ToString();
                sql = @"UPDATE Emplopyee SET PassWord = '" + DBConnection.HashPassword(password) + "' WHERE Username = '" + username + "'";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }    
    }
}

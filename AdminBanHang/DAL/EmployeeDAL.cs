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
        private static SqlConnection conn = DBConnection.GetConnection();
        public static Boolean Login(string username, string password)
        {
            conn.Open();
            string sql = "select count(*) from Emplopyee where Username='"+ username +"' and Password='"+ password+"'";
            SqlCommand com = new SqlCommand(sql, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            conn.Close();
            if(dt.Rows[0][0].ToString().Equals("1"))
                return true;
            return false;
            
        }
        public static DataTable getAllEmployee()
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
        public static Boolean Trung(string username)
        {
            conn.Open();
            string sql = "select count(*) from Emplopyee where Username='" + username +"'";
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
        public static void addEmployee(Employee employee)
        {
            conn.Open();
            string username = employee.username;
            string firstname = employee.firstname;
            string lastname = employee.lastname;
            string gender = employee.gender;
            string address = employee.address;
            int role = employee.role;
            DateTime dob = employee.birthday;
            string password = dob.Day.ToString() + dob.Month.ToString() + dob.Year.ToString();
            DateTime joindate = employee.joindate;

            string sql = @"INSERT INTO Emplopyee VALUES" +
            "('" + username + "','" + password + "','" + firstname + "','" + lastname +
            "','" + gender + "','" + dob + "','" + address + "','" + joindate + "'," + role + ")";
            SqlCommand com = new SqlCommand(sql, conn);
            com.ExecuteNonQuery();
            conn.Close();
        }
        public static void editEmployee(Employee employee)
        {
            conn.Open();
            string username = employee.username;
            string firstname = employee.firstname;
            string lastname = employee.lastname;
            string gender = employee.gender;
            string address = employee.address;
            int role = employee.role;
            DateTime dob = employee.birthday;
            DateTime joindate = employee.joindate;
            string sql = @"UPDATE Emplopyee SET FirstName = '"+ firstname
                                              + "', LastName = '"+ lastname
                                              + "', Gender = '"+ gender
                                              + "', Birthdate = '"+ dob
                                              + "', Address = '"+ address
                                              + "', JoinDate = '"+ joindate
                                              + "', Role_ID = "+ role
                            +" WHERE Username = '"+ username +"'";
            SqlCommand command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

    }
}

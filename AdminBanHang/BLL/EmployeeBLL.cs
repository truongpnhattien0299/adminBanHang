using System;
using System.Data;
using AdminBanHang.DTO;

namespace AdminBanHang.BLL
{
    class EmployeeBLL
    {
        public bool Login(string username, string password)
        {
            return DAL.EmployeeDAL.Login(username, password);
        }
        public DataTable getAllEmployee()
        {
            return DAL.EmployeeDAL.getAllEmployee();
        }
        public Boolean Trung(string username)
        {
            return DAL.EmployeeDAL.Trung(username);
        }
        public void addEmployee(Employee employee)
        {
            DAL.EmployeeDAL.addEmployee(employee);
        }

        public void editEmployee(Employee employee)
        {
            DAL.EmployeeDAL.editEmployee(employee);
        }
    }
}

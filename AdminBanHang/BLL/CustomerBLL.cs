using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminBanHang.DTO;

namespace AdminBanHang.BLL
{
    public class CustomerBLL
    {
        public DataTable getAllCustomer()
        {
            return DAL.CustomerDAL.getAllCustomer();
        }
        public DataTable Search(string name, string phone)
        {
            return DAL.CustomerDAL.Search(name,phone);
        }
        public void ChangeStatus(int id)
        {
            DAL.CustomerDAL.ChangeStatus(id);
        }
    }
}

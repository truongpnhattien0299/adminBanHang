using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminBanHang.BLL
{
    public class ThongkeBLL
    {
        public ArrayList GetYear()
        {
            return DAL.ThongkeDAL.GetYear();
        }
        public int GetTotal(int month, int year)
        {
            return DAL.ThongkeDAL.GetTotal(month, year);
        }
        public ArrayList GetIdHd(int month, int year)
        {
            return DAL.ThongkeDAL.GetIdHd(month, year);
        }
    }
}

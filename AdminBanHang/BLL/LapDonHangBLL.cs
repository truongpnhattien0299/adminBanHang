using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminBanHang.DTO;

namespace AdminBanHang.BLL
{
    public class LapDonHangBLL
    {
        public Combo GetCombo(int id)
        {
            return DAL.LapDonHangDAL.GetCombo(id);
        }
        public Product GetProduct(int id)
        {
            return DAL.LapDonHangDAL.GetProduct(id);
        }    
    }
}

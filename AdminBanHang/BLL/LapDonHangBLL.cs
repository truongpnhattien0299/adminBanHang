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
        public void AddKhach(string firstname, string lastname, string phone, string address)
        {
            DAL.LapDonHangDAL.AddKhach(firstname, lastname, phone, address);
        }
        public int getIdCustommer()
        {
            return DAL.LapDonHangDAL.getIdCustommer();
        }
        public void AddInvoice(Invoice invoice)
        {
            DAL.LapDonHangDAL.AddInvoice(invoice);
        }
        public void AddInvoiceDetail(string products, string combos)
        {
            DAL.LapDonHangDAL.AddInvoiceDetail(products, combos);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminBanHang.BLL
{
    public class InvoiceBLL
    {
        public DataTable GetAllInvoice()
        {
            return DAL.InvoiceDAL.GetAllInvoice();
        }
        public DataTable GetInvoiceDetail(int id)
        {
            return DAL.InvoiceDAL.GetInvoiceDetail(id);
        }
        public void UpdateStatus(int id, string s)
        {
            DAL.InvoiceDAL.UpdateStatus(id, s);
        }
        public DataTable Search(string status, int code, string namecus)
        {
            return DAL.InvoiceDAL.Search(status,code,namecus);
        }
    }
}

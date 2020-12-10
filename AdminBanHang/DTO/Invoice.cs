using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminBanHang.DTO
{
    public class Invoice
    {
        public int Id { get; set; }
        public int customer_id { get; set; }
        public string totalmoney { get; set; }
        public string amount { get; set; }
        public DateTime creatday { get; set; }
        public string ordernote { get; set; }
        public string postcode { get; set; }
        public string customeraddress { get; set; }
        public string status { get; set; }
    }
}

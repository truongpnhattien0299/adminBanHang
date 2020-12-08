using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminBanHang.DTO
{
    public class Customer
    {
        public int id { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public DateTime birthday { get; set; }
        public DateTime joindate { get; set; }
        public int isNew { get; set; }

        
    }
}

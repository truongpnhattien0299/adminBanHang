using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminBanHang.DTO
{
    public class Product
    {
        public int id { get; set; }
        public string productname { get; set; }
        public int categoryid { get; set; }
        public int amount { get; set; }
        public int price { get; set; }
        public string detail { get; set; }
        public string image { get; set; }

    }
}

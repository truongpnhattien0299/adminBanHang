using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminBanHang.DTO
{
    public class Combo
    {
        public int Id { get; set; }
        public string comboName { get; set; }
        public DateTime dayStart { get; set; }
        public DateTime dayEnd { get; set; }
        public int total { get; set; }
        public string discountMoney { get; set; }
        public string image { get; set; }
    }
}

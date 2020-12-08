using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminBanHang.DTO
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int Taxonomy_Id { get; set; }
    }
}

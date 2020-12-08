using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminBanHang.DTO;

namespace AdminBanHang.BLL
{
    class ProductBLL
    {
        public DataTable GetAllProduct()
        {
            return DAL.ProductDAL.GetAllProduct();
        }
        public List<Category> GetAllCategory()
        {
            return DAL.ProductDAL.GetAllCategory();
        }
        public void AddProduct(Product product)
        {
            DAL.ProductDAL.AddProduct(product);
        }    
    }
}

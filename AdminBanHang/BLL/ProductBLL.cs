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

        public string pathImage(int id)
        {
            return DAL.ProductDAL.pathImage(id);
        }
        public void AddProduct(Product product)
        {
            DAL.ProductDAL.AddProduct(product);
        }    
        public void EditProduct(Product product, int id)
        {
            DAL.ProductDAL.EditProduct(product, id);
        }
        public void DeleteProduct(int id)
        {
            DAL.ProductDAL.DeleteProduct(id);
        }
    }
}

using System.Collections;
using System.Data;

namespace AdminBanHang.BLL
{
    public class ComboBLL
    {
        public DataTable GetAllCombo()
        {
            return DAL.ComboDAL.GetAllCombo();
        }
        public string pathImage(int id)
        {
            return DAL.ComboDAL.pathImage(id);
        }
        public ArrayList ListIDProduct(int id)
        {
            return DAL.ComboDAL.ListIDProduct(id);
        }
    }
}

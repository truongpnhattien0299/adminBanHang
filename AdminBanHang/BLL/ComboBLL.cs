using System;
using System.Collections;
using System.Data;
using AdminBanHang.DTO;

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
        public void AddCombo(Combo combo)
        {
            DAL.ComboDAL.AddCombo(combo);
        }
        public void AddComboProduct(ComboProduct comboProduct)
        {
            DAL.ComboDAL.AddComboProduct(comboProduct);
        }
        public void DeleteCombo(int id)
        {
            DAL.ComboDAL.DeleteCombo(id);
        }
        public void EditCombo(Combo combo, int id)
        {
            DAL.ComboDAL.EditCombo(combo, id);
        }    
        public void EditComboProduct(ArrayList list, int id)
        {
            DAL.ComboDAL.EditComboProduct(list,id);
        }
        public ArrayList ListIDProduct(int id)
        {
            return DAL.ComboDAL.ListIDProduct(id);
        }
        public DataTable Search(DateTime start, DateTime end, string text)
        {
            return DAL.ComboDAL.Search(start, end, text);
        }
    }
}

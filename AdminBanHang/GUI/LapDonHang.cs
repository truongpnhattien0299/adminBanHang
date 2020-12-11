using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminBanHang.BLL;
using AdminBanHang.DTO;

namespace AdminBanHang.GUI
{
    public partial class LapDonHang : Form
    {
        private ImageList imageList, imageListSelect;
        private string folder_product = @"E:\All\";
        private string folder_combo = @"E:\All1\";
        private bool check = false; // cờ để kiểm tra list view đang show product( false ) hay combo ( true )
        private bool flagfind = false; // cờ để kiểm tra xem combo muốn thêm đã có trng danh sách chưa
        private int id;
        private string key;
        ArrayList arr_combo = new ArrayList();
        ArrayList arr_product = new ArrayList();
        public LapDonHang()
        {
            InitializeComponent();
            btnSanPham.Enabled = false;
            btnMove.Enabled = false;
            btnGiamSl.Enabled = false;
            LoadListViewProduct();
        }
        private void LoadImage(DataTable dataTable, string folder, int width, int height)
        {
            imageList = new ImageList() { ImageSize = new Size(width, height) };
            foreach (DataRow row in dataTable.Rows)
            {
                imageList.Images.Add(row.Field<int>("Id").ToString(), new Bitmap(folder + row.Field<string>("Image")));
            }
        }
        private void LoadListViewProduct()
        {
            ProductBLL productBLL = new ProductBLL();
            DataTable dataTable;
            //if (clickSearch)
            //{
            //    Types idtype = (Types)comboSearchType.SelectedItem;
            //    Category idcate = (Category)comboSearchCategory.SelectedItem;
            //    string text = txtSearch.Text;
            //    dataTable = productBLL.Search(idtype.Id, idcate.Id, text);
            //}
            //else
            //{
                dataTable = productBLL.GetAllProduct();
            //}
            LoadImage(dataTable, folder_product, 70, 70);
            listViewData.Clear();
            listViewData.View = View.Details;
            listViewData.FullRowSelect = true;
            listViewData.SmallImageList = imageList;

            listViewData.Columns.Add("Hình ảnh", 70);
            listViewData.Columns.Add("Tên sản phẩm", 100);
            listViewData.Columns.Add("Loại sản phẩm", 70);
            listViewData.Columns.Add("Taxonomy", 70);
            listViewData.Columns.Add("Số lượng");
            listViewData.Columns.Add("Giá tiền");
            listViewData.Columns.Add("Mô tả", 200);

            ListViewItem lvitem;
            foreach (DataRow row in dataTable.Rows)
            {
                lvitem = new ListViewItem();
                lvitem.ImageKey = row.Field<int>("Id").ToString();
                lvitem.SubItems.Add(row.Field<string>("Productname"));
                lvitem.SubItems.Add(row.Field<string>("TypeName"));
                lvitem.SubItems.Add(row.Field<string>("CategoryName"));
                lvitem.SubItems.Add(row.Field<int>("Amount").ToString());
                lvitem.SubItems.Add(row.Field<int>("Price").ToString("0,0"));
                lvitem.SubItems.Add(row.Field<string>("Detail"));
                listViewData.Items.Add(lvitem);
            }
        }
        private void LoadListViewCombo()
        {
            ComboBLL comboBLL = new ComboBLL();
            DataTable dataTable;
            //if (clickSearch)
            //    dataTable = comboBLL.Search(dateSearchStart.Value, dateSearchEnd.Value, txtSearch.Text);
            //else
                dataTable = comboBLL.GetAllCombo();
            LoadImage(dataTable, folder_combo, 120, 70);
            listViewData.Clear();
            listViewData.View = View.Details;
            listViewData.FullRowSelect = true;
            listViewData.SmallImageList = imageList;

            listViewData.Columns.Add("Hình ảnh", 120);
            listViewData.Columns.Add("Tên Combo", 80);
            listViewData.Columns.Add("Ngày bắt đầu", 140);
            listViewData.Columns.Add("Ngày kết thúc", 140);
            listViewData.Columns.Add("Total", 70);
            listViewData.Columns.Add("Giảm giá");

            ListViewItem lvitem;
            foreach (DataRow row in dataTable.Rows)
            {
                lvitem = new ListViewItem();
                lvitem.ImageKey = row.Field<int>("Id").ToString();
                lvitem.SubItems.Add(row.Field<string>("ComboName"));
                lvitem.SubItems.Add(row.Field<DateTime>("DayStart").ToString());
                lvitem.SubItems.Add(row.Field<DateTime>("DayEnd").ToString());
                lvitem.SubItems.Add(row.Field<int>("Total").ToString("0,0"));
                lvitem.SubItems.Add(int.Parse(row.Field<string>("DiscountMoney")).ToString("0,0"));
                listViewData.Items.Add(lvitem);
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            LoadListViewProduct();
            btnSanPham.Enabled = false;
            btnCombo.Enabled = true;
            btnMove.Enabled = false;
            check = false;
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            LoadListViewCombo();
            btnCombo.Enabled = false;
            btnSanPham.Enabled = true;
            btnMove.Enabled = false;
            check = true;
        }
        private void LoadImageSelect(ArrayList arr_product, ArrayList arr_combo)
        {
            imageListSelect = new ImageList() { ImageSize = new Size(70, 70) };
            if (arr_product.Count != 0)
            {
                string folder = @"E:\All\";
                foreach (Obj row in arr_product)
                {
                    imageListSelect.Images.Add("product_"+row.objProduct.id.ToString(), new Bitmap(folder + row.objProduct.image));
                }
            }
            if (arr_combo.Count != 0)
            {
                string folder = @"E:\All1\";
                foreach (Obj row in arr_combo)
                {
                    imageListSelect.Images.Add("combo_"+row.objCombo.Id.ToString(), new Bitmap(folder + row.objCombo.image));
                }
            }
        }
        private void Listview_click(object sender, EventArgs e)
        {
            id = int.Parse(listViewData.SelectedItems[0].ImageKey);
            btnMove.Enabled = true;
        }
        private void LoadListViewSelect()
        {
            LoadImageSelect(arr_product, arr_combo);
            loadkhaibaoviewselct();
            ListViewItem lvitem;
            int thanhtien = 0;
            if(arr_product.Count != 0)
            {
                foreach (Obj item in arr_product)
                {
                    lvitem = new ListViewItem();
                    int quantity = item.qty;
                    int tongcong = quantity * item.objProduct.price;
                    thanhtien += tongcong;
                    lvitem.ImageKey = "product_"+item.objProduct.id.ToString();
                    lvitem.SubItems.Add(item.objProduct.productname);
                    lvitem.SubItems.Add(quantity.ToString());
                    lvitem.SubItems.Add(item.objProduct.price.ToString("0,0"));
                    lvitem.SubItems.Add(tongcong.ToString("0,0"));
                    listViewSelect.Items.Add(lvitem);
                }
            }
            if (arr_combo.Count != 0)
            {
                foreach (Obj item in arr_combo)
                {
                    lvitem = new ListViewItem();
                    int quantity = item.qty;
                    int tongcong = quantity * item.objCombo.total;
                    thanhtien += tongcong;
                    lvitem.ImageKey = "combo_"+item.objCombo.Id.ToString();
                    lvitem.SubItems.Add(item.objCombo.comboName);
                    lvitem.SubItems.Add(quantity.ToString());
                    lvitem.SubItems.Add(item.objCombo.total.ToString("0,0"));
                    lvitem.SubItems.Add(tongcong.ToString("0,0"));
                    listViewSelect.Items.Add(lvitem);
                }
            }
            txtThanhtien.Text = thanhtien.ToString("0,0");
        }
        private void loadkhaibaoviewselct()
        {
            listViewSelect.Clear();
            listViewSelect.View = View.Details;
            listViewSelect.FullRowSelect = true;
            listViewSelect.SmallImageList = imageListSelect;

            listViewSelect.Columns.Add("Ảnh", 80);
            listViewSelect.Columns.Add("Tên Hàng", 100);
            listViewSelect.Columns.Add("qty", 30);
            listViewSelect.Columns.Add("Đơn giá", 70);
            listViewSelect.Columns.Add("Tổng cộng", 70);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            LapDonHangBLL lapDonHangBLL = new LapDonHangBLL();
            if (check) // là combo
            {
                Obj obj = new Obj();
                obj.objCombo = lapDonHangBLL.GetCombo(id);
                if(arr_combo.Count != 0)
                {
                    foreach(Obj a in arr_combo)
                    {
                        if (a.objCombo.Id == id)
                        {
                            a.qty++;
                            flagfind = true;
                        }    
                    }
                    if(flagfind == false)
                    {
                        obj.qty = 1;
                        arr_combo.Add(obj);
                    }
                    flagfind = false;
                }
                else
                {
                    obj.qty = 1;
                    arr_combo.Add(obj);
                }    
            }
            else
            {
                Obj obj = new Obj();
                obj.objProduct = lapDonHangBLL.GetProduct(id); ;
                if (arr_product.Count != 0)
                {
                    foreach (Obj a in arr_product)
                    {
                        if (a.objProduct.id == id)
                        {
                            a.qty++;
                            flagfind = true;
                        }
                    }
                    if (flagfind == false)
                    {
                        obj.qty = 1;
                        arr_product.Add(obj);
                    }
                    flagfind = false;
                }
                else
                {
                    obj.qty = 1;
                    arr_product.Add(obj);
                }
            }
            LoadListViewSelect();
        }

        private void listView_select_click(object sender, EventArgs e)
        {
           key = listViewSelect.SelectedItems[0].ImageKey;
            btnGiamSl.Enabled = true;
        }

        private void btnGiamSl_Click(object sender, EventArgs e)
        {
            string[] s = key.Split('_');
            if(s[0].Equals("product"))
            {
                foreach(Obj item in arr_product)
                {
                    if(item.objProduct.id == int.Parse(s[1]))
                    {
                        item.qty--;
                        if (item.qty == 0)
                        {
                            arr_product.Remove(item);
                            break;
                        }    
                    }    
                }    
            }   
            else
            {
                foreach (Obj item in arr_combo)
                {
                    if (item.objCombo.Id == int.Parse(s[1]))
                    {
                        item.qty--;
                        if (item.qty == 0)
                        {
                            arr_combo.Remove(item);
                            break;
                        }
                    }
                }
            }
            LoadListViewSelect();
        }

        // == Khai báo 1 class để mã hóa JSON 
        public class Obj
        {
            public Product objProduct { get; set; }
            public Combo objCombo { get; set; }
            public int qty { get; set; }
        }
    }
}

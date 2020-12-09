using System;
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
    public partial class ComboProduct : Form
    {
        private int idcombo;
        private ImageList imageList;
        private string folder = @"E:\All\";
        private string path = "", fullpath = "", destpath = @"E:\All\";
        private bool flag = false, clickSearch = false;
        private int id = -1;
        public ComboProduct(int idcombo)
        {
            InitializeComponent();
            this.idcombo = idcombo;
        }
        private void LoadImage(DataTable dataTable)
        {
            ProductBLL productBLL = new ProductBLL();
            imageList = new ImageList() { ImageSize = new Size(70, 70) };
            foreach (DataRow row in dataTable.Rows)
            {
                imageList.Images.Add(row.Field<int>("Id").ToString(), new Bitmap(folder + row.Field<string>("Image")));
            }
        }
        private void LoadListview()
        {
            ProductBLL productBLL = new ProductBLL();
            DataTable dataTable;
                dataTable = productBLL.GetAllProduct();
            LoadImage(dataTable);
            listViewProduct.Clear();
            listViewProduct.View = View.Details;
            listViewProduct.FullRowSelect = true;
            listViewProduct.SmallImageList = imageList;

            listViewProduct.Columns.Add("Hình ảnh", 70);
            listViewProduct.Columns.Add("Tên sản phẩm", 100);
            listViewProduct.Columns.Add("Loại sản phẩm", 70);
            listViewProduct.Columns.Add("Taxonomy", 70);
            listViewProduct.Columns.Add("Số lượng");
            listViewProduct.Columns.Add("Giá tiền");

            ListViewItem lvitem;
            foreach (DataRow row in dataTable.Rows)
            {
                lvitem = new ListViewItem();
                lvitem.ImageKey = row.Field<int>("Id").ToString();
                lvitem.SubItems.Add(row.Field<string>("Productname"));
                lvitem.SubItems.Add(row.Field<string>("TypeName"));
                lvitem.SubItems.Add(row.Field<string>("CategoryName"));
                lvitem.SubItems.Add(row.Field<int>("Amount").ToString());
                lvitem.SubItems.Add(row.Field<int>("Price").ToString());
                listViewProduct.Items.Add(lvitem);
            }
        }
    }
}

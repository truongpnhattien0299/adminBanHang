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

namespace AdminBanHang.GUI
{
    public partial class QuanlyProduct : Form
    {
        public QuanlyProduct()
        {
            InitializeComponent();
            LoadListview();
        }
        ImageList imageList;
        string folder = @"E:\All\";
        private void LoadImage()
        {
            ProductBLL productBLL = new ProductBLL();
            imageList = new ImageList() { ImageSize = new Size(70, 70) };
            foreach (DataRow row in productBLL.GetAllProduct().Rows)
            {
                imageList.Images.Add(row.Field<int>("Id").ToString(), new Bitmap(folder + row.Field<string>("Image")));
            }
        }
        private void LoadListview()
        {
            LoadImage();
            ProductBLL productBLL = new ProductBLL();

            listViewProduct.View = View.Details;
            listViewProduct.SmallImageList = imageList;

            listViewProduct.Columns.Add("Hình ảnh");
            listViewProduct.Columns.Add("Tên sản phẩm");
            listViewProduct.Columns.Add("Loại sản phẩm");
            listViewProduct.Columns.Add("Taxonomy");
            listViewProduct.Columns.Add("Số lượng");
            listViewProduct.Columns.Add("Giá tiền");
            listViewProduct.Columns.Add("Mô tả");

            listViewProduct.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewProduct.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            ListViewItem lvitem;
            int stt = 1;
            foreach (DataRow row in productBLL.GetAllProduct().Rows)
            {
                lvitem = new ListViewItem();
                lvitem.ImageKey = row.Field<int>("Id").ToString();
                lvitem.SubItems.Add( row.Field<string>("Productname"));
                lvitem.SubItems.Add(row.Field<string>("CategoryName"));
                lvitem.SubItems.Add(row.Field<string>("TaxonomyName"));
                lvitem.SubItems.Add(row.Field<int>("Amount").ToString());
                lvitem.SubItems.Add(row.Field<int>("Price").ToString());
                lvitem.SubItems.Add(row.Field<string>("Detail"));
                listViewProduct.Items.Add(lvitem);
                stt++;
            }    

        }
    }
}

﻿using System;
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
    public partial class ChooseProduct : Form
    {
        private ImageList imageList;
        private string folder = @"E:\All\";
        public ArrayList listProduct { get; set; }
        private int id;
        public ChooseProduct()
        {
            InitializeComponent();
            LoadListView();
        }
        public ChooseProduct(ArrayList list)
        {
            this.listProduct = list;
            InitializeComponent();
            LoadListView();
        }
        private void LoadImage(DataTable dataTable)
        {
            imageList = new ImageList() { ImageSize = new Size(70, 70) };
            foreach (DataRow row in dataTable.Rows)
            {
                imageList.Images.Add(row.Field<int>("Id").ToString(), new Bitmap(folder + row.Field<string>("Image")));
            }
        }
        public void LoadListView()
        {
            ProductBLL productBLL = new ProductBLL();
            DataTable dataTable;
            dataTable = productBLL.GetAllProduct();
            LoadImage(dataTable);
            listViewProduct.Clear();
            listViewProduct.View = View.Details;
            listViewProduct.CheckBoxes = true;
            listViewProduct.FullRowSelect = true;
            listViewProduct.SmallImageList = imageList;

            listViewProduct.Columns.Add("Hình ảnh", 70);
            listViewProduct.Columns.Add("Tên sản phẩm", 100);
            listViewProduct.Columns.Add("Loại sản phẩm", 70);
            listViewProduct.Columns.Add("Taxonomy", 70);
            listViewProduct.Columns.Add("Số lượng");
            listViewProduct.Columns.Add("Giá tiền");
            listViewProduct.Columns.Add("Mô tả", 200);

            ListViewItem lvitem;
            foreach (DataRow row in dataTable.Rows)
            {
                lvitem = new ListViewItem();
                lvitem.ImageKey = row.Field<int>("Id").ToString();
                if(listProduct != null)
                {
                    foreach(int a in listProduct)
                    {
                        if(int.Parse(lvitem.ImageKey) == a)
                        {
                            lvitem.Checked = true;
                            break;
                        }    
                    }    
                }    
                lvitem.SubItems.Add(row.Field<string>("Productname"));
                lvitem.SubItems.Add(row.Field<string>("TypeName"));
                lvitem.SubItems.Add(row.Field<string>("CategoryName"));
                lvitem.SubItems.Add(row.Field<int>("Amount").ToString());
                lvitem.SubItems.Add(row.Field<int>("Price").ToString());
                lvitem.SubItems.Add(row.Field<string>("Detail"));
                listViewProduct.Items.Add(lvitem);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ArrayList temp = new ArrayList();
            foreach(ListViewItem a in listViewProduct.CheckedItems)
            {
                temp.Add(int.Parse(a.ImageKey));
            }
            listProduct = temp;
        }
    }
}

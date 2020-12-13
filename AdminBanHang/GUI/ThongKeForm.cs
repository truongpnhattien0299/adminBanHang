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
    public partial class ThongKeForm : Form
    {
        private string folder = @"E\All";
        private ImageList imageList;
        private bool clickCheck = false;
        public ThongKeForm()
        {
            InitializeComponent();
            LoadListView();
        }
        private void LoadImage(DataTable dataTable)
        {
            ProductBLL productBLL = new ProductBLL();
            imageList = new ImageList() { ImageSize = new Size(120, 70) };
            foreach (DataRow row in dataTable.Rows)
            {
                imageList.Images.Add(row.Field<int>("Id").ToString(), new Bitmap(folder + row.Field<string>("Image")));
            }
        }
        private void LoadListView()
        {
            listViewData.Clear();
            listViewData.View = View.Details;
            listViewData.FullRowSelect = true;
            if (clickCheck)
            {
                listViewData.SmallImageList = imageList;
                //TKSP();
            }    
            else
                TKdoanhthu();
            
            
        }
        private void TKdoanhthu()
        {
            ThongkeBLL thongkeBLL = new ThongkeBLL();
            ArrayList arr = thongkeBLL.GetYear();
            listViewData.Columns.Add("Năm", 50);
            for (int i = 1; i <= 12; i++)
            {
                listViewData.Columns.Add("Tháng " + i, 80);
            }
            listViewData.Columns.Add("Doanh thu ", 80);
            ListViewItem lvitem;
            foreach (int row in arr)
            {
                lvitem = new ListViewItem();
                lvitem.Text = row.ToString();
                int doanhthu = 0;
                for (int i = 1; i <= 12; i++)
                {
                    lvitem.SubItems.Add(thongkeBLL.GetTotal(i, row).ToString("0,0"));
                    doanhthu += thongkeBLL.GetTotal(i, row);
                }
                lvitem.SubItems.Add(doanhthu.ToString("0,0"));
                listViewData.Items.Add(lvitem);
            }
        }
        //private void TKSP()
        //{
        //    ThongkeBLL thongkeBLL = new ThongkeBLL();
        //    ArrayList arr = thongkeBLL.GetYear();
        //    listViewData.Columns.Add("Ảnh", 50);
        //    listViewData.Columns.Add("Tên sản phẩm", 150);
        //    for(int i=1;i<=12;i++)
        //    {
        //        listViewData.Columns.Add("Tháng "+i, 50);
        //    }
        //    listViewData.Columns.Add("Doanh thu", 50);
        //    ListViewItem lvitem;
        //    ProductBLL productBLL = new ProductBLL();
        //    DataTable dt = productBLL.GetAllProduct();
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        lvitem = new ListViewItem();
        //        lvitem.ImageKey = row.Field<int>("Id").ToString();
        //        lvitem.SubItems.Add(row.Field<string>("ProductName"));
        //        //    int doanhthu = 0;
        //        for (int i = 1; i <= 12; i++)
        //        {
        //            lvitem.SubItems.Add(thongkeBLL.(i, row).ToString("0,0"));
        //            //doanhthu += thongkeBLL.GetTotal(i, row);
        //        }
        //        //    lvitem.SubItems.Add(doanhthu.ToString("0,0"));
        //        listViewData.Items.Add(lvitem);
        //    }
        //}
        private void TrendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clickCheck = true;
            LoadListView();
            clickCheck = false;
        }
    }
}

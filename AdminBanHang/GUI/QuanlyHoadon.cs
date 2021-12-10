using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using AdminBanHang.BLL;
using AdminBanHang.DAL;
using AdminBanHang.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AdminBanHang.GUI
{
    public partial class QuanlyHoadon : Form
    {
        private int id;
        private bool clickSearch = false;
        public QuanlyHoadon()
        {
            InitializeComponent();
            LoadListViewInvoice();
            comboBoxStatus.SelectedIndex = 0;
        }

        private void LoadListViewInvoice()
        {
            InvoiceBLL invoiceBLL = new InvoiceBLL();
            DataTable dataTable = null;
            if(clickSearch)
            {
                string status = "";
                int code = -1;
                if (!txtMadon.Text.Equals(""))
                    code = int.Parse(txtMadon.Text);
                string namecus = txtNameCus.Text;
                if (comboBoxStatus.SelectedItem.Equals("Đang giao hàng"))
                    status = "InComming";
                else if (comboBoxStatus.SelectedItem.Equals("Đã Thanh toán"))
                    status = "Done";
                else if (comboBoxStatus.SelectedItem.Equals("Hủy"))
                    status = "Cancel";

                dataTable = invoiceBLL.Search(status, code, namecus);
            }
            else
                dataTable = invoiceBLL.GetAllInvoice();

            listViewInvoice.Clear();
            listViewInvoice.View = View.Details;
            listViewInvoice.FullRowSelect = true;

            listViewInvoice.Columns.Add("#", 20);
            listViewInvoice.Columns.Add("Tên khách hàng", 100);
            listViewInvoice.Columns.Add("Số lượng", 20);
            listViewInvoice.Columns.Add("Tổng tiền", 70);
            listViewInvoice.Columns.Add("Ngày tạo", 70);
            listViewInvoice.Columns.Add("Mã bưu điện", 60);
            listViewInvoice.Columns.Add("Status", 60);
            listViewInvoice.Columns.Add("Ghi Chú", 200);
            listViewInvoice.Columns.Add("Địa chỉ giao hàng", 200);

            loadkhaibaoviewdetail();

            ListViewItem lvitem;
            foreach (DataRow row in dataTable.Rows)
            {
                lvitem = new ListViewItem();
                lvitem.Text = row.Field<int>("Id").ToString();
                string cusname = row.Field<string>("FirstName") +" "+ row.Field<string>("LastName");
                lvitem.SubItems.Add(cusname);
                lvitem.SubItems.Add(row.Field<string>("amount"));
                lvitem.SubItems.Add(int.Parse(row.Field<string>("TotalMoney")).ToString("0,0"));
                lvitem.SubItems.Add(row.Field<DateTime>("CreateDay").ToString());
                lvitem.SubItems.Add(row.Field<string>("Postcode"));
                lvitem.SubItems.Add(row.Field<string>("status"));
                lvitem.SubItems.Add(row.Field<string>("Ordernote"));
                lvitem.SubItems.Add(row.Field<string>("CustomerAddress"));

                listViewInvoice.Items.Add(lvitem);
            }
        }
        ImageList imageList;
        private void loadkhaibaoviewdetail()
        {
            listViewInvoiceDetail.Clear();
            listViewInvoiceDetail.View = View.Details;
            listViewInvoiceDetail.FullRowSelect = true;
            listViewInvoiceDetail.SmallImageList = imageList;

            listViewInvoiceDetail.Columns.Add("Ảnh", 80);
            listViewInvoiceDetail.Columns.Add("Tên Hàng", 100);
            listViewInvoiceDetail.Columns.Add("qty", 30);
            listViewInvoiceDetail.Columns.Add("Đơn giá", 70);
            listViewInvoiceDetail.Columns.Add("Tổng cộng", 70);
        }
        private void LoadImage(ArrayList arr_product, ArrayList arr_combo)
        {
            imageList = new ImageList() { ImageSize = new Size(70, 70) };
            if (arr_product != null)
            {
                foreach (Product row in arr_product)
                {
                    imageList.Images.Add(row.id.ToString(), new Bitmap(DBConnection.folder_product + row.image));
                }
            }
            if (arr_combo != null)
            {
                foreach (Combo row in arr_combo)
                {
                    imageList.Images.Add(row.Id.ToString(), new Bitmap(DBConnection.folder_combo + row.image));
                }
            }
        }
        private void listview_Invoice_click(object sender, EventArgs e)
        {
            id = int.Parse(listViewInvoice.SelectedItems[0].Text);
            InvoiceBLL invoiceBLL = new InvoiceBLL();
            DataTable dataTable = invoiceBLL.GetInvoiceDetail(id);
            string js_product = dataTable.Rows[0][2].ToString();
            string js_combo = dataTable.Rows[0][3].ToString();
            JArray rs_prd = (JArray)JsonConvert.DeserializeObject(js_product);
            JArray rs_combo = (JArray)JsonConvert.DeserializeObject(js_combo);
            ArrayList arr_product = new ArrayList();
            ArrayList arr_combo = new ArrayList();
            ListViewItem lvitem;
            if (rs_prd != null)
            {
                foreach (JObject obj in rs_prd)
                {
                    Product product = new Product();
                    product = obj["Product"].ToObject<Product>();
                    arr_product.Add(product);
                }
            }
            if (rs_combo != null)
            {
                foreach (JObject obj in rs_combo)
                {
                    Combo combo = new Combo();
                    combo = obj["Combo"].ToObject<Combo>();
                    arr_combo.Add(combo);
                }
            }
            LoadImage(arr_product, arr_combo);
            loadkhaibaoviewdetail();
            int thanhtien = 0;
            if (rs_prd != null)
            {
                foreach (JObject obj in rs_prd)
                {
                    Product product = new Product();
                    product = obj["Product"].ToObject<Product>();
                    lvitem = new ListViewItem();
                    int quantity = (int)obj["Quantity"];
                    int tongcong = quantity * product.price;
                    thanhtien += tongcong;
                    lvitem.ImageKey = product.id.ToString();
                    lvitem.SubItems.Add(product.productname);
                    lvitem.SubItems.Add(quantity.ToString());
                    lvitem.SubItems.Add(product.price.ToString("0,0"));
                    lvitem.SubItems.Add(tongcong.ToString("0,0"));
                    listViewInvoiceDetail.Items.Add(lvitem);
                }
            }
            if (rs_combo != null)
            {
                foreach (JObject obj in rs_combo)
                {
                    Combo combo = new Combo();
                    combo = obj["Combo"].ToObject<Combo>();
                    lvitem = new ListViewItem();
                    int quantity = (int)obj["Quantity"];
                    int tongcong = quantity * combo.total;
                    thanhtien += tongcong;
                    lvitem.ImageKey = combo.Id.ToString();
                    lvitem.SubItems.Add(combo.comboName);
                    lvitem.SubItems.Add(quantity.ToString());
                    lvitem.SubItems.Add(combo.total.ToString("0,0"));
                    lvitem.SubItems.Add(tongcong.ToString("0,0"));
                    listViewInvoiceDetail.Items.Add(lvitem);
                }
            }
            txtThanhtien.Text = thanhtien.ToString("0,0");
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            using (DialogChangeStatus dl = new DialogChangeStatus())
            {
                string status = "";
                DialogResult rs = dl.ShowDialog();
                if (rs == DialogResult.Yes)
                    status = "Incomming";
                else if (rs == DialogResult.OK)
                    status = "Done";
                else if (rs == DialogResult.No)
                    status = "Cancel";
                else return;
                InvoiceBLL invoiceBLL = new InvoiceBLL();
                invoiceBLL.UpdateStatus(id, status);
                LoadListViewInvoice();
            }    
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clickSearch = true;
            LoadListViewInvoice();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clickSearch = false;
            comboBoxStatus.SelectedIndex = 0;
            txtNameCus.Clear();
            txtMadon.Clear();
            LoadListViewInvoice();
        }
    }
}

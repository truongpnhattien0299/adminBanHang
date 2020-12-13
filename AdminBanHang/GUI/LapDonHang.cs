using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using AdminBanHang.BLL;
using AdminBanHang.DTO;
using Newtonsoft.Json;

namespace AdminBanHang.GUI
{
    public partial class LapDonHang : Form
    {
        private ImageList imageList, imageListSelect;
        private string folder_product = @"E:\All\";
        private string folder_combo = @"E:\All1\";
        private bool check = false; // cờ để kiểm tra list view đang show product( false ) hay combo ( true )
        private bool flagfind = false; // cờ để kiểm tra xem combo muốn thêm đã có trng danh sách chưa
        private bool clickSearch = false, newCus = false;
        private int id, idcus;
        private string key, firstname, lastname, phone, address;
        ArrayList arr_combo = new ArrayList();
        ArrayList arr_product = new ArrayList();
        public LapDonHang()
        {
            InitializeComponent();
            btnSanPham.Enabled = false;
            btnMove.Enabled = false;
            btnGiamSl.Enabled = false;
            btnAdd.Enabled = false;
            groupBoxCombo.Visible = false;
            LoadListViewProduct();
            LoadComboType();
        }
        private void LoadImage(DataTable dataTable, string folder, int width, int height)
        {
            imageList = new ImageList() { ImageSize = new Size(width, height) };
            foreach (DataRow row in dataTable.Rows)
            {
                imageList.Images.Add(row.Field<int>("Id").ToString(), new Bitmap(folder + row.Field<string>("Image")));
            }
        }
        private void LoadComboType()
        {
            ProductBLL productBLL = new ProductBLL();
            comboBoxType.DataSource = productBLL.GetAllType();
            comboBoxType.DisplayMember = "TypeName";
        }
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();
            Types types = (Types)comboBoxType.SelectedItem;
            comboBoxBrand.DataSource = productBLL.GetCategory(types.Id);
            comboBoxBrand.DisplayMember = "CategoryName";
        }
        private void LoadListViewProduct()
        {
            ProductBLL productBLL = new ProductBLL();
            DataTable dataTable;
            if (clickSearch)
            {
                Types idtype = (Types)comboBoxType.SelectedItem;
                Category idcate = (Category)comboBoxBrand.SelectedItem;
                string text = txtSearchProduct.Text;
                dataTable = productBLL.Search(idtype.Id, idcate.Id, text);
            }
            else
            {
                dataTable = productBLL.GetAllProduct();
            }
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
            if (clickSearch)
                dataTable = comboBLL.Search(dateStart.Value, dateEnd.Value, txtSeachCombo.Text);
            else
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
            groupBoxProduct.Visible = true;
            groupBoxCombo.Visible = false;
            btnSanPham.Enabled = false;
            btnCombo.Enabled = true;
            btnMove.Enabled = false;
            check = false;
        }
        private void btnCombo_Click(object sender, EventArgs e)
        {
            LoadListViewCombo();
            groupBoxCombo.Visible = true;
            groupBoxProduct.Visible = false;
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
                foreach (ObjProduct row in arr_product)
                {
                    imageListSelect.Images.Add("product_"+row.Product.id.ToString(), new Bitmap(folder + row.Product.image));
                }
            }
            if (arr_combo.Count != 0)
            {
                string folder = @"E:\All1\";
                foreach (ObjCombo row in arr_combo)
                {
                    imageListSelect.Images.Add("combo_"+row.Combo.Id.ToString(), new Bitmap(folder + row.Combo.image));
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
                foreach (ObjProduct item in arr_product)
                {
                    lvitem = new ListViewItem();
                    int quantity = item.Quantity;
                    int tongcong = quantity * item.Product.price;
                    thanhtien += tongcong;
                    lvitem.ImageKey = "product_"+item.Product.id.ToString();
                    lvitem.SubItems.Add(item.Product.productname);
                    lvitem.SubItems.Add(quantity.ToString());
                    lvitem.SubItems.Add(item.Product.price.ToString("0,0"));
                    lvitem.SubItems.Add(tongcong.ToString("0,0"));
                    listViewSelect.Items.Add(lvitem);
                }
            }
            if (arr_combo.Count != 0)
            {
                foreach (ObjCombo item in arr_combo)
                {
                    lvitem = new ListViewItem();
                    int quantity = item.Quantity;
                    int tongcong = quantity * item.Combo.total;
                    thanhtien += tongcong;
                    lvitem.ImageKey = "combo_"+item.Combo.Id.ToString();
                    lvitem.SubItems.Add(item.Combo.comboName);
                    lvitem.SubItems.Add(quantity.ToString());
                    lvitem.SubItems.Add(item.Combo.total.ToString("0,0"));
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
                ObjCombo obj = new ObjCombo();
                obj.Combo = lapDonHangBLL.GetCombo(id);
                if(arr_combo.Count != 0)
                {
                    foreach(ObjCombo a in arr_combo)
                    {
                        if (a.Combo.Id == id)
                        {
                            a.Quantity++;
                            flagfind = true;
                        }    
                    }
                    if(flagfind == false)
                    {
                        obj.Quantity = 1;
                        arr_combo.Add(obj);
                    }
                    flagfind = false;
                }
                else
                {
                    obj.Quantity = 1;
                    arr_combo.Add(obj);
                }    
            }
            else
            {
                ObjProduct obj = new ObjProduct();
                obj.Product = lapDonHangBLL.GetProduct(id); ;
                if (arr_product.Count != 0)
                {
                    foreach (ObjProduct a in arr_product)
                    {
                        if (a.Product.id == id)
                        {
                            a.Quantity++;
                            flagfind = true;
                        }
                    }
                    if (flagfind == false)
                    {
                        obj.Quantity = 1;
                        arr_product.Add(obj);
                    }
                    flagfind = false;
                }
                else
                {
                    obj.Quantity = 1;
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
        private void btnResetCombo_Click(object sender, EventArgs e)
        {
            LoadListViewCombo();
        }
        private void btnResetProduct_Click(object sender, EventArgs e)
        {
            LoadListViewProduct();
        }
        private void btnSearchCombo_Click(object sender, EventArgs e)
        {
            clickSearch = true;
            LoadListViewCombo();
            clickSearch = false;
        }
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            clickSearch = true;
            LoadListViewProduct();
            clickSearch = false;
        }
        private void btnGiamSl_Click(object sender, EventArgs e)
        {
            string[] s = key.Split('_');
            if(s[0].Equals("product"))
            {
                foreach(ObjProduct item in arr_product)
                {
                    if(item.Product.id == int.Parse(s[1]))
                    {
                        item.Quantity--;
                        if (item.Quantity == 0)
                        {
                            arr_product.Remove(item);
                            break;
                        }    
                    }    
                }    
            }   
            else
            {
                foreach (ObjCombo item in arr_combo)
                {
                    if (item.Combo.Id == int.Parse(s[1]))
                    {
                        item.Quantity--;
                        if (item.Quantity == 0)
                        {
                            arr_combo.Remove(item);
                            break;
                        }
                    }
                }
            }
            LoadListViewSelect();
        }
        private void btnKhach_Click(object sender, EventArgs e)
        {
            using (OldCustomer old = new OldCustomer())
            {
                DialogResult rs = old.ShowDialog();
                if(rs == DialogResult.Cancel)
                {
                    firstname = old.firstname;
                    lastname = old.lastname;
                    phone = old.phone;
                    address = old.address;
                    newCus = true;
                }    
                if(rs == DialogResult.OK)
                {
                    idcus = old.id;
                    address = old.address;
                    phone = old.phone;
                    newCus = false;
                }
                btnAdd.Enabled = true;
            }    
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            LapDonHangBLL donHangBLL = new LapDonHangBLL();
            if(newCus)
                donHangBLL.AddKhach(firstname, lastname, phone, address);
            int totalqty = 0;
            foreach(ObjCombo item in arr_combo)
            {
                totalqty += item.Quantity;
                ComboBLL comboBLL = new ComboBLL();
                ArrayList listid = comboBLL.ListIDProduct(item.Combo.Id);
                foreach(int a in listid)
                {
                    ProductBLL productBLL = new ProductBLL();
                    productBLL.EditProduct(item.Quantity, a);
                }    

            }    
            foreach(ObjProduct item in arr_product)
            {
                totalqty += item.Quantity;
                ProductBLL productBLL = new ProductBLL();
                productBLL.EditProduct(item.Quantity, item.Product.id);
            }
            Invoice invoice = new Invoice();
            if(newCus)
                invoice.customer_id = donHangBLL.getIdCustommer();
            else
                invoice.customer_id = idcus;
            invoice.customeraddress = address;
            invoice.totalmoney = txtThanhtien.Text.Replace(",","");
            invoice.amount = totalqty.ToString();
            invoice.creatday = DateTime.Now;
            invoice.ordernote = "123";
            invoice.postcode = "123";
            invoice.status = "Done";
            donHangBLL.AddInvoice(invoice);
            string products = "";
            if(arr_product.Count!=0)
                products = JsonConvert.SerializeObject(arr_product);
            string combos = "";
            if(arr_combo.Count != 0)
                combos = JsonConvert.SerializeObject(arr_combo);
            donHangBLL.AddInvoiceDetail(products, combos);
            LoadListViewSelect();
            arr_combo = new ArrayList();
            arr_product = new ArrayList();
            MessageBox.Show("Đã thêm đơn hàng thành công");
        }
        // == Khai báo 1 class để mã hóa JSON 
        public class ObjProduct
        {
            public Product Product { get; set; }
            public int Quantity { get; set; }
        }
        public class ObjCombo
        {
            public Combo Combo { get; set; }
            public int Quantity { get; set; }
        }
    }
}

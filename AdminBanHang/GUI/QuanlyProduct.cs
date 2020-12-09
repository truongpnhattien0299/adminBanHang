using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminBanHang.BLL;
using AdminBanHang.DTO;

namespace AdminBanHang.GUI
{
    public partial class QuanlyProduct : Form
    {
        private ImageList imageList;
        private string folder = @"E:\All\";
        private string path = "", fullpath = "", destpath = @"E:\All\";
        private bool flag = false;
        private int id = -1;
        public QuanlyProduct()
        {
            InitializeComponent();
            LoadListview();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            ProductBLL productBLL = new ProductBLL();
            category.DataSource = productBLL.GetAllCategory();
            category.DisplayMember = "CategoryName";
            comboSearch.DataSource = productBLL.GetAllCategory();
            comboSearch.DisplayMember = "CategoryName";
        }    
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
            listViewProduct.Clear();
            listViewProduct.View = View.Details;
            listViewProduct.FullRowSelect = true;
            listViewProduct.SmallImageList = imageList;

            listViewProduct.Columns.Add("Hình ảnh", 70);
            listViewProduct.Columns.Add("Tên sản phẩm",100);
            listViewProduct.Columns.Add("Loại sản phẩm",70);
            listViewProduct.Columns.Add("Taxonomy",70);
            listViewProduct.Columns.Add("Số lượng");
            listViewProduct.Columns.Add("Giá tiền");
            listViewProduct.Columns.Add("Mô tả",200);

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

        private void Click_listview(object sender, EventArgs e)
        {
            txtProductname.Text = listViewProduct.SelectedItems[0].SubItems[1].Text;
            category.Text = listViewProduct.SelectedItems[0].SubItems[2].Text;
            amount.Value = decimal.Parse(listViewProduct.SelectedItems[0].SubItems[4].Text);
            price.Value = decimal.Parse(listViewProduct.SelectedItems[0].SubItems[5].Text);
            txtDetail.Text = listViewProduct.SelectedItems[0].SubItems[6].Text;
            int idproduct = int.Parse(listViewProduct.SelectedItems[0].ImageKey);
            LoadPreviewImage(idproduct);
            id = idproduct;
        }

        private void LoadPreviewImage(int id)
        {
            ProductBLL productBLL = new ProductBLL();
            path = productBLL.pathImage(id);
            previewImage.Image = Image.FromFile(folder+path);
            previewImage.SizeMode = PictureBoxSizeMode.StretchImage;
            lblNameImage.Text = path;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = @"E:\";
            openFileDialog.Filter = "Select Valid Document (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            openFileDialog.FilterIndex = 1;
            try
            {
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog.CheckFileExists)
                    {
                        fullpath = openFileDialog.FileName;
                        path = openFileDialog.SafeFileName;
                        previewImage.Image = Image.FromFile(fullpath);
                        previewImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblNameImage.Text = path;
                        flag = true;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload Image.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();
            Product product = new Product();
            product.productname = txtProductname.Text;
            product.detail = txtDetail.Text;
            product.price = int.Parse(price.Value.ToString());
            product.amount = int.Parse(amount.Value.ToString());
            
            /* Lấy Id từ commobox đưa vào cơ sở dữ liệu */
            Category s = (Category)category.SelectedItem;
            product.categoryid = s.Id;

            /*Lấy Tên Ảnh đưa vào cơ sở dữ liệu*/
            product.image = path;
            File.Copy(fullpath, destpath+path);

            productBLL.AddProduct(product);
            LoadListview();
            flag = false;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();
            Product product = new Product();
            product.productname = txtProductname.Text;
            product.detail = txtDetail.Text;
            product.price = int.Parse(price.Value.ToString());
            product.amount = int.Parse(amount.Value.ToString());

            /* Lấy Id từ commobox đưa vào cơ sở dữ liệu */
            Category s = (Category)category.SelectedItem;
            product.categoryid = s.Id;

            /*Lấy Tên Ảnh đưa vào cơ sở dữ liệu*/
            product.image = path;
            if(flag) File.Copy(fullpath, destpath + path);

            productBLL.EditProduct(product, id);
            LoadListview();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();
            productBLL.DeleteProduct(id);
            txtProductname.Text = "";
            txtDetail.Text = "";
            amount.Value = 0;
            price.Value = 0;
            lblNameImage.Text = "Chưa có ảnh";
            previewImage.Image = null;
            LoadListview();
            flag = false;
        }
    }
}

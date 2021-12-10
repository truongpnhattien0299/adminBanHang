using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AdminBanHang.BLL;
using AdminBanHang.DAL;
using AdminBanHang.DTO;

namespace AdminBanHang.GUI
{
    public partial class QuanlyCombo : Form
    {
        private ImageList imageList;
        private string path = "", fullpath = "";
        private bool flag = false, clickSearch = false, flagimage = false;
        private int id = -1;
        private ArrayList list;
        private int total;
        public QuanlyCombo()
        {
            InitializeComponent();
            LoadListView();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        } 
        private void LoadImage(DataTable dataTable)
        {
            imageList = new ImageList() { ImageSize = new Size(120, 70) };
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine("Giảm giá");
                imageList.Images.Add(row.Field<int>("Id").ToString(), new Bitmap(DBConnection.folder_combo + row.Field<string>("Image")));
            }
        }
        public void LoadListView()
        {
            ComboBLL comboBLL = new ComboBLL();
            DataTable dataTable;
            if (clickSearch)
                dataTable = comboBLL.Search(dateSearchStart.Value, dateSearchEnd.Value, txtSearch.Text);
            else
                dataTable = comboBLL.GetAllCombo();
            LoadImage(dataTable);
            listViewCombo.Clear();
            listViewCombo.View = View.Details;
            listViewCombo.FullRowSelect = true;
            listViewCombo.SmallImageList = imageList;

            listViewCombo.Columns.Add("Hình ảnh", 120);
            listViewCombo.Columns.Add("Tên Combo", 80);
            listViewCombo.Columns.Add("Ngày bắt đầu", 140);
            listViewCombo.Columns.Add("Ngày kết thúc", 140);
            listViewCombo.Columns.Add("Total", 70);
            listViewCombo.Columns.Add("Giảm giá");

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
                listViewCombo.Items.Add(lvitem);
            }
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
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload Banner.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ComboBLL comboBLL = new ComboBLL();
            Combo combo = new Combo();
            try
            {
                if (flagimage && !File.Exists(DBConnection.folder_combo + path))
                    File.Copy(fullpath, DBConnection.folder_combo + path);
                flagimage = false;

                combo.comboName = txtComboName.Text;
                combo.dayStart = dayStart.Value;
                combo.dayEnd = dayEnd.Value;
                combo.discountMoney = numDiscount.Value.ToString();
                combo.total = total;

                /*Lấy Tên Ảnh đưa vào cơ sở dữ liệu*/
                combo.image = path;
                comboBLL.AddCombo(combo);
                ComboProduct comboProduct = new ComboProduct();
                foreach (int listidprouct in list)
                {
                    comboProduct.product_id = int.Parse(listidprouct.ToString());
                    comboBLL.AddComboProduct(comboProduct);
                }
                MessageBox.Show("Thêm Combo thành công", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                using (ChooseProduct cp = new ChooseProduct(list))
                {
                    if (cp.ShowDialog() == DialogResult.OK)
                        if (cp.listProduct.Count != 0)
                        {
                            list = cp.listProduct;
                            total = cp.total;
                            txtTotal.Text = total.ToString("0,0");
                            btnThem.Enabled = true;
                        }
                }
            }
            else
            {
                using (ChooseProduct cp = new ChooseProduct())
                {
                    if (cp.ShowDialog() == DialogResult.OK)
                        if (cp.listProduct.Count != 0)
                        {
                            list = cp.listProduct;
                            total = cp.total;
                            txtTotal.Text = total.ToString("0,0");
                            btnThem.Enabled = true;
                            flag = true;
                        }
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            clickSearch = false;
            LoadListView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ComboBLL comboBLL = new ComboBLL();
            string pathTemp = comboBLL.pathImage(id);
            try
            {
                comboBLL.DeleteCombo(id);
                MessageBox.Show("Xóa combo thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi xóa Combo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtComboName.Clear();
            txtTotal.Clear();
            numDiscount.Value = 0;
            dayStart.Value = DateTime.Now;
            dayEnd.Value = DateTime.Now;
            lblNameImage.Text = "Chưa có ảnh";
            previewImage.Image = null;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            LoadListView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clickSearch = true;
            LoadListView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ComboBLL comboBLL = new ComboBLL();
            Combo combo = new Combo();
            combo.comboName = txtComboName.Text;
            combo.dayStart = dayStart.Value;
            combo.dayEnd = dayEnd.Value;
            combo.discountMoney = numDiscount.Value.ToString();
            combo.total = int.Parse(txtTotal.Text.Replace(",",""));

            /*Lấy Tên Ảnh đưa vào cơ sở dữ liệu*/
            combo.image = path;

            try
            {
                if (flagimage && !File.Exists(DBConnection.folder_combo + path))
                    File.Copy(fullpath, DBConnection.folder_combo + path);
                flagimage = false;
                comboBLL.EditCombo(combo, id);
                comboBLL.EditComboProduct(list, id);
                MessageBox.Show("Sửa combo thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi sửa Combo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadListView();
        }
        
        private void listView_Click(object sender, EventArgs e)
        {
            flag = true;
            flagimage = true;
            ComboBLL comboBLL = new ComboBLL();
            txtComboName.Text = listViewCombo.SelectedItems[0].SubItems[1].Text;
            dayStart.Value = DateTime.Parse(listViewCombo.SelectedItems[0].SubItems[2].Text);
            dayEnd.Value = DateTime.Parse(listViewCombo.SelectedItems[0].SubItems[3].Text);
            numDiscount.Text = listViewCombo.SelectedItems[0].SubItems[5].Text;
            txtTotal.Text = listViewCombo.SelectedItems[0].SubItems[4].Text;
            total = int.Parse(txtTotal.Text.Replace(",",""));
            int idcombo = int.Parse(listViewCombo.SelectedItems[0].ImageKey);
            LoadPreviewImage(idcombo);
            id = idcombo;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            list = comboBLL.ListIDProduct(id);
        }

        private void LoadPreviewImage(int id)
        {
            ComboBLL comboBLL = new ComboBLL();
            path = comboBLL.pathImage(id);
            previewImage.Image = Image.FromFile(DBConnection.folder_combo + path);
            previewImage.SizeMode = PictureBoxSizeMode.StretchImage;
            lblNameImage.Text = path;
        }
    }
}

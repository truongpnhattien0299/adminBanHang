using System;
using System.Windows.Forms;

namespace AdminBanHang.GUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void nhaVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhanvien quanLyNhanvien = new QuanLyNhanvien();
            quanLyNhanvien.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanlyProduct quanlyProduct = new QuanlyProduct();
            quanlyProduct.Show();
        }

        private void comboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanlyCombo quanlyCombo = new QuanlyCombo();
            quanlyCombo.Show();
        }

        private void InvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanlyHoadon quanlyHoadon = new QuanlyHoadon();
            quanlyHoadon.Show();
        }
    }
}

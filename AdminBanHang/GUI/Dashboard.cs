using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}

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

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            QuanlyProduct quanlyProduct = new QuanlyProduct();
            quanlyProduct.Show();
        }

        private void btnQLCB_Click(object sender, EventArgs e)
        {
            QuanlyCombo quanlyCombo = new QuanlyCombo();
            quanlyCombo.Show();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {

        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            QuanLyNhanvien quanLyNhanvien = new QuanLyNhanvien();
            quanLyNhanvien.Show();
        }

        private void btnQLHĐ_Click(object sender, EventArgs e)
        {
            QuanlyHoadon quanlyHoadon = new QuanlyHoadon();
            quanlyHoadon.Show();
        }

        private void btnNewDH_Click(object sender, EventArgs e)
        {
            LapDonHang lapDonHang = new LapDonHang();
            lapDonHang.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKeForm thongKeForm = new ThongKeForm();
            thongKeForm.Show();
        }

        private void Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

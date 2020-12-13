using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminBanHang.BLL;
using AdminBanHang.DTO;

namespace AdminBanHang.GUI
{
    public partial class QuanLyKhachhang : Form
    {
        private int id;
        public QuanLyKhachhang()
        {
            InitializeComponent();
            Load_on();
        }

        private void Load_on()
        {
            CustomerBLL customerBLL = new CustomerBLL();
            GridViewNhanvien.DataSource = customerBLL.getAllCustomer();
        }

        private void ClickRow(object sender, DataGridViewCellEventArgs e)
        {
                DataGridViewRow row = GridViewNhanvien.Rows[e.RowIndex];
                id = int.Parse(row.Cells[0].Value.ToString());
            }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            CustomerBLL customerBLL = new CustomerBLL();
            if(id!=0)
                customerBLL.ChangeStatus(id);
            Load_on();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CustomerBLL customerBLL = new CustomerBLL();
            GridViewNhanvien.DataSource = customerBLL.Search(txtName.Text, txtPhone.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Load_on();
        }
    }
}

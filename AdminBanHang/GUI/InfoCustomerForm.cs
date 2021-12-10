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
    public partial class InfoCustomerForm : Form
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public InfoCustomerForm()
        {
            InitializeComponent();
            btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            firstname = txtFirstName.Text;
            lastname = txtLastname.Text;
            phone = txtPhone.Text;
            address = txtAddress.Text;
        }

        private void txtHochanged(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            if (txtFirstName.Text != "" && txtLastname.Text != "" && txtPhone.Text != "" && txtAddress.Text != "")
                btnSave.Enabled = true;
        }

        private void txtTenchanged(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            if (txtFirstName.Text != "" && txtLastname.Text != "" && txtPhone.Text != "" && txtAddress.Text != "")
                btnSave.Enabled = true;
        }

        private void txtPhoneChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            if (txtFirstName.Text != "" && txtLastname.Text != "" && txtPhone.Text != "" && txtAddress.Text != "")
                btnSave.Enabled = true;
        }

        private void txtAddresschanged(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            if (txtFirstName.Text != "" && txtLastname.Text != "" && txtPhone.Text != "" && txtAddress.Text != "")
                btnSave.Enabled = true;
        }
    }
}

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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            firstname = txtFirstName.Text;
            lastname = txtLastname.Text;
            phone = txtPhone.Text;
            address = txtAddress.Text;
        }
    }
}

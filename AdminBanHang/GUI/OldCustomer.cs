using System;
using System.Data;
using System.Windows.Forms;
using AdminBanHang.BLL;

namespace AdminBanHang.GUI
{
    public partial class OldCustomer : Form
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public int id { get; set; }
        private bool clickSearch = false;
        public OldCustomer()
        {
            InitializeComponent();
            btnSave.Enabled = false;
            LoadListViewCustomer();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (InfoCustomerForm info = new InfoCustomerForm())
            {
                if(info.ShowDialog() == DialogResult.OK)
                {
                    firstname = info.firstname;
                    lastname = info.lastname;
                    phone = info.phone;
                    address = info.address;
                    Close();
                }    
            }    
        }
        private void LoadListViewCustomer()
        {
            CustomerBLL customerBLL = new CustomerBLL();
            DataTable dataTable;
            if (clickSearch)
                dataTable = customerBLL.Search(txtNamecus.Text, txtPhone.Text);
            else
                dataTable = customerBLL.getAllCustomer();
            listViewCustomer.Clear();
            listViewCustomer.View = View.Details;
            listViewCustomer.FullRowSelect = true;

            listViewCustomer.Columns.Add("#", 40);
            listViewCustomer.Columns.Add("Username", 70);
            listViewCustomer.Columns.Add("Tên", 120);
            listViewCustomer.Columns.Add("Số điện thoại", 100);
            listViewCustomer.Columns.Add("Địa chỉ", 140);
            listViewCustomer.Columns.Add("Email", 70);

            ListViewItem lvitem;
            foreach (DataRow row in dataTable.Rows)
            {
                lvitem = new ListViewItem();
                lvitem.Text = row.Field<int>("Id").ToString();
                lvitem.SubItems.Add(row.Field<string>("UserName"));
                string name = row.Field<string>("LastName") + " " + row.Field<string>("FirstName");
                lvitem.SubItems.Add(name);
                lvitem.SubItems.Add(row.Field<string>("Phone"));
                lvitem.SubItems.Add(row.Field<string>("Address"));
                lvitem.SubItems.Add(row.Field<string>("Email"));
                listViewCustomer.Items.Add(lvitem);
            }
        }

        private void ListView_click(object sender, EventArgs e)
        {
            id = int.Parse(listViewCustomer.SelectedItems[0].Text);
            txtAddress.Text = listViewCustomer.SelectedItems[0].SubItems[4].Text;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            address = txtAddress.Text;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clickSearch = true;
            LoadListViewCustomer();
            clickSearch = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadListViewCustomer();
        }
    }
}

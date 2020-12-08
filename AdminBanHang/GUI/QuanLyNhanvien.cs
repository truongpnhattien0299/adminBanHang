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
    public partial class QuanLyNhanvien : Form
    {
        public QuanLyNhanvien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanvien_Load(object sender, EventArgs e)
        {
            Load_on();
        }

        private void Load_on()
        {
            EmployeeBLL employeeBLL = new EmployeeBLL();
            GridViewNhanvien.DataSource = employeeBLL.getAllEmployee();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EmployeeBLL employeeBLL = new EmployeeBLL();
            if (employeeBLL.Trung(txtUsername.Text))
            {
                MessageBox.Show("Username đã tồn tại vui lòng thử Username mới", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            Employee employee = new Employee();
            employee.username = txtUsername.Text;
            employee.firstname = txtFirstname.Text;
            employee.lastname = txtLastname.Text;
            employee.address = txtAddress.Text;
            employee.birthday = dob.Value;
            employee.joindate = joindate.Value;
            employee.gender = "Male";
            if (radioFemale.Checked)
                employee.gender = "Female";
            employee.role = 1;
            if (radioManager.Checked)
                employee.role = 2;
            employeeBLL.addEmployee(employee);
            Load_on();
        }

        private void ClickRow(object sender, DataGridViewCellEventArgs e)
        {
            int count = this.GridViewNhanvien.Rows.Count;
            if(e.RowIndex > -1 && e.RowIndex < count-1)
            {
                DataGridViewRow row = this.GridViewNhanvien.Rows[e.RowIndex];
                txtUsername.Text = row.Cells[1].Value.ToString();
                txtFirstname.Text = row.Cells[3].Value.ToString();
                txtLastname.Text = row.Cells[4].Value.ToString();
                string gender = row.Cells[5].Value.ToString();
                radioMale.Checked = true;
                if (gender.Equals("Female"))
                    radioFemale.Checked = true;
                dob.Value = (DateTime)row.Cells[6].Value;
                txtAddress.Text = row.Cells[7].Value.ToString();
                joindate.Value = (DateTime)row.Cells[8].Value;
                string role = row.Cells[9].Value.ToString();
                radioManager.Checked = true;
                if (role.Equals("1"))
                    radioAdmin.Checked = true;
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EmployeeBLL employeeBLL = new EmployeeBLL();
            Employee employee = new Employee();
            employee.firstname = txtFirstname.Text;
            employee.lastname = txtLastname.Text;
            employee.username = txtUsername.Text;
            employee.address = txtAddress.Text;
            employee.birthday = dob.Value;
            employee.joindate = joindate.Value;
            employee.gender = "Male";
            if (radioFemale.Checked)
                employee.gender = "Female";
            employee.role = 1;
            if (radioManager.Checked)
                employee.role = 2;
            employeeBLL.editEmployee(employee);
            Load_on();
        }
    }
}

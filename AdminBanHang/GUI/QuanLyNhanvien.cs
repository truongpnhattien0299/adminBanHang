using System;
using System.Windows.Forms;
using AdminBanHang.BLL;
using AdminBanHang.DTO;

namespace AdminBanHang.GUI
{
    public partial class QuanLyNhanvien : Form
    {
        private string username;
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
            try
            {
                GridViewNhanvien.DataSource = employeeBLL.getAllEmployee();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Database", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                employeeBLL.addEmployee(employee);
                MessageBox.Show("Đã thêm nhân viên thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm nhân viên KHÔNG thành công!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load_on();
        }
        private void ClickRow(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GridViewNhanvien.Rows[e.RowIndex];
            username = row.Cells[1].Value.ToString();
            txtUsername.Text = username;
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
            try
            {
                employeeBLL.editEmployee(employee);
                MessageBox.Show("Sửa nhân viên thành công", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa nhân viên KHÔNG thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load_on();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            EmployeeBLL employeeBLL = new EmployeeBLL();
            try
            {
                employeeBLL.ChangeStatus(username);
                MessageBox.Show("Cập nhật trạng thái thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật trạng thái KHÔNG thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load_on();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            EmployeeBLL employeeBLL = new EmployeeBLL();
            try
            {
                employeeBLL.ResetPass(username);
                MessageBox.Show("Đã cập nhật mật khẩu về mặc định", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật mật khẩu không thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load_on();
        }
    }
}

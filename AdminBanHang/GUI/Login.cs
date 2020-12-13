using System;
using System.Windows.Forms;
using AdminBanHang.BLL;
namespace AdminBanHang.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (!username.Equals("") && !password.Equals(""))
            {
                EmployeeBLL employeeBLL = new EmployeeBLL();
                if (employeeBLL.Login(username, password))
                {
                    Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
                else
                    MessageBox.Show("Username hoặc Password không đúng", "Đăng nhập không thành công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Username hoặc Password rỗng", "Error login", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
        }
    }
}

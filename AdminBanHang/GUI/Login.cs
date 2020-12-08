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
            //string username = txtUsername.Text;
            //string password = txtPassword.Text;
            string username = "admin";
            string password = "admin";
            EmployeeBLL employeeBLL = new EmployeeBLL();
            if(employeeBLL.Login(username, password))
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }    
        }
    }
}

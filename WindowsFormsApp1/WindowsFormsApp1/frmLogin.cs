using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }

        bool Login(string userName,string passWord)
        {

            return Account.Instance.Login(userName, passWord);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            string userName = txtTaiKhoan.Text;
            string passWord = txtMk.Text;
            if (Login(userName, passWord))
            {
                frmMain frmMain = new frmMain();
                this.Hide();
                frmMain.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
            txtTaiKhoan.Text = "";
            txtMk.Text = "";
            txtTaiKhoan.Focus();
        }
    }
}

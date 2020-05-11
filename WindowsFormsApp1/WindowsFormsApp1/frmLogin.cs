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
        private string Tentk;

        public string Tentk1 { get => Tentk; set => Tentk = value; }

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
                frmDoiMatKhau bangDiem = new frmDoiMatKhau();
                bangDiem.GetTenTk = userName;
                this.Hide();
                bangDiem.ShowDialog();

            }
            else
            {
                MessageBox.Show("sai ten tai khoan hoac mat khau!");
            }
            txtTaiKhoan.Text = "";
            txtMk.Text = "";
            txtTaiKhoan.Focus();
        }
    }
}

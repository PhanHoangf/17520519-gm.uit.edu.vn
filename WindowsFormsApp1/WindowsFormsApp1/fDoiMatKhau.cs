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
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class fDoiMatKhau : Form
    {
        private string getTenTk;
        public fDoiMatKhau()
        {
            InitializeComponent();
            

        }

        public string GetTenTk { get => getTenTk; set => getTenTk = value; }

        private void fDoiMatKhau_Load(object sender, EventArgs e)
        {
            txbTentk.Text = getTenTk;
        }

        public bool kiemtra(string tentk, string mkhientai,string kiemtramk,string matkhaumoi )
        {
            return Account.Instance.changePassWord(tentk, mkhientai, kiemtramk, matkhaumoi);
        }

        private string findMKbyTK(string a)
        {
            List<AccountDTO> accountList = Account.Instance.loadDSAccount();
            foreach(AccountDTO item in accountList)
            {
                if(item.TenTK==a)
                {
                    return item.MatKhau;
                }
            }
            return "-1";
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string tentk = txbTentk.Text;
            string mkhientai = txbMatKhauCu.Text;
            string xacnhanmkht = findMKbyTK(txbTentk.Text);
            string mkmoi = txbMatKhauMoi.Text;
            string xacnhanmk = txbXacNhanMk.Text;
            if(xacnhanmk != mkmoi)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!");
                txbMatKhauMoi.Focus();
                txbXacNhanMk.Text = "";
                txbMatKhauMoi.Text = "";
            }
            else if( mkmoi == "")
            {
                MessageBox.Show("Nhập khẩu đi nè :)");
                txbMatKhauMoi.Focus();
                txbXacNhanMk.Text = "";
                txbMatKhauMoi.Text = "";
            }
            //else if (xacnhanmk == "")
            //{
            //    MessageBox.Show("Chưa nhập lại mật khẩu kìa :)");
            //    txbMatKhauMoi.Focus();
            //    txbXacNhanMk.Text = "";
            //    txbMatKhauMoi.Text = "";
            //}    
            else
            {
                if (kiemtra(tentk, mkhientai, xacnhanmkht, mkmoi))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                }
                else MessageBox.Show("Opps! Wrong password");
            }
        }
    }
}

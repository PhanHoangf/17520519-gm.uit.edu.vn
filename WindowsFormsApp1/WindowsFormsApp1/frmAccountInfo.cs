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
    public partial class frmAccountInfo : Form
    {
            bool check = false;
            BindingSource AccountList = new BindingSource();
            public frmAccountInfo()
            {
                    InitializeComponent();
                    dtgvDanhSachTK.DataSource = AccountList;
                    loadDsTaiKhoan();
                    Binding();
                    btnMenu2.Visible = false;
                    visible(false);
                    pnMenu.Width = 50;
                    btnLuu.Enabled = false;
                    grbAccountInfo.Enabled = false;
           
            }

            #region HoverButton
            private void button1_MouseHover(object sender, EventArgs e)
            {
                button1.BackColor = Color.FromArgb(0, 99, 153);
            }

            private void button1_MouseLeave(object sender, EventArgs e)
            {
                button1.BackColor = Color.FromArgb(0, 151, 230);
            }


            private void BtnXoa_MouseHover(object sender, EventArgs e)
            {
                BtnXoa.BackColor = Color.FromArgb(0, 99, 153);
            }

            private void BtnXoa_MouseLeave(object sender, EventArgs e)
            {
                BtnXoa.BackColor = Color.FromArgb(0, 151, 230);
            }

            private void btnSua_MouseHover(object sender, EventArgs e)
            {
                btnSua.BackColor = Color.FromArgb(0, 99, 153);
            }

            private void btnSua_MouseLeave(object sender, EventArgs e)
            {
                btnSua.BackColor = Color.FromArgb(0, 151, 230);
            }

            private void btnLuu_MouseHover(object sender, EventArgs e)
            {
                btnLuu.BackColor = Color.FromArgb(0, 99, 153);
            }

            private void btnLuu_MouseLeave(object sender, EventArgs e)
            {
                btnLuu.BackColor = Color.FromArgb(0, 151, 230);
            }
            #endregion

            //Hiển thị danh sách các tài khoản
            public void loadDsTaiKhoan()
            {
                    string query = "SELECT *FROM TK";
                    AccountList.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }

            //Data Binding
            public void Binding()
            {
                    txbTenTaiKhoan.DataBindings.Add("Text", dtgvDanhSachTK.DataSource, "Tentk");
                    txbMatKhau.DataBindings.Add("Text", dtgvDanhSachTK.DataSource, "MatKhau");
                    cbLoaiTaiKhoan.DataBindings.Add("Text", dtgvDanhSachTK.DataSource, "Quyen");
            }

            private void button1_Click(object sender, EventArgs e)
            {
                    btnLuu.Enabled = true;
                    check = true;
                    grbAccountInfo.Enabled = true;
                    clear();
                    lblxacnhan.Visible = true;
                    txbXacNhanMK.Visible = true;
                    dtgvDanhSachTK.Enabled = false;
            }

            private bool checkMatKhau(string a, string b)
            {
                if(a==b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void clear()
            {
                    txbTenTaiKhoan.Clear();
                    txbMatKhau.Clear();
                    cbLoaiTaiKhoan.Text = "";
            }
        
            public void visible(bool a)
            {
                    lblMenu.Visible = a;
                    btnMenu.Visible = a;
                    btnSua.Visible = a;
                    BtnXoa.Visible = a;
                    btnLuu.Visible = a;
                    button1.Visible = a;
                    
                    btnMenu2.Visible = !a;
            }

            private void btnMenu_Click(object sender, EventArgs e)
            {
                    visible(false);    
                    pnMenu.Width = 50;
            }

            private void btnMenu2_Click(object sender, EventArgs e)
            {
                    visible(true);
                    pnMenu.Width = 160;
            }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tentk = txbTenTaiKhoan.Text;
            string matkhau = txbMatKhau.Text;
            int quyen = Convert.ToInt32(cbLoaiTaiKhoan.Text);
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            DialogResult result;
            if (checkMatKhau(txbMatKhau.Text, txbXacNhanMK.Text) == true)
            {
                if (check == true)
                {
                    result = MessageBox.Show(this, "Bạn muốn Thêm tài khoản này!", "Xác nhận", messageBoxButtons);
                    if (result == DialogResult.Yes)
                    {
                        if (Account.Instance.insertTaiKhoan(tentk, matkhau, quyen))
                        {
                            MessageBox.Show("Bạn đã thêm thành công!");
                        }
                        else MessageBox.Show("Thêm thất bại!");
                    }
                }
                else
                {
                    result = MessageBox.Show(this, "Bạn muốn cập nhật tài khoản này!", "Xác nhận", messageBoxButtons);
                    if (result == DialogResult.Yes)
                    {
                        if (Account.Instance.updateTaiKhoan(tentk, matkhau, quyen))
                        {
                            MessageBox.Show("Bạn đã Cập nhật thành công!");
                        }
                        else MessageBox.Show("cập nhật thất bại!");
                    }
                }
                lblxacnhan.Visible = false;
                txbXacNhanMK.Visible = false;
                loadDsTaiKhoan();
                btnLuu.Enabled = false;
                grbAccountInfo.Enabled = false;
                dtgvDanhSachTK.Enabled = true;
            }
            else MessageBox.Show("Mật khẩu chưa trùng khớp");
            
            
        }

            private void btnSua_Click(object sender, EventArgs e)
            {
                    check = false;
                    btnLuu.Enabled = true;
                    grbAccountInfo.Enabled = true;
                    lblxacnhan.Visible = true;
                    txbXacNhanMK.Visible = true;
            }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string tentk = txbTenTaiKhoan.Text;
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, "Bạn muốn xóa tài khoản này!", "Xác nhận", messageBoxButtons);
            if (result == DialogResult.Yes)
            {
                if (Account.Instance.deleteTaiKhoan(tentk))
                {
                    MessageBox.Show("Bạn đã xóa thành công!");
                }
                else MessageBox.Show("xóa thất bại!");
            }
            loadDsTaiKhoan();
        }
    }
}

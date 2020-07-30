using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        private string getTenTK;

        public string GetTenTK { get => getTenTK; set => getTenTK = value; }

        public frmMain()
        {
            InitializeComponent();
        }

        public void hienthi (Form form)
        {
            this.panel1.Controls.Clear();
            
            form.TopLevel = false;
            this.panel1.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        private void điểmTổngKếtHọcKìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            frmTongKetHocKi frmTongKetHocKi = new frmTongKetHocKi();
            frmTongKetHocKi.TopLevel = false;
            this.panel1.Controls.Add(frmTongKetHocKi);
            frmTongKetHocKi.FormBorderStyle = FormBorderStyle.None;
            frmTongKetHocKi.Dock = DockStyle.Fill;
            frmTongKetHocKi.Show();
        }

        private void điểmTrungBìnhMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            frmTongKetMon frmTongKetMon = new frmTongKetMon();
            frmTongKetMon.TopLevel = false;
            panel1.Controls.Add(frmTongKetMon);
            frmTongKetMon.FormBorderStyle = FormBorderStyle.None;
            frmTongKetMon.Dock = DockStyle.Fill;
            frmTongKetMon.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 17520519 - Phan Thanh Hoàng \r 17520202 - Nguyễn Trọng Tài");
        }

        private void tìmKiếmHSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            frmTimKiemHS frmTimKiemHS = new frmTimKiemHS();
            frmTimKiemHS.TopLevel = false;
            panel1.Controls.Add(frmTimKiemHS);
            frmTimKiemHS.FormBorderStyle = FormBorderStyle.None;
            frmTimKiemHS.Dock = DockStyle.Fill;
            frmTimKiemHS.Show();
        }

        private void quảnLíHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            frmHocSinh frmHocSinh = new frmHocSinh();
            frmHocSinh.TopLevel = false;
            panel1.Controls.Add(frmHocSinh);
            frmHocSinh.FormBorderStyle = FormBorderStyle.None;
            frmHocSinh.Dock = DockStyle.Fill;
            frmHocSinh.Show();
        }

        private void quảnLíBảngĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBangDiem frmBangDiem = new frmBangDiem();
            hienthi(frmBangDiem);
        }

        private void quảnLíLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
                quảnLíLớpHọcToolStripMenuItem.Enabled = true;
                frmLopHoc frmLopHoc = new frmLopHoc();
                hienthi(frmLopHoc);
            
        }

        private void quảnLíMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                quảnLíMônHọcToolStripMenuItem.Enabled = true;
                frmMonHoc frmMonHoc = new frmMonHoc();
                hienthi(frmMonHoc);
            
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frmDoiMatKhau = new frmDoiMatKhau();
            frmDoiMatKhau.GetTenTk = getTenTK;
            frmDoiMatKhau.ShowDialog();
        }

        private void quảnLíTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountInfo frmAccount = new frmAccountInfo();
            hienthi(frmAccount); 
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng nhập thành công!!!");
            if (GetTenTK == "admin")
            {
                quảnLíTàiKhoảnToolStripMenuItem.Enabled = true;
                quảnLíMônHọcToolStripMenuItem.Enabled = true;
                quảnLíLớpHọcToolStripMenuItem.Enabled = true;
                btnQuanLyTaiKhoan.Enabled = true;
                btnQuanLyMonHoc.Enabled = true;
                btnQuanLyLopHoc.Enabled = true;
            }
            else
            {
                quảnLíTàiKhoảnToolStripMenuItem.Enabled = false;
                quảnLíMônHọcToolStripMenuItem.Enabled = false;
                quảnLíLớpHọcToolStripMenuItem.Enabled = false;

                btnQuanLyTaiKhoan.Enabled = false;
                btnQuanLyTaiKhoan.BackgroundColor = Color.FromArgb(128, 128, 128);

                btnQuanLyMonHoc.Enabled = false;
                btnQuanLyMonHoc.BackgroundColor = Color.FromArgb(128, 128, 128);

                btnQuanLyLopHoc.Enabled = false;
                btnQuanLyLopHoc.BackgroundColor = Color.FromArgb(128, 128, 128);
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void btnQuanLyHocSinh_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            frmHocSinh frmHocSinh = new frmHocSinh();
            frmHocSinh.TopLevel = false;
            panel1.Controls.Add(frmHocSinh);
            frmHocSinh.FormBorderStyle = FormBorderStyle.None;
            frmHocSinh.Dock = DockStyle.Fill;
            frmHocSinh.Show();
        }

        private void btnQuanLyBangDiem_Click(object sender, EventArgs e)
        {
            frmBangDiem frmBangDiem = new frmBangDiem();
            hienthi(frmBangDiem);
        }

        private void btnQuanLyLopHoc_Click(object sender, EventArgs e)
        {
            quảnLíLớpHọcToolStripMenuItem.Enabled = true;
            frmLopHoc frmLopHoc = new frmLopHoc();
            hienthi(frmLopHoc);
        }

        private void btnQuanLyMonHoc_Click(object sender, EventArgs e)
        {
            quảnLíMônHọcToolStripMenuItem.Enabled = true;
            frmMonHoc frmMonHoc = new frmMonHoc();
            hienthi(frmMonHoc);
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            frmAccountInfo frmAccount = new frmAccountInfo();
            hienthi(frmAccount);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;
using System.Text.RegularExpressions;
using WindowsFormsApp1.BUS;
using System.Drawing.Design;
using System.Data.SqlTypes;

namespace WindowsFormsApp1
{
    public partial class frmHocSinh : Form
    {
        //Kiểm tra giá trị đầu vào
        public bool check(string hoten, string gioitinh, int namsinh, string diachi, string email)
        {
            bool kt=false;
            if(hoten=="")
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                txbHoTen.Focus();
                return kt;
            }
            if (gioitinh == "")
            {
                MessageBox.Show("Vui lòng xác nhận giới tính!");
                return kt;
            }
            if(Student_BUS.Instance1.checkAge(namsinh)==false)
            {
                MessageBox.Show("Năm sinh không hợp lệ!");
                return kt;
            }
            if (diachi == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!");
                txbDiaChi.Focus();
                return kt;
            }
            if(Student_BUS.Instance1.checkEmail(email)==false)
            {
                MessageBox.Show("Email phải có dạng abc@cda.com");
                txbEmail.Focus();
                return kt;
            }    
            return true;
        }

        public void enable_Button(bool a)
        {
            btnLuu.Enabled = a;
            if (btnLuu.Enabled == false)
            {
                btnLuu.BackgroundColor = Color.White;
            }
            else btnLuu.BackgroundColor = Color.FromArgb(79, 79, 79);
        }


        BindingSource StudentList = new BindingSource();
        public frmHocSinh()
        {

            InitializeComponent();
            
            LoadDanhSachHs();
            dtgvDanhSachHocSinh.DataSource = StudentList;
            AddHsBinding();
            LoadDanhSachLop();
            groupBox1.Enabled = false;
            enable_Button(false);
            btnLuuThemhs.Visible = false;
            btnHuy.Visible = false;
       
        }


        #region Method
        //Hiển thị danh sách học sinh trong lớp

        public void LoadDanhSachHs()
        {
            string query = "SELECT dshs.iDhocsinh, dshs.Hoten, l.Tenlop, dshs.Ngaysinh,dshs.Gioitinh,dshs.Diachi,dshs.Email FROM DSHocSinh as dshs,Lop as l where dshs.iDlop = l.iDlop ";
            StudentList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        public void AddHsBinding()
        {
            txbID.DataBindings.Add("Text", dtgvDanhSachHocSinh.DataSource, "iDhocsinh");
            txbHoTen.DataBindings.Add("Text", dtgvDanhSachHocSinh.DataSource, "Hoten");
            cbGioiTinh.DataBindings.Add("Text", dtgvDanhSachHocSinh.DataSource, "Gioitinh");
            dtpNgaySinh.DataBindings.Add("Value", dtgvDanhSachHocSinh.DataSource, "Ngaysinh");
            txbDiaChi.DataBindings.Add("Text", dtgvDanhSachHocSinh.DataSource, "Diachi");
            txbEmail.DataBindings.Add("Text", dtgvDanhSachHocSinh.DataSource, "Email");
            cbTenLop.DataBindings.Add("Text", dtgvDanhSachHocSinh.DataSource, "Tenlop");
        }

       
        public void LoadDanhSachLop() //add lớp vào combobox cbDanhSachLop
        {
            string query = "Select *from Lop";
            List<Classes> classesList = ClassDAO.Instance.LoadClassList(query);
            foreach( Classes item in classesList)
            {
                cbDanhSachLop.Items.Add(item.TenLop);
                cbTenLop.Items.Add(item.TenLop);
            }
            cbDanhSachLop.SelectedIndexChanged += CbDanhSachLop_SelectedIndexChanged;
        }
        public int findIndex(string a)
        {
            int index=-1;
            string query = "Select *from Lop";
            List<Classes> classesList = ClassDAO.Instance.LoadClassList(query);
            foreach (Classes item in classesList)
            {
                if (item.TenLop == a)
                {
                    index = item.ID;
                    return index;
                }
            }
            return index;
        }
        private void CbDanhSachLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHocSinhFromLop(cbDanhSachLop.Text);
            
        }

        public void LoadHocSinhFromLop(string tenlop)
        {
            string query = "SELECT dshs.iDhocsinh, dshs.Hoten, l.Tenlop, dshs.Ngaysinh,dshs.Gioitinh,dshs.Diachi,dshs.Email FROM DSHocSinh as dshs,Lop as l where dshs.iDlop = l.iDlop and l.Tenlop = '" + tenlop + "'";
            StudentList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        #endregion

        private void btnSua_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            enable_Button(true);
            txbID.Visible = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbID.Text);
            string hoten = txbHoTen.Text;
            string gioitinh = cbGioiTinh.Text.ToString();
            DateTime ngaysinh = dtpNgaySinh.Value;
            string diachi = txbDiaChi.Text;
            string email = txbEmail.Text;
            if (check(hoten, gioitinh, ngaysinh.Year, diachi, email) == false)
            {
                return;
            }
            else
            {
                if (StudentDAO.Instance.UpdateHocsinh(id, hoten, gioitinh, ngaysinh, diachi, email))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("có lỗi");
                }
                LoadDanhSachHs();
                enable_Button(false);
                groupBox1.Enabled = false;
                txbID.Visible = true;
            }
        }
        public void clear()
        {
            txbID.Clear();
            txbHoTen.Clear();
            txbDiaChi.Clear();
            txbEmail.Clear();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuuThemhs.Visible = true;
            groupBox1.Enabled = true;
            btnHuy.Visible = true;
            clear();
            txbID.Visible = false;
        }

        private void btnLuuThemhs_Click(object sender, EventArgs e)
        {
            int idlop = findIndex(cbTenLop.Text);
            string hoten = txbHoTen.Text;
            string gioitinh = cbGioiTinh.Text;
            DateTime ngaysinh = dtpNgaySinh.Value;
            string diachi = txbDiaChi.Text;
            string email = txbEmail.Text;
            if (check(hoten, gioitinh, ngaysinh.Year, diachi, email) == false)
            {
                return;
            }
            else
            {
                MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(this, "Bạn muốn Thêm học sinh này!", "Xác nhận", messageBoxButtons);
                if (result == DialogResult.Yes)
                {
                    if (StudentDAO.Instance.InsertHocsinh(idlop, hoten, gioitinh, ngaysinh, diachi, email))
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("có lỗi");
                    }
                }
                LoadDanhSachHs();
                groupBox1.Enabled = false;
                btnLuuThemhs.Visible = false;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int idhocsinh = Convert.ToInt32(txbID.Text);
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, "Bạn muốn xóa học sinh này!", "Xác nhận", messageBoxButtons);
            if (result == DialogResult.Yes)
            {
                if (StudentDAO.Instance.DeleteHocsinh(idhocsinh))
                    MessageBox.Show("Xóa thành công");
                else MessageBox.Show("Có lỗi khi xóa");
            }
            LoadDanhSachHs();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadDanhSachHs();
            groupBox1.Enabled = false;
            btnLuuThemhs.Visible = false;
            btnHuy.Visible = false;
            txbID.Visible = true;
            cbDanhSachLop.Text = "";
        }
    }
}

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

namespace WindowsFormsApp1
{
    public partial class fInfo : Form
    {
        #region get ID,ClassName
        private int ID;
        private string ClassName;
        public int ID1 {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }

        public static bool IsValidEmail(string email)
        {
            Regex rx = new Regex(
            @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
            if (rx.IsMatch(email) == true)
                return true;
            else return false;
        }

        public string ClassName1 { get => ClassName; set => ClassName = value; }
        #endregion

        BindingSource StudentList = new BindingSource();
        public fInfo()
        {

            InitializeComponent();
            
            LoadDanhSachHs();
            dtgvDanhSachHocSinh.DataSource = StudentList;
            AddHsBinding();
            LoadDanhSachLop();
            groupBox1.Enabled = false;
            btnLuu.Enabled = false;
            btnLuuThemhs.Visible = false;
            btnHuy.Visible = false;
        }


        #region Method
        //Lấy danh sách môn học
        public void Loadmonhoc()
        {
            string query = "select *from MonHoc";
            List<Subjects> subjectslist = SubjectDAO.Instance.loadSubjects(query);
          
            foreach (Subjects item in subjectslist)
  
            {
                RadioButton checkBox = new RadioButton() { Width = SubjectDAO.cbxwidth, Height = SubjectDAO.cbxheight };
                checkBox.Text = item.TenMon;
                //checkBox.CheckedChanged += CheckBox_CheckedChanged;
                checkBox.Tag = item;
                //checkBox.CheckStateChanged += CheckBox_CheckStateChanged;
                //flpmonhoc.Controls.Add(checkBox);
                
            }      
        }

      
   
   
        //Hiển thị bảng điểm
        public void loadBangdiem(int idmonhoc)
        {

            string query = "select hs.Hoten,bd.idmonhoc,bd.Diem15p,bd.Diem1t,bd.HK,(bd.Diem15p+bd.Diem1t*2+bd.HK*3)/6"+" Diemtbm "+" from BangDiemMon as bd, DSHocSinh as hs where bd.idlop=" + ID1 + " and bd.iDhocsinh=hs.iDhocsinh and bd.idmonhoc=" + idmonhoc + "";
            //dtvBangdiem.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }
        //Hiển thị danh sách học sinh trong lớp

        public void LoadDanhSachHs()
        {


            //string query = "select dshs.iDhocsinh, dshs.Hoten, l.Tenlop, dshs.Ngaysinh,dshs.Gioitinh,dshs.Diachi,dshs.Email,dshs.TBHKI,dshs.TBHKII  from DSHocSinh as dshs, Lop as l where dshs.iDlop = l.iDlop and l.iDlop =" + ID1 + "";
            string query = "SELECT dshs.iDhocsinh, dshs.Hoten, l.Tenlop, dshs.Ngaysinh,dshs.Gioitinh,dshs.Diachi,dshs.Email,dshs.TBHKI,dshs.TBHKII FROM DSHocSinh as dshs,Lop as l where dshs.iDlop = l.iDlop ";
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
            txbTBHKI.DataBindings.Add("Text", dtgvDanhSachHocSinh.DataSource, "TBHKI");
            txbTBHKII.DataBindings.Add("Text", dtgvDanhSachHocSinh.DataSource, "TBHKII");
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
            string query = "SELECT dshs.iDhocsinh, dshs.Hoten, l.Tenlop, dshs.Ngaysinh,dshs.Gioitinh,dshs.Diachi,dshs.Email,dshs.TBHKI,dshs.TBHKII FROM DSHocSinh as dshs,Lop as l where dshs.iDlop = l.iDlop and l.Tenlop = '" + tenlop + "'";
            StudentList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        #endregion

        #region Events

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void fInfo_Load(object sender, EventArgs e)
        {
            
           
            //Loadmonhoc();
            
            
        }

        


        #endregion

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbID.Text);
            string hoten = txbHoTen.Text;
            string gioitinh = cbGioiTinh.Text.ToString();
            DateTime ngaysinh = dtpNgaySinh.Value;
            string diachi = txbDiaChi.Text;
            string email = txbEmail.Text;

            if (StudentDAO.Instance.UpdateHocsinh(id, hoten, gioitinh, ngaysinh, diachi, email))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("có lỗi");
            }
            LoadDanhSachHs();
            btnLuu.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            int a = dateTimePicker1.Value.Year;
            textBox1.Text = (Student_BUS.Instance1.checkAge(a)).ToString();
        }


        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    int idhocsinh = Convert.ToInt32(txbid.Text);
        //    if(StudentDAO.Instance.DeleteHocsinh(idhocsinh))
        //    {
        //        MessageBox.Show("Xóa thành công!");
        //        LoadDanhSachHs();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Có lỗi khi xóa");
        //    }
        //}

        //private void btnCapNhat_Click(object sender, EventArgs e)
        //{
        //    int id = Convert.ToInt32(txbid.Text);
        //    string hoten = txbhoten.Text;
        //    string gioitinh = txbgioitinh.Text.ToString();
        //    DateTime ngaysinh = dtpNgaySinh.Value;
        //    string diachi = txbdiachi.Text;
        //    string email = txbemail.Text;

        //    if (StudentDAO.Instance.UpdateHocsinh(id, hoten, gioitinh, ngaysinh, diachi, email))
        //    {
        //        MessageBox.Show("Sửa thành công");
        //    }
        //    else
        //    {
        //        MessageBox.Show("có lỗi");
        //    }
        //    LoadDanhSachHs();
        //}
    }
}

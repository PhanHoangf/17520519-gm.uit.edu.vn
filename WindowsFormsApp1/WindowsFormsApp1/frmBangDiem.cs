using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;
using App = Microsoft.Office.Interop.Excel.Application;

namespace WindowsFormsApp1
{
    public partial class frmBangDiem : Form
    {
        BindingSource ListBangDiem = new BindingSource();
        private int SoLuongMon;

        public int SoLuongMon1 { get => SoLuongMon; set => SoLuongMon = value; }

        public frmBangDiem()
        {
            InitializeComponent();
            dtgvDanhSachDiem.DataSource = ListBangDiem;
            loadDanhSachDiem();
            //loadDanhSachHS();
            LoadDanhSachLop();
            LoadDanhSachMonHoc();
            dataBinding();
            btnLuu.Enabled = false;
            if (btnLuu.Enabled == false)
                btnLuu.BackgroundColor = Color.White;
           
            txbIdhocsinh.Enabled = false;
            txbTenHs.Enabled = false;
            groupBox4.Enabled = false;
            txbDiemtbm.Enabled = false;
        }


        #region Method


        public void loadDanhSachDiemFromLop(int idlop)
        {
            string query = "EXEC USP_DanhSachBangDiemTheoLop @MaLop = '"+ idlop +"'";
            ListBangDiem.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        public void loadDanhSachDiem()
        {
            string query = "exec USP_DanhSachDiemHienTai";
            ListBangDiem.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        //Add danh sach lop vao combobox
        public void LoadDanhSachLop()
        {
            string query = "SELECT *FROM Lop";
            List<Classes> classesList = ClassDAO.Instance.LoadClassList(query);
            foreach(Classes item in classesList)
            {
                cbDanhSachLop.Items.Add(item.TenLop);
            }
        }

        //Add danh sach mon hoc vao combobox
        public void LoadDanhSachMonHoc()
        {
            string query = "SELECT *FROM MonHoc";
            List<Subjects> subjectList = SubjectDAO.Instance.loadSubjects(query);
            foreach (Subjects item in subjectList)
            {
                cbDanhSachMon.Items.Add(item.TenMon);
            }
        }
        //tìm id lớp
        public int findIdLop(string a)
        {
            string query = "SELECT *FROM Lop";
            List<Classes> classesList = ClassDAO.Instance.LoadClassList(query);
            foreach (Classes item in classesList)
            {
                if (item.TenLop == a)
                {
                    return item.ID;
                }
            }
            return -1;
        }

        //tìm id học sinh
        public int findIdHocSinh(string a)
        {
            string query = "SELECT *FROM DSHocSinh";
            List<Student> studentList = StudentDAO.Instance.LoadHs(query);
            foreach(Student item in studentList)
            {
                if(item.Hoten==a)
                {
                    return item.IDhocsinh;
                }
            }
            return -1;
        }
        public int findIdMonHoc(string a)
        {
            string query = "SELECT *FROM MonHoc";
            List<Subjects> subjectList = SubjectDAO.Instance.loadSubjects(query);
            foreach (Subjects item in subjectList)
            {
                if (item.TenMon == a) { return item.ID; }
            }
            return -1;
        }
        public int GetDiemDat(string a)
        {
            string query = "SELECT *FROM MonHoc";
            List<Subjects> subjectList = SubjectDAO.Instance.loadSubjects(query);
            foreach (Subjects item in subjectList)
            {
                if (item.TenMon == a) { return item.DiemDat; }
            }
            return -1;
        }

        public void dataBinding()
        {
            txbIdhocsinh.DataBindings.Add("Text", dtgvDanhSachDiem.DataSource, "iDhocsinh");
            txbTenHs.DataBindings.Add("Text", dtgvDanhSachDiem.DataSource, "Hoten");
            txb15.DataBindings.Add("Text", dtgvDanhSachDiem.DataSource, "Diem15p");
            txb1t.DataBindings.Add("Text", dtgvDanhSachDiem.DataSource, "Diem1t");
            txbDiemhk.DataBindings.Add("Text", dtgvDanhSachDiem.DataSource, "HK");
            txbDiemtbm.DataBindings.Add("Text", dtgvDanhSachDiem.DataSource, "Diemtbm");
        }
        public void dataBindingDiem()
        {
            txb15.DataBindings.Add("Text", dtgvDanhSachDiem.DataSource, "Diem15p");
            txb1t.DataBindings.Add("Text", dtgvDanhSachDiem.DataSource, "Diem1t");
            txbDiemhk.DataBindings.Add("Text", dtgvDanhSachDiem.DataSource, "HK");
        }

        public bool checkInput(string idlop,string idmonhoc, string diem15p, string diem1t, string diemhk)
        {
            bool check = false;
            {
                if( idlop=="" )
                {
                    MessageBox.Show("Vui lòng chọn lớp!");
                    cbDanhSachLop.Focus();
                    return check;
                }
                if( idmonhoc=="" )
                {
                    MessageBox.Show("Vui lòng chọn môn học!");
                    cbDanhSachMon.Focus();
                    return check;
                }
                if( BangDiem_BUS.Instance.IsNumber(diem15p) == false)
                {
                    MessageBox.Show("Vui lòng Nhập điểm dạng số!");
                    txb15.Focus();
                    return check;
                }
                if (BangDiem_BUS.Instance.IsNumber(diem1t) == false)
                {
                    MessageBox.Show("Vui lòng Nhập điểm dạng số!");
                    txb1t.Focus();
                    return check;
                }
                if (BangDiem_BUS.Instance.IsNumber(diemhk) == false)
                {
                    MessageBox.Show("Vui lòng Nhập điểm dạng số!");
                    txbDiemhk.Focus();
                    return check;
                }
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
         public void loadDanhSachHS()
        {
            string query = "select iDhocsinh,iDlop,Hoten,Gioitinh from DSHocSinh";
            ListBangDiem.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        public void loadDanhSachHSfromidLop(int id)
        {
            string query = "select iDhocsinh,iDlop,Hoten,Gioitinh from DSHocSinh where iDlop = "+id+"";
            ListBangDiem.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        #endregion

        public void loadBangDiemByMonHoc(int idmonhoc, int hocki, int idlop)
        {
            string query = " Exec USP_DanhSachBangDiemByMonHoc @idmonhoc = "+idmonhoc+" , @hocki = "+hocki+" , @iDlop ="+idlop+" ";
            ListBangDiem.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { idmonhoc, hocki, idlop });
        }


        #region Event
        //private void cbDanhSachLop_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //loadDanhSachDiemFromLop(findIdLop(cbDanhSachLop.Text));
        //    loadDanhSachHSfromidLop(findIdLop(cbDanhSachLop.Text));
        //}


        private void btnNhapDiem_Click_1(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            enable_Button(true);
            groupBox4.Enabled = true;
        }


        private void btnRefesh_Click(object sender, EventArgs e)
        {
            loadDanhSachDiem();
            cbDanhSachLop.Text = "";
            enable_Button(false);
            groupBox4.Enabled = false;
            btnLuuCapNhat.Visible = false;
            btnSua.Visible = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkInput(cbDanhSachLop.Text, cbDanhSachMon.Text, txb15.Text, txb1t.Text, txbDiemhk.Text) == true)
            {
                int idhocsinh = Convert.ToInt32(txbIdhocsinh.Text);
                int idmon = findIdMonHoc(cbDanhSachMon.Text);
                int idlop = findIdLop(cbDanhSachLop.Text);
                float? diem15p = txb15.Text == "" ? (float?)null : float.Parse(txb15.Text);
                float? diem1t = txb1t.Text == "" ? (float?)null : float.Parse(txb1t.Text);
                float? diemhk = txbDiemhk.Text == "" ? (float?)null : float.Parse(txbDiemhk.Text);
                int hocki = Convert.ToInt32(cbHocki.Text);
                int diemdat = GetDiemDat(cbDanhSachMon.Text);
                SoLuongMon1 = BangDiem_BUS.Instance.SoLuongMon();
                if (BangdiemDAO.Instance.insertBangDiem(idhocsinh, idmon, idlop, diem15p, diem1t, diemhk, hocki,diemdat,6))
                {
                    MessageBox.Show("Nhập điểm thành công!");
                }
                else MessageBox.Show("Thêm thất bại!");
            }
            else return;
            loadBangDiemByMonHoc(findIdMonHoc(cbDanhSachMon.Text), Convert.ToInt32(cbHocki.Text), findIdLop(cbDanhSachLop.Text));
            enable_Button(false);
            groupBox4.Enabled = false;
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            bool kt;
            if (cbDanhSachLop.Text == "")
            {
                kt = false;
            }
            else kt = true;
            if (cbHocki.Text == "")
            {
                
                kt = false;
            }
            else kt = true;
            if (cbDanhSachMon.Text == "")
            {
                MessageBox.Show("Vui lòng chọn môn!");
                kt = false;
            }
            else kt = true;
            if (kt == true)
            { 
                loadBangDiemByMonHoc(findIdMonHoc(cbDanhSachMon.Text), Convert.ToInt32(cbHocki.Text), findIdLop(cbDanhSachLop.Text));
                //dataBindingDiem();
            }
            else { MessageBox.Show("Chưa nhập đủ dữ liệu"); return; }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
            btnLuuCapNhat.Visible = true;
            btnSua.Visible = false;
        }

        #endregion

        private void btnLuuCapNhat_Click(object sender, EventArgs e)
        {
            if (checkInput(cbDanhSachLop.Text, cbDanhSachMon.Text, txb15.Text, txb1t.Text, txbDiemhk.Text) == true)
            {
                int idhocsinh = Convert.ToInt32(txbIdhocsinh.Text);
                int idmon = findIdMonHoc(cbDanhSachMon.Text);
                int idlop = findIdLop(cbDanhSachLop.Text);
                float? diem15p = txb15.Text == "" ? (float?)null : float.Parse(txb15.Text);
                float? diem1t = txb1t.Text == "" ? (float?)null : float.Parse(txb1t.Text);
                float? diemhk = txbDiemhk.Text == "" ? (float?)null : float.Parse(txbDiemhk.Text);
                int diemdat = GetDiemDat(cbDanhSachMon.Text);
                int hocki = Convert.ToInt32(cbHocki.Text);
                SoLuongMon1 =  BangDiem_BUS.Instance.SoLuongMon();
                if (BangdiemDAO.Instance.updateBangDiem(idhocsinh,idmon,diem15p,diem1t,diemhk,hocki,diemdat,6))
                {
                    MessageBox.Show("Cập nhật điểm thành công!");
                }
                else MessageBox.Show("Cập nhật thất bại!");
            }
            else return;
            loadBangDiemByMonHoc(findIdMonHoc(cbDanhSachMon.Text), Convert.ToInt32(cbHocki.Text), findIdLop(cbDanhSachLop.Text));
            btnLuuCapNhat.Visible = false;
            btnSua.Visible = true;
            groupBox4.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int idhocsinh = Convert.ToInt32(txbIdhocsinh.Text);
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, "Bạn muốn xóa điểm học sinh này!", "Xác nhận", messageBoxButtons);
            if (result == DialogResult.Yes)
            {
                if (BangdiemDAO.Instance.deleteBangDiem(idhocsinh))
                    MessageBox.Show("Xóa thành công");
                else MessageBox.Show("Có lỗi khi xóa");
            }
            loadBangDiemByMonHoc(findIdMonHoc(cbDanhSachMon.Text), Convert.ToInt32(cbHocki.Text), findIdLop(cbDanhSachLop.Text));
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            int a = dtgvDanhSachDiem.RowCount - 1;
            string b = a.ToString();
            MessageBox.Show(b);
        }
    }
}

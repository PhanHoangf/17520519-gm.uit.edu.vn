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
    public partial class fBangDiem : Form
    {
        BindingSource ListBangDiem = new BindingSource();
        public fBangDiem()
        {
            InitializeComponent();
            dtgvDanhSachDiem.DataSource = ListBangDiem;
            loadDanhSachDiem();
            LoadDanhSachLop();
            LoadDanhSachMonHoc();
            dataBinding();
        }


        #region Method
        public void loadDanhSachDiemFromLop(int idlop)
        {
            string query = "EXEC USP_DanhSachBangDiemTheoLop @MaLop = '"+ idlop +"'";
            ListBangDiem.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        public void loadDanhSachDiem()
        {
            string query = "EXEC USP_DanhSachBangDiem";
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

        public void dataBinding()
        {
            txbIdhocsinh.DataBindings.Add("Text", dtgvDanhSachDiem.DataSource, "iDhocsinh");
            txbTenHs.DataBindings.Add("Text", dtgvDanhSachDiem.DataSource, "Hoten");
            txb15.DataBindings.Add("Text", dtgvDanhSachDiem.DataSource, "Diem15p");
            txb1t.DataBindings.Add("Text", dtgvDanhSachDiem.DataSource, "Diem1t");
            txbDiemhk.DataBindings.Add("Text", dtgvDanhSachDiem.DataSource, "HK");
        }

        #endregion


        #region Event
        private void cbDanhSachLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDanhSachDiemFromLop(findIdLop(cbDanhSachLop.Text));
        }


        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            int idhocsinh = Convert.ToInt32(txbIdhocsinh.Text);
            int idmon = findIdMonHoc(cbDanhSachMon.Text);
            int idlop = findIdLop(cbDanhSachLop.Text);
            float diem15p = float.Parse(txb15.Text);
            float diem1t = float.Parse(txb1t.Text);
            float diemhk = float.Parse(txbDiemhk.Text);
            int hocki = Convert.ToInt32(cbHocki.Text);
            if (BangdiemDAO.Instance.insertBangDiem(idhocsinh, idmon,idlop, diem15p, diem1t, diemhk, hocki))
            {
                MessageBox.Show("Nhập điểm thành công!");
            }
            else MessageBox.Show("Thêm thất bại!");
            loadDanhSachDiemFromLop(findIdLop(cbDanhSachLop.Text));

        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            loadDanhSachDiem();
            cbDanhSachLop.Text = "";
        }

        #endregion

      
    }
}

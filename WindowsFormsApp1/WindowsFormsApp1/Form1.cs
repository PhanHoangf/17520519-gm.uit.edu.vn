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

        public string ClassName1 { get => ClassName; set => ClassName = value; }
        #endregion

        BindingSource StudentList = new BindingSource();
        public fInfo()
        {

            InitializeComponent();
          

        }


        #region Method
        //Lấy danh sách môn học
        public void Loadmonhoc()
        {
            string query = "select *from MonHoc";
            List<Subjects> subjectslist = SubjectDAO.Instance.loadSubjects(query);
          
            foreach (Subjects item in subjectslist)
  
            {
                CheckBox checkBox = new CheckBox() { Width = SubjectDAO.cbxwidth, Height = SubjectDAO.cbxheight };
                checkBox.Text = item.TenMon;
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                checkBox.Tag = item;
                checkBox.CheckStateChanged += CheckBox_CheckStateChanged;
                flpmonhoc.Controls.Add(checkBox);
                
            }      
        }

      
   
   
        //Hiển thị bảng điểm
        public void loadBangdiem(int idmonhoc)
        {

            string query = "select hs.Hoten,bd.idmonhoc,bd.Diem15p,bd.Diem1t,bd.HK,(bd.Diem15p+bd.Diem1t*2+bd.HK*3)/6"+" Diemtbm "+" from BangDiemMon as bd, DSHocSinh as hs where bd.idlop=" + ID1 + " and bd.iDhocsinh=hs.iDhocsinh and bd.idmonhoc=" + idmonhoc + "";
            dtvBangdiem.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }
        //Hiển thị danh sách học sinh trong lớp
        public void LoadDanhSachHs()
        {
            
            string query = "select dshs.iDhocsinh, dshs.Hoten, l.Tenlop, dshs.Ngaysinh,dshs.Gioitinh,dshs.Diachi,dshs.Email,dshs.TBHKI,dshs.TBHKII  from DSHocSinh as dshs, Lop as l where dshs.iDlop = l.iDlop and l.iDlop =" + ID1 + "";
            StudentList.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }
        public void AddHsBinding()
        {
            txbid.DataBindings.Add("Text", dtgvDanhSachHs.DataSource, "iDhocsinh");
            txbhoten.DataBindings.Add("Text", dtgvDanhSachHs.DataSource, "Hoten");
            txbgioitinh.DataBindings.Add("Text", dtgvDanhSachHs.DataSource, "Gioitinh");
            dateTimePicker1.DataBindings.Add("Value", dtgvDanhSachHs.DataSource, "Ngaysinh");
            txbdiachi.DataBindings.Add("Text", dtgvDanhSachHs.DataSource, "Diachi");
            txbemail.DataBindings.Add("Text", dtgvDanhSachHs.DataSource, "Email");
            txbTBHK1.DataBindings.Add("Text", dtgvDanhSachHs.DataSource, "TBHKI");
            txbTBHK2.DataBindings.Add("Text", dtgvDanhSachHs.DataSource, "TBHKII");
        }
        #endregion

        #region Events
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }
        private void fInfo_Load(object sender, EventArgs e)
        {
            dtgvDanhSachHs.DataSource = StudentList;
            LoadDanhSachHs();
            txtTenLop.Text = ClassName1;
            txtTenlopdiem.Text = ClassName1;
            Loadmonhoc();
            AddHsBinding();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            
                int SubjectID = ((sender as CheckBox).Tag as Subjects).ID;
                loadBangdiem(SubjectID);
                if(CheckState.Unchecked==0)
                dtvBangdiem.Controls.Clear();

        }
        private void CheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            dtvBangdiem.Controls.Clear();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Inserths hs = new Inserths();
            hs.IDlop1 = ID1;
            hs.Show();
        }

        #endregion

        private void btnxem_Click(object sender, EventArgs e)
        {
            LoadDanhSachHs();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int idhocsinh = Convert.ToInt32(txbid.Text);
            if(StudentDAO.Instance.DeleteHocsinh(idhocsinh))
            {
                MessageBox.Show("Xóa thành công!");
                LoadDanhSachHs();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbid.Text);
            string hoten = txbhoten.Text;
            string gioitinh = txbgioitinh.Text.ToString();
            DateTime ngaysinh = dateTimePicker1.Value;
            string diachi = txbdiachi.Text;
            string email = txbemail.Text;

            if (StudentDAO.Instance.UpdateHocsinh(id, hoten, gioitinh, ngaysinh, diachi, email))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("có lỗi");
            }
            LoadDanhSachHs();
        }
    }
}

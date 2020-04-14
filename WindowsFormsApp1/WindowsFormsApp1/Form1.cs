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

            string query = "select hs.Hoten,bd.idmonhoc,bd.Diem15p,bd.Diem1t,bd.HK,bd.Diemtbm from BangDiemMon as bd, DSHocSinh as hs where bd.idlop=" + ID1 + " and bd.iDhocsinh=hs.iDhocsinh and bd.idmonhoc=" + idmonhoc + "";
            dtvBangdiem.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }
        //Hiển thị danh sách học sinh trong lớp
        public void LoadDanhSachHs()
        {
            
            string query = "select dshs.Hoten, l.Tenlop, dshs.Ngaysinh  from DSHocSinh as dshs, Lop as l where dshs.iDlop = l.iDlop and l.iDlop =" + ID1 + "";
            dtgvDanhSachHs.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }
        #endregion

        #region Events
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }
        private void fInfo_Load(object sender, EventArgs e)
        {
            LoadDanhSachHs();
            txtTenLop.Text = ClassName1;
            Loadmonhoc();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int SubjectID = ((sender as CheckBox).Tag as Subjects).ID;
            loadBangdiem(SubjectID);
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


    }
}

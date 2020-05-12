using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class frmTongKetMon : Form
    {
        public frmTongKetMon()
        {
            InitializeComponent();
            LoadTongKetMon();
            xuiCustomGroupbox1.Enabled = false;
            LoadDanhSachLop();
            LoadDanhSachMonHoc();
            lblSoDat.Visible = false;
        }

        public void LoadTongKetMon()
        {
            dtgvTongKetMon.DataSource = TongKetMonDAO.Instance.loadTongKetMon();
        }

        public void loadTongKetMonByID(int idlop,int idmonhoc)
        {
            dtgvTongKetMon.DataSource = TongKetMonDAO.Instance.loadTongKetMonbyID(idlop,idmonhoc);
        }

        public void LoadDanhSachLop()
        {
            string query = "SELECT *FROM Lop";
            List<Classes> classesList = ClassDAO.Instance.LoadClassList(query);
            foreach (Classes item in classesList)
            {
                cbDanhSachLop.Items.Add(item.TenLop);
            }
        }

        public void LoadDanhSachMonHoc()
        {
            string query = "SELECT *FROM MonHoc";
            List<Subjects> subjectList = SubjectDAO.Instance.loadSubjects(query);
            foreach (Subjects item in subjectList)
            {
                cbDanhSachMon.Items.Add(item.TenMon);
            }
        }

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

        public void loadPhieuTongKet(int lop,int hocki)
        {
            dtgvTongKetMon.DataSource = TongKetHocKiDAO.Instance.loadTongKetHocKi(lop, hocki);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            //loadTongKetMonByID(findIdLop(cbDanhSachLop.Text), findIdMonHoc(cbDanhSachMon.Text));
            //int a = TongKetMonDAO.Instance.countHsDat(findIdMonHoc(cbDanhSachMon.Text), findIdLop(cbDanhSachLop.Text));
            //lblSoDat.Text = a.ToString();
            //lblSoDat.Visible = true;
            try
            {
                loadPhieuTongKet(findIdLop(cbDanhSachLop.Text), Convert.ToInt32(cbHocKi.Text));
            }
            catch { }
        }
    }
}

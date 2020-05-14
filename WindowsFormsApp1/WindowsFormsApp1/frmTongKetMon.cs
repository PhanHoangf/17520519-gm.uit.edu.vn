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
using Application = Microsoft.Office.Interop.Excel.Application;

namespace WindowsFormsApp1
{
    public partial class frmTongKetMon : Form
    {
        public frmTongKetMon()
        {
            InitializeComponent();
            LoadTongKetMon();
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

        

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                loadTongKetMonByID(findIdLop(cbDanhSachLop.Text), findIdMonHoc(cbDanhSachMon.Text));
                int a = TongKetMonDAO.Instance.countHsDat(findIdMonHoc(cbDanhSachMon.Text), findIdLop(cbDanhSachLop.Text));
                lblSoDat.Text = a.ToString();
                lblSoDat.Visible = true;
            }
            catch { }
        }

        private void dtgvTongKetMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if(dtgvTongKetMon.Rows.Count > 0)
            {
                Application xcelApp = new Application();

                xcelApp.Workbooks.Add(Type.Missing);
                xcelApp.Cells[1, 2] = "BẢNG TÔNG KẾT MÔN HỌC";
                xcelApp.Cells[3, 2] = "Lớp: "+cbDanhSachLop.Text;
                xcelApp.Cells[4, 2] = "Môn học: "+cbDanhSachMon.Text;
                xcelApp.Cells[5, 2] = "Học kì: " + cbHocKi.Text;

                for(int i = 1; i < dtgvTongKetMon.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[8, i + 1] = dtgvTongKetMon.Columns[i - 1].HeaderText;
                }
                for(int i = 0; i < dtgvTongKetMon.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgvTongKetMon.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 9, j + 2] = dtgvTongKetMon.Rows[i].Cells[j].Value;
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
                //Định dạng font chữ
                xcelApp.Range["A1", "G100"].Font.Name = "Time New Roman";
                xcelApp.Range["B1"].Font.Bold = true;
                xcelApp.Range["B1"].Font.Size = 20;
                xcelApp.Range["B3", "B5"].Font.Size = 15;
                xcelApp.Range["A8", "G8"].Font.Bold = true;
                xcelApp.Range["A8", "G100"].Font.Size = 13;
                //Định dạng dòng text
                xcelApp.Range["C9", "G100"].HorizontalAlignment = 3;
                xcelApp.Range["C8", "G8"].ColumnWidth = 9;
                xcelApp.Range["B1", "E1"].MergeCells = true;
                xcelApp.Range["E8"].ColumnWidth = 13.45;
                //kẻ bảng
                xcelApp.Range["B8", "G" + (dtgvTongKetMon.Rows.Count + 7)].Borders.LineStyle = 1;

            }
        }
    }
}

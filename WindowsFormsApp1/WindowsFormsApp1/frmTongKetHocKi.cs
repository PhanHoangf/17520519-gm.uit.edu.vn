
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace WindowsFormsApp1
{
    public partial class frmTongKetHocKi : Form
    {
        public frmTongKetHocKi()
        {
            InitializeComponent();
            LoadDanhSachLop();
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
        public void LoadDanhSachLop()
        {
            string query = "SELECT *FROM Lop";
            List<Classes> classesList = ClassDAO.Instance.LoadClassList(query);
            foreach (Classes item in classesList)
            {
                cbDanhSachLop.Items.Add(item.TenLop);
            }
        }

        public void loadPhieuTongKet(int lop, int hocki)
        {
            dtgvTongKetHocKi.DataSource = TongKetHocKiDAO.Instance.loadTongKetHocKi(lop, hocki);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                loadPhieuTongKet(findIdLop(cbDanhSachLop.Text), Convert.ToInt32(cbHocKi.Text));
            }
            catch { }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dtgvTongKetHocKi.Rows.Count > 0)
            {
                Application xcelApp = new Application();

                xcelApp.Workbooks.Add(Type.Missing);
                xcelApp.Cells[1, 2] = "BẢNG TỔNG KẾT HỌC KÌ";
                xcelApp.Cells[3, 2] = "LỚP: " + cbDanhSachLop.Text;
                xcelApp.Cells[4, 2] = "HỌC KÌ: " + cbHocKi.Text;
                for(int i = 1; i < dtgvTongKetHocKi.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[7, i+1] = dtgvTongKetHocKi.Columns[i - 1].HeaderText;
                }
                for(int i=0; i < dtgvTongKetHocKi.Rows.Count; i++)
                {
                    for(int j = 0; j < dtgvTongKetHocKi.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 8, j + 2] = dtgvTongKetHocKi.Rows[i].Cells[j].Value;
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;


                //Định dạng font chữ:
                xcelApp.Range["A1", "C100"].Font.Name = "Times New Roman";
                xcelApp.Range["B1"].Font.Bold = true;
                xcelApp.Range["B1"].Font.Size = 20;
                xcelApp.Range["B3"].Font.Size = 15;
                xcelApp.Range["B4"].Font.Size = 15;
                xcelApp.Range["A7", "C7"].Font.Bold = true;
                xcelApp.Range["A7", "C100"].Font.Size = 13;
                //Định dạng dòng text:
                xcelApp.Range["C8", "C100"].HorizontalAlignment = 3;
                xcelApp.Range["C7", "C100"].ColumnWidth = 8.25;
                xcelApp.Range["B1", "E1"].MergeCells = true;
                //Kẻ bảng:
                xcelApp.Range["B7", "C"+(dtgvTongKetHocKi.Rows.Count+7)].Borders.LineStyle = 1;
            }
        }
    }
}

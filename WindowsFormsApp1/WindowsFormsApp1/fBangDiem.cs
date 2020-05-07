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
        #endregion


        #region Event
        private void cbDanhSachLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDanhSachDiemFromLop(findIdLop(cbDanhSachLop.Text));
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {

        }

       

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            loadDanhSachDiem();
            cbDanhSachLop.Text = "";
        }
        #endregion
    }
}

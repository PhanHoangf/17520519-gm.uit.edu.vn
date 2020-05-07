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

namespace WindowsFormsApp1
{
    public partial class fMonHoc : Form
    {
        BindingSource SubjectList = new BindingSource();
        bool flag;
        public fMonHoc()
        {
            InitializeComponent();
            dtgvdanhsachmon.DataSource = SubjectList;
            loadDanhSachMonHoc();
            Databinding();
            txbIdMon.Enabled = false;
            txbSearchBox.Enabled = false;
            enable(false);
            flag = false;
        }

        public void enable(bool a)
        {
            txbDiemDat.Enabled = a;
            txbTenMon.Enabled = a;
        }
        public void loadDanhSachMonHoc()
        {
            string query = "SELECT *FROM MonHoc";
            SubjectList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        
        public void Databinding()
        {
            txbTenMon.DataBindings.Add("Text", dtgvdanhsachmon.DataSource, "Tenmon");
            txbIdMon.DataBindings.Add("Text", dtgvdanhsachmon.DataSource, "iDmonhoc");
            txbDiemDat.DataBindings.Add("Text", dtgvdanhsachmon.DataSource, "DiemDat");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            enable(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIdMon.Text);
            string tenmon = txbTenMon.Text;
            float diemdat = float.Parse(txbDiemDat.Text);
            if (flag == true)
            {
                if (SubjectDAO.Instance.insertSubject( tenmon, diemdat))
                {
                    MessageBox.Show("Thêm thành công!");
                }
                else MessageBox.Show("Thất bại!");
            }
            else
            {
                if (SubjectDAO.Instance.updateSubject(id, tenmon, diemdat))
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else MessageBox.Show("Cập nhật thất bại!");   
            }
            enable(false);
            btnLuu.Enabled = false;
            loadDanhSachMonHoc();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDanhSachMonHoc();
            enable(false);
            btnLuu.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txbSearchBox.Enabled = true;
        }

        public void clear()
        {
            txbDiemDat.Clear();
            txbTenMon.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = true;
            enable(true);
            btnLuu.Enabled = true;
            clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIdMon.Text);
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, "Bạn muốn xóa môn này!", "Xác nhận!", messageBoxButtons);
            if(result==DialogResult.Yes)
            {
                if (SubjectDAO.Instance.deleteSubject(id))
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Có lỗi!");
                }
                loadDanhSachMonHoc();
            }    
            else
            {
                return;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(pnMenu.Width==45)
            {
                pnMenu.Width = 140;
            }
            else
            {
                pnMenu.Width = 45;
            }    
        }
    }
}

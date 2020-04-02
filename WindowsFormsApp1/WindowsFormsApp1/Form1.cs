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
    public partial class fInfo : Form
    {
        public fInfo()
        {
            InitializeComponent();
            LoadDanhSachHs();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            fGrade grade = new fGrade();
            grade.Show();
        }

        private void fInfo_Load(object sender, EventArgs e)
        {

        }
        public void LoadDanhSachHs()
        {
            
            fGrade grade = new fGrade();
            //lop = grade.getText();

            string query = "Select *from HocSinh ";

        

            dtgvDanhSachHs.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }
    }
}

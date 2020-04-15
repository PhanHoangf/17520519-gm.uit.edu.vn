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
    public partial class Inserths : Form
    {
        //Lấy ID lớp
        private int IDlop;
        public int IDlop1 { get => IDlop; set => IDlop = value; }

        public Inserths()
        {
            InitializeComponent();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
             this.Close();
        }
        //Thêm học sinh
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (IDlop1 == 1 || IDlop1==2 || IDlop1==3||IDlop1==4)
            {
                dateTimePicker1.MaxDate = new DateTime(2000,12,31);
                dateTimePicker1.MinDate = new DateTime(2004, 1, 1);
            }
            string hoten = txbhoten.Text;
            string gioitinh = txbgioitinh.Text.ToString();
            DateTime ngaysinh = dateTimePicker1.Value;
            string diachi = txbdiachi.Text;
            string email = txbemail.Text;

            if(StudentDAO.Instance.InsertHocsinh(IDlop1 , hoten, gioitinh, ngaysinh, diachi, email))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("có lỗi");
            }
            fInfo info = new fInfo();
            info.LoadDanhSachHs();
        }
        
        private void Inserths_Load(object sender, EventArgs e)
        {
            txbidlop.Text = IDlop1.ToString();
            
        }
    }
}

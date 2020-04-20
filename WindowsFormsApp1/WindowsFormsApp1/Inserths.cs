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
using System.Text.RegularExpressions;

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
        public static bool IsValidEmail(string email)
        {
            Regex rx = new Regex(
            @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
            return rx.IsMatch(email);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
             this.Close();
        }
        public bool valid(string hoten,string diachi,string email,string gioitinh)
        {
            if (hoten != "" && diachi != "" && email != "" && gioitinh != "")
                return true;
            else
                return false;
        }
       
        //Thêm học sinh
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (IDlop1 == 1 || IDlop1 == 2 || IDlop1 == 3 || IDlop1 == 4)
            {
                dateTimePicker1.MaxDate = new DateTime(2004, 12, 31);
                dateTimePicker1.MinDate = new DateTime(2000, 1, 1);
            }
            string hoten = txbhoten.Text;
            string gioitinh = txbgioitinh.Text.ToString();
            DateTime ngaysinh = dateTimePicker1.Value;
            string diachi = txbdiachi.Text;
            string email = txbemail.Text;

            if (txbhoten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên");
                txbhoten.Focus();
            }
            if (txbgioitinh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giới tính");
                txbgioitinh.Focus();
            }
            if (txbemail.Text == "")
            {
                txbemail.Focus();
            }
            if(txbemail.Text!="")
            {

                if (IsValidEmail(txbemail.Text) == false)
                {
                    MessageBox.Show("Vui lòng nhập email có định dạng abc@gmail.com");
                    txbemail.Text = "";
                    txbemail.Focus();

                }
               
            }
            if (valid(txbhoten.Text,txbdiachi.Text,txbemail.Text,txbgioitinh.Text) == true)
            {
                if (StudentDAO.Instance.InsertHocsinh(IDlop1, hoten, gioitinh, ngaysinh, diachi, email))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("có lỗi");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại!");
            }
        }
        
        private void Inserths_Load(object sender, EventArgs e)
        {
            txbidlop.Text = IDlop1.ToString();
            
        }
    }
}

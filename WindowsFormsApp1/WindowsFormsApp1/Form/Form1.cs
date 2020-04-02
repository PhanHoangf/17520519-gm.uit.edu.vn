using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn=new SqlConnection(ConnectionString.connect_string);
            string sqlSelect =" select * from TK where Tentk = '"+txtTk.Text+"' and MatKhau = '"+txtMk.Text+"'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read()==true)
            {
                MessageBox.Show("Đăng nhập thành công!");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
                txtTk.Text = "";
                txtMk.Text = "";
                txtTk.Focus();

            }
            
        }
    }
}

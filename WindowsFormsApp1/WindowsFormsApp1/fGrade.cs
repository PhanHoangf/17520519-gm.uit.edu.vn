using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class fGrade : Form
    {
        public fGrade()
        {
            InitializeComponent();
            loadClasslist();

            //Unable các textbox trước khi ấn vào nút sửa.
            unable();
            dtgvDanhSachLop.DataSource = classList;
            addLopBinding();
            grBoxThemLop.Visible = false;
          

        }
        //Tạo BindingSoure
        BindingSource classList = new BindingSource();
        public void loadClasslist()
        {
            string query = "select  *from Lop";
            classList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        public void addLopBinding()
        {
            txbId.DataBindings.Add("Text", dtgvDanhSachLop.DataSource, "iDlop");
            txbTenLop.DataBindings.Add("Text", dtgvDanhSachLop.DataSource, "Tenlop");
            txbSiso.DataBindings.Add("Text", dtgvDanhSachLop.DataSource, "Siso");
        }
        //-------------------------------------------------//
        //Enable và unable các textbox chỉnh sửa thông tin lớp
        public void enable()
        {
            txbSiso.Enabled = true;
            txbTenLop.Enabled = true;
            btnLuu.Enabled = true;
        }
        public void unable()
        {
            txbId.Enabled = false;
            txbSiso.Enabled = false;
            txbTenLop.Enabled = false;
            btnLuu.Enabled = false;
        }
        //------------------------------------------------//
        //-----------------------------------------------//
        //Clear các trường dữ liệu để thêm lớp
        public void clear()
        {
            enable();
            txbId.Text = "";
            txbSiso.Text = "";
            txbTenLop.Text = "";
            txbTenLop.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enable();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int idlop = Convert.ToInt32(txbId.Text);
            string tenlop = txbTenLop.Text;
            int Siso = Convert.ToInt32(txbSiso.Text);
            if (ClassDAO.Instance.UpdateClassList(idlop, tenlop, Siso))
            {
                MessageBox.Show("Bạn đã cập nhật thành công");
            }
            else MessageBox.Show("Cập nhật xảy ra lỗi");
            loadClasslist();
            unable();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            fGrade fGrade = new fGrade();
            fGrade.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            grBoxThemLop.Visible = true;
            
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            string tenlop = txbThemTenLop.Text;
            int siso = Convert.ToInt32(txbThemSiSoLop.Text);
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, "Bạn có thực sự muốn thêm lớp này!","Xác nhận", messageBoxButtons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
            MessageBoxOptions.RightAlign);
            if (result==DialogResult.Yes)
            {
                if (ClassDAO.Instance.InsertClass(tenlop, siso))
                {
                    MessageBox.Show("Bạn đã thêm thành công");
                }
                else MessageBox.Show("Thêm thất bại");
            }
            grBoxThemLop.Visible = false;
            loadClasslist();
        }

        private void btnHuyThemLop_Click(object sender, EventArgs e)
        {
            grBoxThemLop.Visible = false;
        }
        //#region Methods
        //void loadClasses10()
        //{
        //    string query = "Dslop10";
        //    List<Classes> classesList = ClassDAO.Instance.LoadClassList(query);

        //    foreach (Classes item in classesList)
        //    {
        //        Button btn = new Button() { Width = ClassDAO.btnWidth, Height = ClassDAO.btnHeight };
        //        btn.Text = item.TenLop;
        //        btn.Click += Btn_Click;
        //        btn.Tag = item;
        //        flpKhoi10.Controls.Add(btn);
        //    }
        //}



        //void loadClasses11()
        //{
        //    string query = "USP_Dslop11";
        //    List<Classes> classesList = ClassDAO.Instance.LoadClassList(query);

        //    foreach (Classes item in classesList)
        //    {
        //        Button btn = new Button() { Width = ClassDAO.btnWidth, Height = ClassDAO.btnHeight };
        //        btn.Text = item.TenLop;
        //        flpKhoi11.Controls.Add(btn);
        //        btn.Click += Btn_Click1;
        //        btn.Tag = item;
        //    }
        //}



        //void loadClasses12()
        //{
        //    string query = "USP_Dslop12";
        //    List<Classes> classesList = ClassDAO.Instance.LoadClassList(query);

        //    foreach (Classes item in classesList)
        //    {
        //        Button btn = new Button() { Width = ClassDAO.btnWidth, Height = ClassDAO.btnHeight };
        //        btn.Text = item.TenLop;
        //        btn.Tag = item;
        //        btn.Click += Btn_Click2;
        //        flpKhoi12.Controls.Add(btn);
        //    }
        //}





        //#endregion


        //#region Events
        ////Hiển thị ds lớp 12
        //private void Btn_Click2(object sender, EventArgs e)
        //{
        //    int ClassID = ((sender as Button).Tag as Classes).ID;
        //    string ClassName = ((sender as Button).Tag as Classes).TenLop;
        //    fInfo info = new fInfo();
        //    info.ID1 = ClassID;
        //    info.ClassName1 = ClassName;
        //    info.ShowDialog();
        //}
        ////Hiển thị ds lớp 11
        //private void Btn_Click1(object sender, EventArgs e)
        //{
        //    int ClassID = ((sender as Button).Tag as Classes).ID;
        //    string ClassName = ((sender as Button).Tag as Classes).TenLop;
        //    fInfo info = new fInfo();
        //    info.ID1 = ClassID;
        //    info.ClassName1 = ClassName;
        //    info.ShowDialog();
        //}
        ////Hiển thị ds lớp 10
        //private void Btn_Click(object sender, EventArgs e)
        //{
        //    int ClassID = ((sender as Button).Tag as Classes).ID;
        //    string ClassName = ((sender as Button).Tag as Classes).TenLop;
        //    fInfo info = new fInfo();
        //    info.ID1 = ClassID;
        //    info.ClassName1 = ClassName;
        //    info.ShowDialog();

        //}
        //private void btnQuay_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void btnXem_Click(object sender, EventArgs e)
        //{
        //    //fInfo info = new fInfo();
        //    //info.ShowDialog();
        //    //this.Hide();
        //}
        //#endregion


    }
}

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
    public partial class fGrade : Form
    {
        public fGrade()
        {
            InitializeComponent();
            loadClasses10();
            loadClasses11();
            loadClasses12();
        }



        #region Methods
        void loadClasses10()
        {
            string query = "Dslop10";
            List<Classes> classesList = ClassDAO.Instance.LoadClassList(query);

            foreach (Classes item in classesList)
            {
                Button btn = new Button() { Width = ClassDAO.btnWidth, Height = ClassDAO.btnHeight };
                btn.Text = item.TenLop;
                btn.Click += Btn_Click;
                btn.Tag = item;
                flpKhoi10.Controls.Add(btn);
            }
        }

       

        void loadClasses11()
        {
            string query = "USP_Dslop11";
            List<Classes> classesList = ClassDAO.Instance.LoadClassList(query);

            foreach (Classes item in classesList)
            {
                Button btn = new Button() { Width = ClassDAO.btnWidth, Height = ClassDAO.btnHeight };
                btn.Text = item.TenLop;
                flpKhoi11.Controls.Add(btn);
                btn.Click += Btn_Click1;
                btn.Tag = item;
            }
        }

        

        void loadClasses12()
        {
            string query = "USP_Dslop12";
            List<Classes> classesList = ClassDAO.Instance.LoadClassList(query);

            foreach (Classes item in classesList)
            {
                Button btn = new Button() { Width = ClassDAO.btnWidth, Height = ClassDAO.btnHeight };
                btn.Text = item.TenLop;
                btn.Tag = item;
                btn.Click += Btn_Click2;
                flpKhoi12.Controls.Add(btn);
            }
        }





        #endregion


        #region Events
        //Hiển thị ds lớp 12
        private void Btn_Click2(object sender, EventArgs e)
        {
            int ClassID = ((sender as Button).Tag as Classes).ID;
            string ClassName = ((sender as Button).Tag as Classes).TenLop;
            fInfo info = new fInfo();
            info.ID1 = ClassID;
            info.ClassName1 = ClassName;
            info.ShowDialog();
        }
        //Hiển thị ds lớp 11
        private void Btn_Click1(object sender, EventArgs e)
        {
            int ClassID = ((sender as Button).Tag as Classes).ID;
            string ClassName = ((sender as Button).Tag as Classes).TenLop;
            fInfo info = new fInfo();
            info.ID1 = ClassID;
            info.ClassName1 = ClassName;
            info.ShowDialog();
        }
        //Hiển thị ds lớp 10
        private void Btn_Click(object sender, EventArgs e)
        {
            int ClassID = ((sender as Button).Tag as Classes).ID;
            string ClassName = ((sender as Button).Tag as Classes).TenLop;
            fInfo info = new fInfo();
            info.ID1 = ClassID;
            info.ClassName1 = ClassName;
            info.ShowDialog();
           
        }
        private void btnQuay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            //fInfo info = new fInfo();
            //info.ShowDialog();
            //this.Hide();
        }
        #endregion

       
    }
}

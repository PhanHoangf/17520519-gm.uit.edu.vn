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
            string query = "USP_ClassList10";
            List<Classes> classesList = ClassDAO.Instance.LoadClassList(query);

            foreach (Classes item in classesList)
            {
                Button btn = new Button() { Width = ClassDAO.btnWidth, Height = ClassDAO.btnHeight };
                btn.Text = item.TenLop;
                flpKhoi10.Controls.Add(btn);
            }
        }
        void loadClasses11()
        {
            string query = "USP_ClassList11";
            List<Classes> classesList = ClassDAO.Instance.LoadClassList(query);

            foreach (Classes item in classesList)
            {
                Button btn = new Button() { Width = ClassDAO.btnWidth, Height = ClassDAO.btnHeight };
                btn.Text = item.TenLop;
                flpKhoi11.Controls.Add(btn);
            }
        }
        void loadClasses12()
        {
            string query = "USP_ClassList12";
            List<Classes> classesList = ClassDAO.Instance.LoadClassList(query);

            foreach (Classes item in classesList)
            {
                Button btn = new Button() { Width = ClassDAO.btnWidth, Height = ClassDAO.btnHeight };
                btn.Text = item.TenLop;
                flpKhoi12.Controls.Add(btn);
            }
        }
        #endregion


        #region Events
        private void btnQuay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            fInfo info = new fInfo();
            info.ShowDialog();
            this.Hide();
        }
        #endregion

       
    }
}

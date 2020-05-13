using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void điểmTổngKếtHọcKìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTongKetHocKi frmTongKet = new frmTongKetHocKi();
            frmTongKet.TopLevel = false;
            panel1.Controls.Add(frmTongKet);
            frmTongKet.FormBorderStyle = FormBorderStyle.None;
            frmTongKet.Dock = DockStyle.Fill;
            frmTongKet.Show(); 
        }

        private void điểmTrungBìnhMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTongKetMon frmTongKetMon = new frmTongKetMon();
            frmTongKetMon.TopLevel = false;
            panel1.Controls.Add(frmTongKetMon);
            frmTongKetMon.FormBorderStyle = FormBorderStyle.None;
            frmTongKetMon.Dock = DockStyle.Fill;
            frmTongKetMon.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 17520519 - Phan Thanh Hoàng \r 17520202 - Nguyễn Trọng Tài");
        }
    }
}

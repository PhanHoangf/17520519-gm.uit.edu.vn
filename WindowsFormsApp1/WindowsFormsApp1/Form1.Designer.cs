namespace WindowsFormsApp1
{
    partial class fInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageHocSinh = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblThongTinCaNhan = new System.Windows.Forms.Label();
            this.dtgvThongTin = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSiSo = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtgvDanhSachHs = new System.Windows.Forms.DataGridView();
            this.tabPageDiem = new System.Windows.Forms.TabPage();
            this.tabTongket1 = new System.Windows.Forms.TabPage();
            this.tabPageTongKet2 = new System.Windows.Forms.TabPage();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtSoHs = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageHocSinh.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTin)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHs)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageHocSinh);
            this.tabControl1.Controls.Add(this.tabPageDiem);
            this.tabControl1.Controls.Add(this.tabTongket1);
            this.tabControl1.Controls.Add(this.tabPageTongKet2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(921, 580);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageHocSinh
            // 
            this.tabPageHocSinh.Controls.Add(this.panel5);
            this.tabPageHocSinh.Controls.Add(this.panel3);
            this.tabPageHocSinh.Controls.Add(this.panel2);
            this.tabPageHocSinh.Controls.Add(this.panel1);
            this.tabPageHocSinh.Location = new System.Drawing.Point(4, 29);
            this.tabPageHocSinh.Name = "tabPageHocSinh";
            this.tabPageHocSinh.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHocSinh.Size = new System.Drawing.Size(913, 547);
            this.tabPageHocSinh.TabIndex = 0;
            this.tabPageHocSinh.Text = "Học sinh";
            this.tabPageHocSinh.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblThongTinCaNhan);
            this.panel5.Controls.Add(this.dtgvThongTin);
            this.panel5.Location = new System.Drawing.Point(582, 103);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(325, 206);
            this.panel5.TabIndex = 3;
            // 
            // lblThongTinCaNhan
            // 
            this.lblThongTinCaNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThongTinCaNhan.Location = new System.Drawing.Point(4, 9);
            this.lblThongTinCaNhan.Name = "lblThongTinCaNhan";
            this.lblThongTinCaNhan.Size = new System.Drawing.Size(318, 37);
            this.lblThongTinCaNhan.TabIndex = 1;
            this.lblThongTinCaNhan.Text = "Thông tin cá nhân";
            this.lblThongTinCaNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgvThongTin
            // 
            this.dtgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThongTin.Location = new System.Drawing.Point(4, 49);
            this.dtgvThongTin.Name = "dtgvThongTin";
            this.dtgvThongTin.RowTemplate.Height = 28;
            this.dtgvThongTin.Size = new System.Drawing.Size(318, 154);
            this.dtgvThongTin.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSoHs);
            this.panel3.Controls.Add(this.txtTenLop);
            this.panel3.Controls.Add(this.lblSiSo);
            this.panel3.Controls.Add(this.lblLop);
            this.panel3.Location = new System.Drawing.Point(582, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 89);
            this.panel3.TabIndex = 2;
            // 
            // lblSiSo
            // 
            this.lblSiSo.AutoSize = true;
            this.lblSiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSiSo.Location = new System.Drawing.Point(3, 52);
            this.lblSiSo.Name = "lblSiSo";
            this.lblSiSo.Size = new System.Drawing.Size(68, 25);
            this.lblSiSo.TabIndex = 1;
            this.lblSiSo.Text = "Sỉ số:";
            this.lblSiSo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLop.Location = new System.Drawing.Point(3, 8);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(55, 25);
            this.lblLop.TabIndex = 0;
            this.lblLop.Text = "Lớp:";
            this.lblLop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnCapNhat);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(582, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 226);
            this.panel2.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AutoSize = true;
            this.btnCapNhat.Location = new System.Drawing.Point(3, 152);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(155, 68);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(3, 78);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(155, 68);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(155, 68);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dtgvDanhSachHs);
            this.panel1.Location = new System.Drawing.Point(6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 534);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTimKiem);
            this.panel4.Controls.Add(this.btnTimKiem);
            this.panel4.Location = new System.Drawing.Point(4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(563, 43);
            this.panel4.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(409, 26);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.Location = new System.Drawing.Point(419, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(141, 30);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dtgvDanhSachHs
            // 
            this.dtgvDanhSachHs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachHs.Location = new System.Drawing.Point(3, 52);
            this.dtgvDanhSachHs.Name = "dtgvDanhSachHs";
            this.dtgvDanhSachHs.RowTemplate.Height = 28;
            this.dtgvDanhSachHs.Size = new System.Drawing.Size(564, 479);
            this.dtgvDanhSachHs.TabIndex = 0;
            // 
            // tabPageDiem
            // 
            this.tabPageDiem.Location = new System.Drawing.Point(4, 29);
            this.tabPageDiem.Name = "tabPageDiem";
            this.tabPageDiem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDiem.Size = new System.Drawing.Size(913, 547);
            this.tabPageDiem.TabIndex = 1;
            this.tabPageDiem.Text = "Điểm";
            this.tabPageDiem.UseVisualStyleBackColor = true;
            // 
            // tabTongket1
            // 
            this.tabTongket1.Location = new System.Drawing.Point(4, 29);
            this.tabTongket1.Name = "tabTongket1";
            this.tabTongket1.Padding = new System.Windows.Forms.Padding(3);
            this.tabTongket1.Size = new System.Drawing.Size(913, 547);
            this.tabTongket1.TabIndex = 2;
            this.tabTongket1.Text = "HKI";
            this.tabTongket1.UseVisualStyleBackColor = true;
            // 
            // tabPageTongKet2
            // 
            this.tabPageTongKet2.Location = new System.Drawing.Point(4, 29);
            this.tabPageTongKet2.Name = "tabPageTongKet2";
            this.tabPageTongKet2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTongKet2.Size = new System.Drawing.Size(913, 547);
            this.tabPageTongKet2.TabIndex = 3;
            this.tabPageTongKet2.Text = "HKII";
            this.tabPageTongKet2.UseVisualStyleBackColor = true;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Enabled = false;
            this.txtTenLop.Location = new System.Drawing.Point(77, 9);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(81, 26);
            this.txtTenLop.TabIndex = 2;
            this.txtTenLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSoHs
            // 
            this.txtSoHs.Enabled = false;
            this.txtSoHs.Location = new System.Drawing.Point(77, 51);
            this.txtSoHs.Name = "txtSoHs";
            this.txtSoHs.Size = new System.Drawing.Size(81, 26);
            this.txtSoHs.TabIndex = 3;
            this.txtSoHs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.Location = new System.Drawing.Point(164, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(155, 216);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // fInfo
            // 
            this.AcceptButton = this.btnTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 587);
            this.Controls.Add(this.tabControl1);
            this.Name = "fInfo";
            this.Text = "Danh Sách";
            this.Load += new System.EventHandler(this.fInfo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageHocSinh.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTin)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageHocSinh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvDanhSachHs;
        private System.Windows.Forms.TabPage tabPageDiem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TabPage tabTongket1;
        private System.Windows.Forms.TabPage tabPageTongKet2;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSiSo;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblThongTinCaNhan;
        private System.Windows.Forms.DataGridView dtgvThongTin;
        private System.Windows.Forms.TextBox txtSoHs;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Button btnThoat;
    }
}
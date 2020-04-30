namespace WindowsFormsApp1
{
    partial class fGrade
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
            this.lblDsKhoiLop = new System.Windows.Forms.Label();
            this.grBoxThongTinLop = new System.Windows.Forms.GroupBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbSiso = new System.Windows.Forms.TextBox();
            this.txbTenLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grBoxDsLop = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachLop = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.grBoxThemLop = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbThemTenLop = new System.Windows.Forms.TextBox();
            this.txbThemSiSoLop = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuyThemLop = new System.Windows.Forms.Button();
            this.grBoxThongTinLop.SuspendLayout();
            this.grBoxDsLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachLop)).BeginInit();
            this.grBoxThemLop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDsKhoiLop
            // 
            this.lblDsKhoiLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDsKhoiLop.AutoSize = true;
            this.lblDsKhoiLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDsKhoiLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDsKhoiLop.ForeColor = System.Drawing.Color.Red;
            this.lblDsKhoiLop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDsKhoiLop.Location = new System.Drawing.Point(209, 13);
            this.lblDsKhoiLop.Name = "lblDsKhoiLop";
            this.lblDsKhoiLop.Size = new System.Drawing.Size(372, 58);
            this.lblDsKhoiLop.TabIndex = 0;
            this.lblDsKhoiLop.Text = "Quản lí lớp học";
            this.lblDsKhoiLop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grBoxThongTinLop
            // 
            this.grBoxThongTinLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxThongTinLop.Controls.Add(this.grBoxThemLop);
            this.grBoxThongTinLop.Controls.Add(this.txbId);
            this.grBoxThongTinLop.Controls.Add(this.txbSiso);
            this.grBoxThongTinLop.Controls.Add(this.txbTenLop);
            this.grBoxThongTinLop.Controls.Add(this.label3);
            this.grBoxThongTinLop.Controls.Add(this.label2);
            this.grBoxThongTinLop.Controls.Add(this.label1);
            this.grBoxThongTinLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grBoxThongTinLop.Location = new System.Drawing.Point(12, 82);
            this.grBoxThongTinLop.Name = "grBoxThongTinLop";
            this.grBoxThongTinLop.Size = new System.Drawing.Size(304, 552);
            this.grBoxThongTinLop.TabIndex = 1;
            this.grBoxThongTinLop.TabStop = false;
            this.grBoxThongTinLop.Text = "Thông tin lớp";
            // 
            // txbId
            // 
            this.txbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbId.Location = new System.Drawing.Point(96, 64);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(173, 30);
            this.txbId.TabIndex = 5;
            // 
            // txbSiso
            // 
            this.txbSiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSiso.Location = new System.Drawing.Point(96, 159);
            this.txbSiso.Name = "txbSiso";
            this.txbSiso.Size = new System.Drawing.Size(173, 30);
            this.txbSiso.TabIndex = 4;
            // 
            // txbTenLop
            // 
            this.txbTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbTenLop.Location = new System.Drawing.Point(96, 109);
            this.txbTenLop.Name = "txbTenLop";
            this.txbTenLop.Size = new System.Drawing.Size(173, 30);
            this.txbTenLop.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(6, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sỉ số:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "iDlop:";
            // 
            // grBoxDsLop
            // 
            this.grBoxDsLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxDsLop.Controls.Add(this.dtgvDanhSachLop);
            this.grBoxDsLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grBoxDsLop.Location = new System.Drawing.Point(322, 82);
            this.grBoxDsLop.Name = "grBoxDsLop";
            this.grBoxDsLop.Size = new System.Drawing.Size(629, 552);
            this.grBoxDsLop.TabIndex = 2;
            this.grBoxDsLop.TabStop = false;
            this.grBoxDsLop.Text = "Danh sách lớp";
            // 
            // dtgvDanhSachLop
            // 
            this.dtgvDanhSachLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgvDanhSachLop.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvDanhSachLop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvDanhSachLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhSachLop.Location = new System.Drawing.Point(3, 35);
            this.dtgvDanhSachLop.Name = "dtgvDanhSachLop";
            this.dtgvDanhSachLop.RowHeadersWidth = 62;
            this.dtgvDanhSachLop.RowTemplate.Height = 28;
            this.dtgvDanhSachLop.Size = new System.Drawing.Size(623, 514);
            this.dtgvDanhSachLop.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(957, 207);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(179, 59);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(957, 297);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(181, 59);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(957, 385);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(181, 59);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(957, 541);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(181, 59);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Location = new System.Drawing.Point(957, 463);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(181, 59);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // grBoxThemLop
            // 
            this.grBoxThemLop.Controls.Add(this.btnHuyThemLop);
            this.grBoxThemLop.Controls.Add(this.btnXacNhan);
            this.grBoxThemLop.Controls.Add(this.txbThemSiSoLop);
            this.grBoxThemLop.Controls.Add(this.txbThemTenLop);
            this.grBoxThemLop.Controls.Add(this.label5);
            this.grBoxThemLop.Controls.Add(this.label4);
            this.grBoxThemLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grBoxThemLop.Location = new System.Drawing.Point(6, 64);
            this.grBoxThemLop.Name = "grBoxThemLop";
            this.grBoxThemLop.Size = new System.Drawing.Size(292, 210);
            this.grBoxThemLop.TabIndex = 6;
            this.grBoxThemLop.TabStop = false;
            this.grBoxThemLop.Text = "Nhập thông tin lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập tên lớp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhập sỉ số lớp:";
            // 
            // txbThemTenLop
            // 
            this.txbThemTenLop.Location = new System.Drawing.Point(164, 45);
            this.txbThemTenLop.Name = "txbThemTenLop";
            this.txbThemTenLop.Size = new System.Drawing.Size(122, 30);
            this.txbThemTenLop.TabIndex = 2;
            // 
            // txbThemSiSoLop
            // 
            this.txbThemSiSoLop.Location = new System.Drawing.Point(164, 95);
            this.txbThemSiSoLop.Name = "txbThemSiSoLop";
            this.txbThemSiSoLop.Size = new System.Drawing.Size(122, 30);
            this.txbThemSiSoLop.TabIndex = 3;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(13, 142);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(122, 52);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuyThemLop
            // 
            this.btnHuyThemLop.Location = new System.Drawing.Point(164, 142);
            this.btnHuyThemLop.Name = "btnHuyThemLop";
            this.btnHuyThemLop.Size = new System.Drawing.Size(122, 52);
            this.btnHuyThemLop.TabIndex = 5;
            this.btnHuyThemLop.Text = "Hủy";
            this.btnHuyThemLop.UseVisualStyleBackColor = true;
            this.btnHuyThemLop.Click += new System.EventHandler(this.btnHuyThemLop_Click);
            // 
            // fGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1151, 650);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grBoxDsLop);
            this.Controls.Add(this.grBoxThongTinLop);
            this.Controls.Add(this.lblDsKhoiLop);
            this.Name = "fGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade";
            this.grBoxThongTinLop.ResumeLayout(false);
            this.grBoxThongTinLop.PerformLayout();
            this.grBoxDsLop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachLop)).EndInit();
            this.grBoxThemLop.ResumeLayout(false);
            this.grBoxThemLop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDsKhoiLop;
        private System.Windows.Forms.GroupBox grBoxThongTinLop;
        private System.Windows.Forms.GroupBox grBoxDsLop;
        private System.Windows.Forms.DataGridView dtgvDanhSachLop;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.TextBox txbSiso;
        private System.Windows.Forms.TextBox txbTenLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox grBoxThemLop;
        private System.Windows.Forms.TextBox txbThemSiSoLop;
        private System.Windows.Forms.TextBox txbThemTenLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuyThemLop;
    }
}
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txbTBHKII = new System.Windows.Forms.TextBox();
            this.txbTBHKI = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDanhSachLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachHocSinh = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbTenLop = new System.Windows.Forms.ComboBox();
            this.btnLuuThemhs = new System.Windows.Forms.Button();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Thông Tin Học Sinh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnLuuThemhs);
            this.groupBox1.Controls.Add(this.cbTenLop);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.cbGioiTinh);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txbTBHKII);
            this.groupBox1.Controls.Add(this.txbTBHKI);
            this.groupBox1.Controls.Add(this.txbEmail);
            this.groupBox1.Controls.Add(this.txbDiaChi);
            this.groupBox1.Controls.Add(this.txbHoTen);
            this.groupBox1.Controls.Add(this.txbID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 564);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(117, 203);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(209, 30);
            this.dtpNgaySinh.TabIndex = 17;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(117, 153);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(209, 33);
            this.cbGioiTinh.TabIndex = 16;
            // 
            // txbTBHKII
            // 
            this.txbTBHKII.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbTBHKII.Location = new System.Drawing.Point(117, 468);
            this.txbTBHKII.Name = "txbTBHKII";
            this.txbTBHKII.Size = new System.Drawing.Size(209, 30);
            this.txbTBHKII.TabIndex = 15;
            // 
            // txbTBHKI
            // 
            this.txbTBHKI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbTBHKI.Location = new System.Drawing.Point(117, 420);
            this.txbTBHKI.Name = "txbTBHKI";
            this.txbTBHKI.Size = new System.Drawing.Size(209, 30);
            this.txbTBHKI.TabIndex = 14;
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbEmail.Location = new System.Drawing.Point(117, 303);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(209, 30);
            this.txbEmail.TabIndex = 13;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbDiaChi.Location = new System.Drawing.Point(117, 253);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(209, 30);
            this.txbDiaChi.TabIndex = 12;
            // 
            // txbHoTen
            // 
            this.txbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbHoTen.Location = new System.Drawing.Point(117, 98);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(209, 30);
            this.txbHoTen.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(7, 471);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "TBHKII:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(6, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "TBHKI:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(6, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(6, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(6, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(6, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Họ Tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cbDanhSachLop);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(23, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1042, 71);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // cbDanhSachLop
            // 
            this.cbDanhSachLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDanhSachLop.FormattingEnabled = true;
            this.cbDanhSachLop.Location = new System.Drawing.Point(882, 23);
            this.cbDanhSachLop.Name = "cbDanhSachLop";
            this.cbDanhSachLop.Size = new System.Drawing.Size(153, 33);
            this.cbDanhSachLop.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(825, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Lớp:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dtgvDanhSachHocSinh);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(366, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(692, 564);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách học sinh";
            // 
            // dtgvDanhSachHocSinh
            // 
            this.dtgvDanhSachHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhSachHocSinh.Location = new System.Drawing.Point(3, 31);
            this.dtgvDanhSachHocSinh.Name = "dtgvDanhSachHocSinh";
            this.dtgvDanhSachHocSinh.RowHeadersWidth = 62;
            this.dtgvDanhSachHocSinh.RowTemplate.Height = 28;
            this.dtgvDanhSachHocSinh.Size = new System.Drawing.Size(686, 530);
            this.dtgvDanhSachHocSinh.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.add21;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(1061, 379);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 100);
            this.btnThem.TabIndex = 4;
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.update;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(1167, 379);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 100);
            this.btnSua.TabIndex = 6;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.delete3;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(1061, 485);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 100);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.save;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Location = new System.Drawing.Point(1167, 485);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 100);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.delete;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(1061, 591);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(206, 102);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(6, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Mã lớp:";
            // 
            // cbTenLop
            // 
            this.cbTenLop.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTenLop.FormattingEnabled = true;
            this.cbTenLop.Location = new System.Drawing.Point(117, 363);
            this.cbTenLop.Name = "cbTenLop";
            this.cbTenLop.Size = new System.Drawing.Size(209, 33);
            this.cbTenLop.TabIndex = 19;
            // 
            // btnLuuThemhs
            // 
            this.btnLuuThemhs.Location = new System.Drawing.Point(200, 515);
            this.btnLuuThemhs.Name = "btnLuuThemhs";
            this.btnLuuThemhs.Size = new System.Drawing.Size(126, 43);
            this.btnLuuThemhs.TabIndex = 20;
            this.btnLuuThemhs.Text = "Lưu";
            this.btnLuuThemhs.UseVisualStyleBackColor = true;
            this.btnLuuThemhs.Click += new System.EventHandler(this.btnLuuThemhs_Click);
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbID.Location = new System.Drawing.Point(117, 44);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(209, 30);
            this.txbID.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(68, 515);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(126, 43);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(569, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 35);
            this.textBox1.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 35);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.Value = new System.DateTime(2002, 10, 17, 0, 0, 0, 0);
            // 
            // fInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 711);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "fInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLSV";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox txbTBHKII;
        private System.Windows.Forms.TextBox txbTBHKI;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvDanhSachHocSinh;
        private System.Windows.Forms.ComboBox cbDanhSachLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTenLop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLuuThemhs;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
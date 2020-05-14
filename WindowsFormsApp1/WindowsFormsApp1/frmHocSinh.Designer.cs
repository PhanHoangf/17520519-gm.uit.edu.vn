namespace WindowsFormsApp1
{
    partial class frmHocSinh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuuThemhs = new XanderUI.XUIButton();
            this.cbTenLop = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txbTBHKII = new System.Windows.Forms.TextBox();
            this.txbTBHKI = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDanhSachLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachHocSinh = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuu = new XanderUI.XUIButton();
            this.btnXoa = new XanderUI.XUIButton();
            this.btnHuy = new XanderUI.XUIButton();
            this.btnSua = new XanderUI.XUIButton();
            this.btnThem = new XanderUI.XUIButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHocSinh)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THÔNG TIN HỌC SINH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnLuuThemhs);
            this.groupBox1.Controls.Add(this.cbTenLop);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.txbTBHKII);
            this.groupBox1.Controls.Add(this.txbTBHKI);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txbEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbGioiTinh);
            this.groupBox1.Controls.Add(this.txbDiaChi);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbID);
            this.groupBox1.Controls.Add(this.txbHoTen);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.groupBox1.Location = new System.Drawing.Point(149, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(697, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // btnLuuThemhs
            // 
            this.btnLuuThemhs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnLuuThemhs.ButtonImage = null;
            this.btnLuuThemhs.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnLuuThemhs.ButtonText = "Xác nhận";
            this.btnLuuThemhs.ClickBackColor = System.Drawing.Color.Gray;
            this.btnLuuThemhs.ClickTextColor = System.Drawing.Color.Lime;
            this.btnLuuThemhs.CornerRadius = 5;
            this.btnLuuThemhs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuThemhs.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLuuThemhs.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLuuThemhs.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.btnLuuThemhs.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnLuuThemhs.Location = new System.Drawing.Point(553, 65);
            this.btnLuuThemhs.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuThemhs.Name = "btnLuuThemhs";
            this.btnLuuThemhs.Size = new System.Drawing.Size(95, 32);
            this.btnLuuThemhs.TabIndex = 21;
            this.btnLuuThemhs.TextColor = System.Drawing.Color.Lime;
            this.btnLuuThemhs.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLuuThemhs.Click += new System.EventHandler(this.btnLuuThemhs_Click);
            // 
            // cbTenLop
            // 
            this.cbTenLop.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTenLop.FormattingEnabled = true;
            this.cbTenLop.Location = new System.Drawing.Point(324, 27);
            this.cbTenLop.Margin = new System.Windows.Forms.Padding(2);
            this.cbTenLop.Name = "cbTenLop";
            this.cbTenLop.Size = new System.Drawing.Size(141, 24);
            this.cbTenLop.TabIndex = 19;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(87, 94);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(141, 23);
            this.dtpNgaySinh.TabIndex = 17;
            // 
            // txbTBHKII
            // 
            this.txbTBHKII.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbTBHKII.Location = new System.Drawing.Point(553, 26);
            this.txbTBHKII.Margin = new System.Windows.Forms.Padding(2);
            this.txbTBHKII.Name = "txbTBHKII";
            this.txbTBHKII.Size = new System.Drawing.Size(141, 23);
            this.txbTBHKII.TabIndex = 15;
            // 
            // txbTBHKI
            // 
            this.txbTBHKI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbTBHKI.Location = new System.Drawing.Point(324, 129);
            this.txbTBHKI.Margin = new System.Windows.Forms.Padding(2);
            this.txbTBHKI.Name = "txbTBHKI";
            this.txbTBHKI.Size = new System.Drawing.Size(141, 23);
            this.txbTBHKI.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(499, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "TBHKII:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(261, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "TBHKI:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(13, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Email:";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbEmail.Location = new System.Drawing.Point(87, 131);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(141, 23);
            this.txbEmail.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(13, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Họ Tên:";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(324, 61);
            this.cbGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(141, 24);
            this.cbGioiTinh.TabIndex = 16;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbDiaChi.Location = new System.Drawing.Point(324, 94);
            this.txbDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(141, 23);
            this.txbDiaChi.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(261, 29);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Mã lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(261, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(261, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(13, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày sinh:";
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbID.Location = new System.Drawing.Point(87, 63);
            this.txbID.Margin = new System.Windows.Forms.Padding(2);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(141, 23);
            this.txbID.TabIndex = 10;
            // 
            // txbHoTen
            // 
            this.txbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbHoTen.Location = new System.Drawing.Point(87, 27);
            this.txbHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(141, 23);
            this.txbHoTen.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbDanhSachLop);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.groupBox2.Location = new System.Drawing.Point(149, 47);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(697, 51);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // cbDanhSachLop
            // 
            this.cbDanhSachLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDanhSachLop.FormattingEnabled = true;
            this.cbDanhSachLop.Location = new System.Drawing.Point(44, 22);
            this.cbDanhSachLop.Margin = new System.Windows.Forms.Padding(2);
            this.cbDanhSachLop.Name = "cbDanhSachLop";
            this.cbDanhSachLop.Size = new System.Drawing.Size(103, 24);
            this.cbDanhSachLop.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(4, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Lớp:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dtgvDanhSachHocSinh);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.groupBox3.Location = new System.Drawing.Point(8, 269);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(838, 176);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách học sinh";
            // 
            // dtgvDanhSachHocSinh
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtgvDanhSachHocSinh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDanhSachHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDanhSachHocSinh.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDanhSachHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhSachHocSinh.Location = new System.Drawing.Point(2, 21);
            this.dtgvDanhSachHocSinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvDanhSachHocSinh.Name = "dtgvDanhSachHocSinh";
            this.dtgvDanhSachHocSinh.RowHeadersWidth = 62;
            this.dtgvDanhSachHocSinh.RowTemplate.Height = 28;
            this.dtgvDanhSachHocSinh.Size = new System.Drawing.Size(834, 153);
            this.dtgvDanhSachHocSinh.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(10, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(133, 218);
            this.panel1.TabIndex = 10;
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnLuu.ButtonImage = null;
            this.btnLuu.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnLuu.ButtonText = "Lưu";
            this.btnLuu.ClickBackColor = System.Drawing.Color.Gray;
            this.btnLuu.ClickTextColor = System.Drawing.Color.Lime;
            this.btnLuu.CornerRadius = 5;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLuu.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLuu.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.btnLuu.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnLuu.Location = new System.Drawing.Point(12, 121);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(109, 32);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.TextColor = System.Drawing.Color.Lime;
            this.btnLuu.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnXoa.ButtonImage = null;
            this.btnXoa.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnXoa.ButtonText = "Xóa";
            this.btnXoa.ClickBackColor = System.Drawing.Color.Gray;
            this.btnXoa.ClickTextColor = System.Drawing.Color.Lime;
            this.btnXoa.CornerRadius = 5;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXoa.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXoa.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.btnXoa.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnXoa.Location = new System.Drawing.Point(12, 85);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 32);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.TextColor = System.Drawing.Color.Lime;
            this.btnXoa.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnHuy.ButtonImage = null;
            this.btnHuy.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnHuy.ButtonText = "Hủy";
            this.btnHuy.ClickBackColor = System.Drawing.Color.Gray;
            this.btnHuy.ClickTextColor = System.Drawing.Color.Lime;
            this.btnHuy.CornerRadius = 5;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnHuy.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHuy.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.btnHuy.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnHuy.Location = new System.Drawing.Point(12, 177);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(109, 32);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.TextColor = System.Drawing.Color.Lime;
            this.btnHuy.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnSua.ButtonImage = null;
            this.btnSua.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSua.ButtonText = "Sửa";
            this.btnSua.ClickBackColor = System.Drawing.Color.Gray;
            this.btnSua.ClickTextColor = System.Drawing.Color.Lime;
            this.btnSua.CornerRadius = 5;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSua.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSua.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.btnSua.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSua.Location = new System.Drawing.Point(12, 48);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(109, 32);
            this.btnSua.TabIndex = 1;
            this.btnSua.TextColor = System.Drawing.Color.Lime;
            this.btnSua.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnThem.ButtonImage = null;
            this.btnThem.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnThem.ButtonText = "Thêm";
            this.btnThem.ClickBackColor = System.Drawing.Color.Gray;
            this.btnThem.ClickTextColor = System.Drawing.Color.Lime;
            this.btnThem.CornerRadius = 5;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThem.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThem.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.btnThem.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnThem.Location = new System.Drawing.Point(12, 12);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 32);
            this.btnThem.TabIndex = 0;
            this.btnThem.TextColor = System.Drawing.Color.Lime;
            this.btnThem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 43);
            this.panel2.TabIndex = 11;
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(854, 456);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLHS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHocSinh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
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
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton btnThem;
        private System.Windows.Forms.Panel panel2;
        private XanderUI.XUIButton btnLuu;
        private XanderUI.XUIButton btnXoa;
        private XanderUI.XUIButton btnSua;
        private XanderUI.XUIButton btnLuuThemhs;
        private XanderUI.XUIButton btnHuy;
    }
}
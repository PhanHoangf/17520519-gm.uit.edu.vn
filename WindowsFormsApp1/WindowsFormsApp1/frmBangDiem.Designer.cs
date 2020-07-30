namespace WindowsFormsApp1
{
    partial class frmBangDiem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txb15 = new System.Windows.Forms.TextBox();
            this.txbDiemtbm = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbDiemhk = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txb1t = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbTenHs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbIdhocsinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXem = new XanderUI.XUIButton();
            this.cbDanhSachMon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHocki = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDanhSachLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLuuCapNhat = new XanderUI.XUIButton();
            this.btnNhapDiem = new XanderUI.XUIButton();
            this.btnRefesh = new XanderUI.XUIButton();
            this.btnXoa = new XanderUI.XUIButton();
            this.btnInBaoCao = new XanderUI.XUIButton();
            this.btnLuu = new XanderUI.XUIButton();
            this.btnSua = new XanderUI.XUIButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachDiem = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 9);
            this.panel1.Size = new System.Drawing.Size(1196, 77);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(380, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ ĐIỂM HỌC SINH";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1196, 625);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.groupBox1.Location = new System.Drawing.Point(190, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15, 9, 15, 9);
            this.groupBox1.Size = new System.Drawing.Size(1002, 386);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng điều khiển";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.richTextBox1);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.groupBox5.Location = new System.Drawing.Point(578, 32);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(394, 175);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ghi chú";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(388, 146);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txb15);
            this.groupBox4.Controls.Add(this.txbDiemtbm);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txbDiemhk);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txb1t);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txbTenHs);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txbIdhocsinh);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.groupBox4.Location = new System.Drawing.Point(18, 214);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(15, 9, 15, 9);
            this.groupBox4.Size = new System.Drawing.Size(972, 154);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin chi tiết";
            // 
            // txb15
            // 
            this.txb15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb15.Location = new System.Drawing.Point(500, 38);
            this.txb15.Name = "txb15";
            this.txb15.Size = new System.Drawing.Size(156, 30);
            this.txb15.TabIndex = 18;
            // 
            // txbDiemtbm
            // 
            this.txbDiemtbm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbDiemtbm.Location = new System.Drawing.Point(822, 102);
            this.txbDiemtbm.Name = "txbDiemtbm";
            this.txbDiemtbm.Size = new System.Drawing.Size(104, 30);
            this.txbDiemtbm.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(698, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Điểm TBM:";
            // 
            // txbDiemhk
            // 
            this.txbDiemhk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbDiemhk.Location = new System.Drawing.Point(822, 42);
            this.txbDiemhk.Name = "txbDiemhk";
            this.txbDiemhk.Size = new System.Drawing.Size(104, 30);
            this.txbDiemhk.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(698, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Điểm học kì:";
            // 
            // txb1t
            // 
            this.txb1t.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb1t.Location = new System.Drawing.Point(500, 100);
            this.txb1t.Name = "txb1t";
            this.txb1t.Size = new System.Drawing.Size(156, 30);
            this.txb1t.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Điểm 1 tiết:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Điểm 15\':";
            // 
            // txbTenHs
            // 
            this.txbTenHs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbTenHs.Location = new System.Drawing.Point(156, 100);
            this.txbTenHs.Name = "txbTenHs";
            this.txbTenHs.Size = new System.Drawing.Size(182, 30);
            this.txbTenHs.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên học sinh:";
            // 
            // txbIdhocsinh
            // 
            this.txbIdhocsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbIdhocsinh.Location = new System.Drawing.Point(156, 43);
            this.txbIdhocsinh.Name = "txbIdhocsinh";
            this.txbIdhocsinh.Size = new System.Drawing.Size(182, 30);
            this.txbIdhocsinh.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã học sinh:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnXem);
            this.groupBox3.Controls.Add(this.cbDanhSachMon);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbHocki);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbDanhSachLop);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.groupBox3.Location = new System.Drawing.Point(18, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(537, 175);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lựa chọn";
            // 
            // btnXem
            // 
            this.btnXem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnXem.ButtonImage = null;
            this.btnXem.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnXem.ButtonText = "Xem";
            this.btnXem.ClickBackColor = System.Drawing.Color.Gray;
            this.btnXem.ClickTextColor = System.Drawing.Color.Lime;
            this.btnXem.CornerRadius = 5;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXem.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXem.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXem.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.btnXem.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnXem.Location = new System.Drawing.Point(340, 103);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(154, 49);
            this.btnXem.TabIndex = 12;
            this.btnXem.TextColor = System.Drawing.Color.Lime;
            this.btnXem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cbDanhSachMon
            // 
            this.cbDanhSachMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDanhSachMon.FormattingEnabled = true;
            this.cbDanhSachMon.Location = new System.Drawing.Point(106, 112);
            this.cbDanhSachMon.Name = "cbDanhSachMon";
            this.cbDanhSachMon.Size = new System.Drawing.Size(156, 33);
            this.cbDanhSachMon.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Môn học:";
            // 
            // cbHocki
            // 
            this.cbHocki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbHocki.FormattingEnabled = true;
            this.cbHocki.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbHocki.Location = new System.Drawing.Point(340, 38);
            this.cbHocki.Name = "cbHocki";
            this.cbHocki.Size = new System.Drawing.Size(168, 33);
            this.cbHocki.TabIndex = 3;
            this.cbHocki.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Học kì:";
            // 
            // cbDanhSachLop
            // 
            this.cbDanhSachLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDanhSachLop.FormattingEnabled = true;
            this.cbDanhSachLop.Location = new System.Drawing.Point(64, 38);
            this.cbDanhSachLop.Name = "cbDanhSachLop";
            this.cbDanhSachLop.Size = new System.Drawing.Size(198, 33);
            this.cbDanhSachLop.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lớp:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel4.Controls.Add(this.btnLuuCapNhat);
            this.panel4.Controls.Add(this.btnNhapDiem);
            this.panel4.Controls.Add(this.btnRefesh);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.btnInBaoCao);
            this.panel4.Controls.Add(this.btnLuu);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.panel4.Size = new System.Drawing.Size(190, 386);
            this.panel4.TabIndex = 1;
            // 
            // btnLuuCapNhat
            // 
            this.btnLuuCapNhat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnLuuCapNhat.ButtonImage = null;
            this.btnLuuCapNhat.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnLuuCapNhat.ButtonText = "Lưu Cập Nhật";
            this.btnLuuCapNhat.ClickBackColor = System.Drawing.Color.Gray;
            this.btnLuuCapNhat.ClickTextColor = System.Drawing.Color.Lime;
            this.btnLuuCapNhat.CornerRadius = 5;
            this.btnLuuCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuCapNhat.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLuuCapNhat.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLuuCapNhat.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.btnLuuCapNhat.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnLuuCapNhat.Location = new System.Drawing.Point(22, 78);
            this.btnLuuCapNhat.Name = "btnLuuCapNhat";
            this.btnLuuCapNhat.Size = new System.Drawing.Size(154, 49);
            this.btnLuuCapNhat.TabIndex = 12;
            this.btnLuuCapNhat.TextColor = System.Drawing.Color.Lime;
            this.btnLuuCapNhat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLuuCapNhat.Visible = false;
            this.btnLuuCapNhat.Click += new System.EventHandler(this.btnLuuCapNhat_Click);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnNhapDiem.ButtonImage = null;
            this.btnNhapDiem.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnNhapDiem.ButtonText = "Nhập";
            this.btnNhapDiem.ClickBackColor = System.Drawing.Color.Gray;
            this.btnNhapDiem.ClickTextColor = System.Drawing.Color.Lime;
            this.btnNhapDiem.CornerRadius = 5;
            this.btnNhapDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhapDiem.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNhapDiem.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNhapDiem.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.btnNhapDiem.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnNhapDiem.Location = new System.Drawing.Point(22, 23);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(154, 49);
            this.btnNhapDiem.TabIndex = 11;
            this.btnNhapDiem.TextColor = System.Drawing.Color.Lime;
            this.btnNhapDiem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click_1);
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnRefesh.ButtonImage = null;
            this.btnRefesh.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnRefesh.ButtonText = "Refresh";
            this.btnRefesh.ClickBackColor = System.Drawing.Color.Gray;
            this.btnRefesh.ClickTextColor = System.Drawing.Color.Lime;
            this.btnRefesh.CornerRadius = 5;
            this.btnRefesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefesh.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRefesh.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefesh.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.btnRefesh.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnRefesh.Location = new System.Drawing.Point(22, 248);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(154, 49);
            this.btnRefesh.TabIndex = 10;
            this.btnRefesh.TextColor = System.Drawing.Color.Lime;
            this.btnRefesh.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(22, 191);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(154, 49);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.TextColor = System.Drawing.Color.Lime;
            this.btnXoa.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnInBaoCao.ButtonImage = null;
            this.btnInBaoCao.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnInBaoCao.ButtonText = "In báo cáo";
            this.btnInBaoCao.ClickBackColor = System.Drawing.Color.Gray;
            this.btnInBaoCao.ClickTextColor = System.Drawing.Color.Lime;
            this.btnInBaoCao.CornerRadius = 5;
            this.btnInBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInBaoCao.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInBaoCao.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInBaoCao.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.btnInBaoCao.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnInBaoCao.Location = new System.Drawing.Point(22, 318);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(154, 49);
            this.btnInBaoCao.TabIndex = 8;
            this.btnInBaoCao.TextColor = System.Drawing.Color.Lime;
            this.btnInBaoCao.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
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
            this.btnLuu.Location = new System.Drawing.Point(22, 135);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(154, 49);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.TextColor = System.Drawing.Color.Lime;
            this.btnLuu.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.btnSua.Location = new System.Drawing.Point(22, 78);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(154, 49);
            this.btnSua.TabIndex = 6;
            this.btnSua.TextColor = System.Drawing.Color.Lime;
            this.btnSua.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgvDanhSachDiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(0, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1196, 233);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Bảng điểm";
            // 
            // dtgvDanhSachDiem
            // 
            this.dtgvDanhSachDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSachDiem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvDanhSachDiem.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtgvDanhSachDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhSachDiem.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgvDanhSachDiem.Location = new System.Drawing.Point(3, 31);
            this.dtgvDanhSachDiem.Name = "dtgvDanhSachDiem";
            this.dtgvDanhSachDiem.RowHeadersWidth = 62;
            this.dtgvDanhSachDiem.RowTemplate.Height = 28;
            this.dtgvDanhSachDiem.Size = new System.Drawing.Size(1190, 199);
            this.dtgvDanhSachDiem.TabIndex = 0;
            // 
            // frmBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1196, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "frmBangDiem";
            this.Text = "fBangDiem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvDanhSachDiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbDanhSachMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHocki;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDanhSachLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDiemtbm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbDiemhk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb1t;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbTenHs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbIdhocsinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb15;
        private System.Windows.Forms.Panel panel4;
        private XanderUI.XUIButton btnNhapDiem;
        private XanderUI.XUIButton btnRefesh;
        private XanderUI.XUIButton btnXoa;
        private XanderUI.XUIButton btnInBaoCao;
        private XanderUI.XUIButton btnLuu;
        private XanderUI.XUIButton btnSua;
        private XanderUI.XUIButton btnXem;
        private XanderUI.XUIButton btnLuuCapNhat;
    }
}
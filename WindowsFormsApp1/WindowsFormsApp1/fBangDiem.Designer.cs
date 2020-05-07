namespace WindowsFormsApp1
{
    partial class fBangDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBangDiem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachDiem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txbDiemtbm = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbDiemhk = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txb1t = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb15 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbTenHs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbIdhocsinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbDanhSachMon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHocki = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDanhSachLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRefesh = new XanderUI.XUIButton();
            this.xuiButton5 = new XanderUI.XUIButton();
            this.xuiButton4 = new XanderUI.XUIButton();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.btnNhapDiem = new XanderUI.XUIButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachDiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.panel1.Size = new System.Drawing.Size(1179, 78);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(392, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ ĐIỂM HỌC SINH";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1179, 646);
            this.panel2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgvDanhSachDiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(200, 379);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(979, 267);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Bảng điểm";
            // 
            // dtgvDanhSachDiem
            // 
            this.dtgvDanhSachDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvDanhSachDiem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvDanhSachDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhSachDiem.Location = new System.Drawing.Point(3, 31);
            this.dtgvDanhSachDiem.Name = "dtgvDanhSachDiem";
            this.dtgvDanhSachDiem.RowHeadersWidth = 62;
            this.dtgvDanhSachDiem.RowTemplate.Height = 28;
            this.dtgvDanhSachDiem.Size = new System.Drawing.Size(973, 233);
            this.dtgvDanhSachDiem.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(200, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.groupBox1.Size = new System.Drawing.Size(979, 386);
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
            this.groupBox5.Location = new System.Drawing.Point(538, 32);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(429, 179);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ghi chú";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(423, 150);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txbDiemtbm);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txbDiemhk);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txb1t);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txb15);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txbTenHs);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txbIdhocsinh);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.Location = new System.Drawing.Point(18, 214);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.groupBox4.Size = new System.Drawing.Size(949, 159);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin chi tiết";
            // 
            // txbDiemtbm
            // 
            this.txbDiemtbm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbDiemtbm.Location = new System.Drawing.Point(822, 101);
            this.txbDiemtbm.Name = "txbDiemtbm";
            this.txbDiemtbm.Size = new System.Drawing.Size(104, 26);
            this.txbDiemtbm.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(697, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Điểm TBM:";
            // 
            // txbDiemhk
            // 
            this.txbDiemhk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbDiemhk.Location = new System.Drawing.Point(822, 42);
            this.txbDiemhk.Name = "txbDiemhk";
            this.txbDiemhk.Size = new System.Drawing.Size(104, 26);
            this.txbDiemhk.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(697, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Điểm học kì:";
            // 
            // txb1t
            // 
            this.txb1t.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb1t.Location = new System.Drawing.Point(499, 100);
            this.txb1t.Name = "txb1t";
            this.txb1t.Size = new System.Drawing.Size(156, 26);
            this.txb1t.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Điểm 1 tiết:";
            // 
            // txb15
            // 
            this.txb15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb15.Location = new System.Drawing.Point(499, 41);
            this.txb15.Name = "txb15";
            this.txb15.Size = new System.Drawing.Size(156, 26);
            this.txb15.TabIndex = 11;
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
            this.txbTenHs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbTenHs.Location = new System.Drawing.Point(156, 100);
            this.txbTenHs.Name = "txbTenHs";
            this.txbTenHs.Size = new System.Drawing.Size(182, 26);
            this.txbTenHs.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên học sinh:";
            // 
            // txbIdhocsinh
            // 
            this.txbIdhocsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbIdhocsinh.Location = new System.Drawing.Point(156, 43);
            this.txbIdhocsinh.Name = "txbIdhocsinh";
            this.txbIdhocsinh.Size = new System.Drawing.Size(182, 26);
            this.txbIdhocsinh.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã học sinh:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbDanhSachMon);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbHocki);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbDanhSachLop);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(18, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(514, 176);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lựa chọn";
            // 
            // cbDanhSachMon
            // 
            this.cbDanhSachMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDanhSachMon.FormattingEnabled = true;
            this.cbDanhSachMon.Location = new System.Drawing.Point(107, 112);
            this.cbDanhSachMon.Name = "cbDanhSachMon";
            this.cbDanhSachMon.Size = new System.Drawing.Size(401, 28);
            this.cbDanhSachMon.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Môn học:";
            // 
            // cbHocki
            // 
            this.cbHocki.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbHocki.FormattingEnabled = true;
            this.cbHocki.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbHocki.Location = new System.Drawing.Point(340, 42);
            this.cbHocki.Name = "cbHocki";
            this.cbHocki.Size = new System.Drawing.Size(168, 28);
            this.cbHocki.TabIndex = 3;
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
            this.cbDanhSachLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDanhSachLop.FormattingEnabled = true;
            this.cbDanhSachLop.Location = new System.Drawing.Point(64, 42);
            this.cbDanhSachLop.Name = "cbDanhSachLop";
            this.cbDanhSachLop.Size = new System.Drawing.Size(198, 28);
            this.cbDanhSachLop.TabIndex = 1;
            this.cbDanhSachLop.SelectedIndexChanged += new System.EventHandler(this.cbDanhSachLop_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lớp:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 646);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRefesh);
            this.panel4.Controls.Add(this.xuiButton5);
            this.panel4.Controls.Add(this.xuiButton4);
            this.panel4.Controls.Add(this.xuiButton3);
            this.panel4.Controls.Add(this.xuiButton2);
            this.panel4.Controls.Add(this.btnNhapDiem);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 39);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(20);
            this.panel4.Size = new System.Drawing.Size(200, 607);
            this.panel4.TabIndex = 1;
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackgroundColor = System.Drawing.Color.Black;
            this.btnRefesh.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnRefesh.ButtonImage")));
            this.btnRefesh.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnRefesh.ButtonText = "Refresh";
            this.btnRefesh.ClickBackColor = System.Drawing.Color.Gray;
            this.btnRefesh.ClickTextColor = System.Drawing.Color.LavenderBlush;
            this.btnRefesh.CornerRadius = 5;
            this.btnRefesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefesh.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRefesh.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefesh.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.btnRefesh.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnRefesh.Location = new System.Drawing.Point(23, 375);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(154, 50);
            this.btnRefesh.TabIndex = 10;
            this.btnRefesh.TextColor = System.Drawing.Color.LavenderBlush;
            this.btnRefesh.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // xuiButton5
            // 
            this.xuiButton5.BackgroundColor = System.Drawing.Color.Black;
            this.xuiButton5.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton5.ButtonImage")));
            this.xuiButton5.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton5.ButtonText = "Xóa";
            this.xuiButton5.ClickBackColor = System.Drawing.Color.Gray;
            this.xuiButton5.ClickTextColor = System.Drawing.Color.LavenderBlush;
            this.xuiButton5.CornerRadius = 5;
            this.xuiButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xuiButton5.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton5.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xuiButton5.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.xuiButton5.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton5.Location = new System.Drawing.Point(23, 293);
            this.xuiButton5.Name = "xuiButton5";
            this.xuiButton5.Size = new System.Drawing.Size(154, 50);
            this.xuiButton5.TabIndex = 9;
            this.xuiButton5.TextColor = System.Drawing.Color.LavenderBlush;
            this.xuiButton5.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton4
            // 
            this.xuiButton4.BackgroundColor = System.Drawing.Color.Black;
            this.xuiButton4.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton4.ButtonImage")));
            this.xuiButton4.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton4.ButtonText = "In báo cáo";
            this.xuiButton4.ClickBackColor = System.Drawing.Color.Gray;
            this.xuiButton4.ClickTextColor = System.Drawing.Color.LavenderBlush;
            this.xuiButton4.CornerRadius = 5;
            this.xuiButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xuiButton4.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton4.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xuiButton4.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.xuiButton4.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton4.Location = new System.Drawing.Point(23, 498);
            this.xuiButton4.Name = "xuiButton4";
            this.xuiButton4.Size = new System.Drawing.Size(154, 50);
            this.xuiButton4.TabIndex = 8;
            this.xuiButton4.TextColor = System.Drawing.Color.LavenderBlush;
            this.xuiButton4.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton3
            // 
            this.xuiButton3.BackgroundColor = System.Drawing.Color.Black;
            this.xuiButton3.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton3.ButtonImage")));
            this.xuiButton3.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton3.ButtonText = "Lưu";
            this.xuiButton3.ClickBackColor = System.Drawing.Color.Gray;
            this.xuiButton3.ClickTextColor = System.Drawing.Color.LavenderBlush;
            this.xuiButton3.CornerRadius = 5;
            this.xuiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xuiButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xuiButton3.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.xuiButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton3.Location = new System.Drawing.Point(23, 206);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(154, 50);
            this.xuiButton3.TabIndex = 7;
            this.xuiButton3.TextColor = System.Drawing.Color.LavenderBlush;
            this.xuiButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton2
            // 
            this.xuiButton2.BackgroundColor = System.Drawing.Color.Black;
            this.xuiButton2.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton2.ButtonImage")));
            this.xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton2.ButtonText = "Sửa";
            this.xuiButton2.ClickBackColor = System.Drawing.Color.Gray;
            this.xuiButton2.ClickTextColor = System.Drawing.Color.LavenderBlush;
            this.xuiButton2.CornerRadius = 5;
            this.xuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xuiButton2.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton2.Location = new System.Drawing.Point(23, 122);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(154, 50);
            this.xuiButton2.TabIndex = 6;
            this.xuiButton2.TextColor = System.Drawing.Color.LavenderBlush;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.BackgroundColor = System.Drawing.Color.Black;
            this.btnNhapDiem.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnNhapDiem.ButtonImage")));
            this.btnNhapDiem.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnNhapDiem.ButtonText = "Nhập";
            this.btnNhapDiem.ClickBackColor = System.Drawing.Color.Gray;
            this.btnNhapDiem.ClickTextColor = System.Drawing.Color.LavenderBlush;
            this.btnNhapDiem.CornerRadius = 5;
            this.btnNhapDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhapDiem.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNhapDiem.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNhapDiem.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.btnNhapDiem.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnNhapDiem.Location = new System.Drawing.Point(23, 38);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(154, 50);
            this.btnNhapDiem.TabIndex = 5;
            this.btnNhapDiem.TextColor = System.Drawing.Color.LavenderBlush;
            this.btnNhapDiem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.menu;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 39);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 724);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fBangDiem";
            this.Text = "fBangDiem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachDiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvDanhSachDiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private XanderUI.XUIButton btnNhapDiem;
        private XanderUI.XUIButton xuiButton4;
        private XanderUI.XUIButton xuiButton3;
        private XanderUI.XUIButton xuiButton2;
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
        private XanderUI.XUIButton xuiButton5;
        private System.Windows.Forms.TextBox txbDiemtbm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbDiemhk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb1t;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbTenHs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbIdhocsinh;
        private System.Windows.Forms.Label label5;
        private XanderUI.XUIButton btnRefesh;
    }
}
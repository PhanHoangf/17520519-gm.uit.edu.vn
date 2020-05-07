namespace WindowsFormsApp1
{
    partial class fMonHoc
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
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnRefresh = new XanderUI.XUISuperButton();
            this.btnLuu = new XanderUI.XUISuperButton();
            this.btnCapNhat = new XanderUI.XUISuperButton();
            this.btnXoa = new XanderUI.XUISuperButton();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnThem = new XanderUI.XUISuperButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new XanderUI.XUIButton();
            this.txbSearchBox = new System.Windows.Forms.TextBox();
            this.txbIdMon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbDiemDat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTenMon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvdanhsachmon = new System.Windows.Forms.DataGridView();
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdanhsachmon)).BeginInit();
            this.xuiCustomGroupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(122)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 71);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.subject;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox6.Location = new System.Drawing.Point(310, 10);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(63, 40);
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(379, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ MÔN HỌC";
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.pnMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMenu.Controls.Add(this.btnRefresh);
            this.pnMenu.Controls.Add(this.btnLuu);
            this.pnMenu.Controls.Add(this.btnCapNhat);
            this.pnMenu.Controls.Add(this.btnXoa);
            this.pnMenu.Controls.Add(this.btnMenu);
            this.pnMenu.Controls.Add(this.btnThem);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 71);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(67, 537);
            this.pnMenu.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.btnRefresh.ButtonImage = global::WindowsFormsApp1.Properties.Resources.refresh;
            this.btnRefresh.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnRefresh.ButtonStyle = XanderUI.XUISuperButton.Style.Flat;
            this.btnRefresh.ButtonText = "Refesh";
            this.btnRefresh.CornerRadius = 5;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefresh.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRefresh.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnRefresh.HoverTextColor = System.Drawing.Color.White;
            this.btnRefresh.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnRefresh.Location = new System.Drawing.Point(0, 454);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRefresh.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.btnRefresh.SelectedTextColor = System.Drawing.Color.White;
            this.btnRefresh.Size = new System.Drawing.Size(207, 70);
            this.btnRefresh.SuperSelected = false;
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.btnLuu.ButtonImage = global::WindowsFormsApp1.Properties.Resources.save1;
            this.btnLuu.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnLuu.ButtonStyle = XanderUI.XUISuperButton.Style.Flat;
            this.btnLuu.ButtonText = "Lưu";
            this.btnLuu.CornerRadius = 5;
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLuu.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnLuu.HoverTextColor = System.Drawing.Color.White;
            this.btnLuu.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnLuu.Location = new System.Drawing.Point(0, 363);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLuu.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.btnLuu.SelectedTextColor = System.Drawing.Color.White;
            this.btnLuu.Size = new System.Drawing.Size(207, 70);
            this.btnLuu.SuperSelected = false;
            this.btnLuu.TabIndex = 4;
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.btnCapNhat.ButtonImage = global::WindowsFormsApp1.Properties.Resources.update2;
            this.btnCapNhat.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnCapNhat.ButtonStyle = XanderUI.XUISuperButton.Style.Flat;
            this.btnCapNhat.ButtonText = "Cập nhật";
            this.btnCapNhat.CornerRadius = 5;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhat.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCapNhat.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnCapNhat.HoverTextColor = System.Drawing.Color.White;
            this.btnCapNhat.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnCapNhat.Location = new System.Drawing.Point(0, 268);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.btnCapNhat.SelectedTextColor = System.Drawing.Color.White;
            this.btnCapNhat.Size = new System.Drawing.Size(207, 70);
            this.btnCapNhat.SuperSelected = false;
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.TextColor = System.Drawing.Color.White;
            this.btnCapNhat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.btnXoa.ButtonImage = global::WindowsFormsApp1.Properties.Resources.delete5;
            this.btnXoa.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnXoa.ButtonStyle = XanderUI.XUISuperButton.Style.Flat;
            this.btnXoa.ButtonText = "Xóa";
            this.btnXoa.CornerRadius = 5;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXoa.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnXoa.HoverTextColor = System.Drawing.Color.White;
            this.btnXoa.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnXoa.Location = new System.Drawing.Point(-1, 172);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.btnXoa.SelectedTextColor = System.Drawing.Color.White;
            this.btnXoa.Size = new System.Drawing.Size(207, 70);
            this.btnXoa.SuperSelected = false;
            this.btnXoa.TabIndex = 2;
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.menu;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(65, 32);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.btnThem.ButtonImage = global::WindowsFormsApp1.Properties.Resources.add3;
            this.btnThem.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnThem.ButtonStyle = XanderUI.XUISuperButton.Style.Flat;
            this.btnThem.ButtonText = "Thêm";
            this.btnThem.CornerRadius = 5;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThem.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnThem.HoverTextColor = System.Drawing.Color.White;
            this.btnThem.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnThem.Location = new System.Drawing.Point(-1, 75);
            this.btnThem.Name = "btnThem";
            this.btnThem.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.btnThem.SelectedTextColor = System.Drawing.Color.White;
            this.btnThem.Size = new System.Drawing.Size(207, 70);
            this.btnThem.SuperSelected = false;
            this.btnThem.TabIndex = 1;
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(67, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 249);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txbIdMon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbDiemDat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbTenMon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(978, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin môn học";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txbSearchBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(3, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(972, 66);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSearch.ButtonImage = global::WindowsFormsApp1.Properties.Resources.search;
            this.btnSearch.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSearch.ButtonText = "";
            this.btnSearch.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSearch.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.CornerRadius = 5;
            this.btnSearch.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearch.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSearch.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnSearch.Location = new System.Drawing.Point(903, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(54, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearchBox
            // 
            this.txbSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearchBox.Location = new System.Drawing.Point(714, 25);
            this.txbSearchBox.Name = "txbSearchBox";
            this.txbSearchBox.Size = new System.Drawing.Size(183, 30);
            this.txbSearchBox.TabIndex = 0;
            // 
            // txbIdMon
            // 
            this.txbIdMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbIdMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbIdMon.Location = new System.Drawing.Point(792, 116);
            this.txbIdMon.Name = "txbIdMon";
            this.txbIdMon.Size = new System.Drawing.Size(180, 30);
            this.txbIdMon.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(691, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID Môn:";
            // 
            // txbDiemDat
            // 
            this.txbDiemDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbDiemDat.Location = new System.Drawing.Point(126, 179);
            this.txbDiemDat.Name = "txbDiemDat";
            this.txbDiemDat.Size = new System.Drawing.Size(180, 30);
            this.txbDiemDat.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Điểm đạt:";
            // 
            // txbTenMon
            // 
            this.txbTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbTenMon.Location = new System.Drawing.Point(126, 115);
            this.txbTenMon.Name = "txbTenMon";
            this.txbTenMon.Size = new System.Drawing.Size(180, 30);
            this.txbTenMon.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên môn:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtgvdanhsachmon
            // 
            this.dtgvdanhsachmon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvdanhsachmon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvdanhsachmon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvdanhsachmon.Location = new System.Drawing.Point(3, 35);
            this.dtgvdanhsachmon.Name = "dtgvdanhsachmon";
            this.dtgvdanhsachmon.RowHeadersWidth = 62;
            this.dtgvdanhsachmon.RowTemplate.Height = 28;
            this.dtgvdanhsachmon.Size = new System.Drawing.Size(974, 250);
            this.dtgvdanhsachmon.TabIndex = 0;
            // 
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.Black;
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.dtgvdanhsachmon);
            this.xuiCustomGroupbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiCustomGroupbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(67, 320);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(980, 288);
            this.xuiCustomGroupbox1.TabIndex = 0;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.Text = "Danh sách môn học";
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.Black;
            // 
            // fMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1047, 608);
            this.Controls.Add(this.xuiCustomGroupbox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMonHoc";
            this.Text = "fMonHoc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdanhsachmon)).EndInit();
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.DataGridView dtgvdanhsachmon;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.GroupBox groupBox1;
        private XanderUI.XUISuperButton btnThem;
        private XanderUI.XUISuperButton btnXoa;
        private XanderUI.XUISuperButton btnLuu;
        private XanderUI.XUISuperButton btnCapNhat;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbSearchBox;
        private System.Windows.Forms.TextBox txbIdMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbDiemDat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTenMon;
        private System.Windows.Forms.Label label3;
        private XanderUI.XUIButton btnSearch;
        private XanderUI.XUISuperButton btnRefresh;
    }
}
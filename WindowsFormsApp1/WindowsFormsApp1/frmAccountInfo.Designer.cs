namespace WindowsFormsApp1
{
    partial class frmAccountInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountInfo));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnMenu2 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgvDanhSachTK = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grbAccountInfo = new System.Windows.Forms.GroupBox();
            this.txbXacNhanMK = new System.Windows.Forms.TextBox();
            this.lblxacnhan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new XanderUI.XUIButton();
            this.BtnXoa = new XanderUI.XUIButton();
            this.btnSua = new XanderUI.XUIButton();
            this.btnLuu = new XanderUI.XUIButton();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachTK)).BeginInit();
            this.panel4.SuspendLayout();
            this.grbAccountInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnMenu.Controls.Add(this.btnLuu);
            this.pnMenu.Controls.Add(this.btnSua);
            this.pnMenu.Controls.Add(this.BtnXoa);
            this.pnMenu.Controls.Add(this.button1);
            this.pnMenu.Controls.Add(this.btnMenu2);
            this.pnMenu.Controls.Add(this.btnMenu);
            this.pnMenu.Controls.Add(this.lblMenu);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(89)))), ((int)(((byte)(0)))));
            this.pnMenu.Location = new System.Drawing.Point(0, 56);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(163, 340);
            this.pnMenu.TabIndex = 0;
            // 
            // btnMenu2
            // 
            this.btnMenu2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.menu;
            this.btnMenu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu2.Location = new System.Drawing.Point(0, 0);
            this.btnMenu2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenu2.Name = "btnMenu2";
            this.btnMenu2.Size = new System.Drawing.Size(163, 20);
            this.btnMenu2.TabIndex = 7;
            this.btnMenu2.TabStop = false;
            this.btnMenu2.Click += new System.EventHandler(this.btnMenu2_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.menu;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.Location = new System.Drawing.Point(127, 4);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(31, 20);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.Black;
            this.lblMenu.Location = new System.Drawing.Point(2, 2);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(121, 23);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "User Control";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 56);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(189, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 26);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(235, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN TÀI KHOẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(163, 56);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(597, 340);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgvDanhSachTK);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(0, 202);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(597, 138);
            this.panel5.TabIndex = 1;
            // 
            // dtgvDanhSachTK
            // 
            this.dtgvDanhSachTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSachTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhSachTK.GridColor = System.Drawing.Color.Black;
            this.dtgvDanhSachTK.Location = new System.Drawing.Point(0, 0);
            this.dtgvDanhSachTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvDanhSachTK.Name = "dtgvDanhSachTK";
            this.dtgvDanhSachTK.RowHeadersWidth = 62;
            this.dtgvDanhSachTK.RowTemplate.Height = 28;
            this.dtgvDanhSachTK.Size = new System.Drawing.Size(597, 138);
            this.dtgvDanhSachTK.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.Controls.Add(this.grbAccountInfo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(597, 202);
            this.panel4.TabIndex = 0;
            // 
            // grbAccountInfo
            // 
            this.grbAccountInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.grbAccountInfo.Controls.Add(this.txbXacNhanMK);
            this.grbAccountInfo.Controls.Add(this.lblxacnhan);
            this.grbAccountInfo.Controls.Add(this.label8);
            this.grbAccountInfo.Controls.Add(this.label9);
            this.grbAccountInfo.Controls.Add(this.label7);
            this.grbAccountInfo.Controls.Add(this.label6);
            this.grbAccountInfo.Controls.Add(this.cbLoaiTaiKhoan);
            this.grbAccountInfo.Controls.Add(this.label5);
            this.grbAccountInfo.Controls.Add(this.txbMatKhau);
            this.grbAccountInfo.Controls.Add(this.label4);
            this.grbAccountInfo.Controls.Add(this.txbTenTaiKhoan);
            this.grbAccountInfo.Controls.Add(this.label3);
            this.grbAccountInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbAccountInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbAccountInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.grbAccountInfo.Location = new System.Drawing.Point(0, 0);
            this.grbAccountInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbAccountInfo.Name = "grbAccountInfo";
            this.grbAccountInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbAccountInfo.Size = new System.Drawing.Size(597, 202);
            this.grbAccountInfo.TabIndex = 0;
            this.grbAccountInfo.TabStop = false;
            this.grbAccountInfo.Text = "Thông tin tài khoản";
            // 
            // txbXacNhanMK
            // 
            this.txbXacNhanMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbXacNhanMK.Location = new System.Drawing.Point(147, 154);
            this.txbXacNhanMK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbXacNhanMK.Name = "txbXacNhanMK";
            this.txbXacNhanMK.PasswordChar = '*';
            this.txbXacNhanMK.Size = new System.Drawing.Size(121, 23);
            this.txbXacNhanMK.TabIndex = 11;
            this.txbXacNhanMK.Visible = false;
            // 
            // lblxacnhan
            // 
            this.lblxacnhan.AutoSize = true;
            this.lblxacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblxacnhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.lblxacnhan.Location = new System.Drawing.Point(25, 155);
            this.lblxacnhan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblxacnhan.Name = "lblxacnhan";
            this.lblxacnhan.Size = new System.Drawing.Size(106, 20);
            this.lblxacnhan.TabIndex = 10;
            this.lblxacnhan.Text = "Xác nhận mk:";
            this.lblxacnhan.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(489, 178);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "0-User";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(434, 178);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "*loại tk:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(489, 157);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "1-Admin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(434, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "*loại tk:";
            // 
            // cbLoaiTaiKhoan
            // 
            this.cbLoaiTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbLoaiTaiKhoan.FormattingEnabled = true;
            this.cbLoaiTaiKhoan.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cbLoaiTaiKhoan.Location = new System.Drawing.Point(434, 38);
            this.cbLoaiTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbLoaiTaiKhoan.Name = "cbLoaiTaiKhoan";
            this.cbLoaiTaiKhoan.Size = new System.Drawing.Size(103, 24);
            this.cbLoaiTaiKhoan.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label5.Location = new System.Drawing.Point(309, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại Tài Khoản:";
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbMatKhau.Location = new System.Drawing.Point(147, 95);
            this.txbMatKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.PasswordChar = '*';
            this.txbMatKhau.Size = new System.Drawing.Size(121, 23);
            this.txbMatKhau.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label4.Location = new System.Drawing.Point(25, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật Khẩu:";
            // 
            // txbTenTaiKhoan
            // 
            this.txbTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbTenTaiKhoan.Location = new System.Drawing.Point(147, 40);
            this.txbTenTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbTenTaiKhoan.Name = "txbTenTaiKhoan";
            this.txbTenTaiKhoan.Size = new System.Drawing.Size(121, 23);
            this.txbTenTaiKhoan.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(25, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Tài Khoản:";
            // 
            // button1
            // 
            this.button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.button1.ButtonImage = null;
            this.button1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.button1.ButtonText = "Thêm tài khoản";
            this.button1.ClickBackColor = System.Drawing.Color.Gray;
            this.button1.ClickTextColor = System.Drawing.Color.Lime;
            this.button1.CornerRadius = 5;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.button1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.button1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.button1.Location = new System.Drawing.Point(11, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 37);
            this.button1.TabIndex = 12;
            this.button1.TextColor = System.Drawing.Color.Lime;
            this.button1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.BtnXoa.ButtonImage = null;
            this.BtnXoa.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.BtnXoa.ButtonText = "Xóa tài khoản";
            this.BtnXoa.ClickBackColor = System.Drawing.Color.Gray;
            this.BtnXoa.ClickTextColor = System.Drawing.Color.Lime;
            this.BtnXoa.CornerRadius = 5;
            this.BtnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnXoa.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnXoa.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnXoa.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.BtnXoa.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.BtnXoa.Location = new System.Drawing.Point(11, 115);
            this.BtnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(147, 37);
            this.BtnXoa.TabIndex = 13;
            this.BtnXoa.TextColor = System.Drawing.Color.Lime;
            this.BtnXoa.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnSua.ButtonImage = null;
            this.btnSua.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSua.ButtonText = "Sửa thông tin";
            this.btnSua.ClickBackColor = System.Drawing.Color.Gray;
            this.btnSua.ClickTextColor = System.Drawing.Color.Lime;
            this.btnSua.CornerRadius = 5;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSua.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSua.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.btnSua.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSua.Location = new System.Drawing.Point(11, 178);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(147, 37);
            this.btnSua.TabIndex = 14;
            this.btnSua.TextColor = System.Drawing.Color.Lime;
            this.btnSua.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnLuu.Location = new System.Drawing.Point(11, 239);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(147, 37);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.TextColor = System.Drawing.Color.Lime;
            this.btnLuu.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(760, 396);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAccountInfo";
            this.Text = "Quản Lí Tài Khoản";
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachTK)).EndInit();
            this.panel4.ResumeLayout(false);
            this.grbAccountInfo.ResumeLayout(false);
            this.grbAccountInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dtgvDanhSachTK;
        private System.Windows.Forms.GroupBox grbAccountInfo;
        private System.Windows.Forms.TextBox txbTenTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLoaiTaiKhoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btnMenu2;
        private System.Windows.Forms.TextBox txbXacNhanMK;
        private System.Windows.Forms.Label lblxacnhan;
        private XanderUI.XUIButton button1;
        private XanderUI.XUIButton btnLuu;
        private XanderUI.XUIButton btnSua;
        private XanderUI.XUIButton BtnXoa;
    }
}
namespace WindowsFormsApp1
{
    partial class frmLopHoc
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLopHoc));
            this.grBoxThongTinLop = new System.Windows.Forms.GroupBox();
            this.grBoxThemLop = new System.Windows.Forms.GroupBox();
            this.btnHuyThemLop = new XanderUI.XUIButton();
            this.btnXacNhan = new XanderUI.XUIButton();
            this.txbThemSiSoLop = new System.Windows.Forms.TextBox();
            this.txbThemTenLop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbSiso = new System.Windows.Forms.TextBox();
            this.txbTenLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grBoxDsLop = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachLop = new System.Windows.Forms.DataGridView();
            this.imgbutton = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuu = new XanderUI.XUIButton();
            this.btnSua = new XanderUI.XUIButton();
            this.btnXoa = new XanderUI.XUIButton();
            this.btnThem = new XanderUI.XUIButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.grBoxThongTinLop.SuspendLayout();
            this.grBoxThemLop.SuspendLayout();
            this.grBoxDsLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachLop)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBoxThongTinLop
            // 
            this.grBoxThongTinLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxThongTinLop.Controls.Add(this.grBoxThemLop);
            this.grBoxThongTinLop.Controls.Add(this.txbId);
            this.grBoxThongTinLop.Controls.Add(this.txbSiso);
            this.grBoxThongTinLop.Controls.Add(this.txbTenLop);
            this.grBoxThongTinLop.Controls.Add(this.label3);
            this.grBoxThongTinLop.Controls.Add(this.label2);
            this.grBoxThongTinLop.Controls.Add(this.label1);
            this.grBoxThongTinLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grBoxThongTinLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.grBoxThongTinLop.Location = new System.Drawing.Point(232, 80);
            this.grBoxThongTinLop.Name = "grBoxThongTinLop";
            this.grBoxThongTinLop.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.grBoxThongTinLop.Size = new System.Drawing.Size(1035, 277);
            this.grBoxThongTinLop.TabIndex = 1;
            this.grBoxThongTinLop.TabStop = false;
            this.grBoxThongTinLop.Text = "Thông tin lớp";
            // 
            // grBoxThemLop
            // 
            this.grBoxThemLop.Controls.Add(this.btnHuyThemLop);
            this.grBoxThemLop.Controls.Add(this.btnXacNhan);
            this.grBoxThemLop.Controls.Add(this.txbThemSiSoLop);
            this.grBoxThemLop.Controls.Add(this.txbThemTenLop);
            this.grBoxThemLop.Controls.Add(this.label5);
            this.grBoxThemLop.Controls.Add(this.label4);
            this.grBoxThemLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grBoxThemLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.grBoxThemLop.Location = new System.Drawing.Point(12, 55);
            this.grBoxThemLop.Name = "grBoxThemLop";
            this.grBoxThemLop.Size = new System.Drawing.Size(292, 209);
            this.grBoxThemLop.TabIndex = 6;
            this.grBoxThemLop.TabStop = false;
            this.grBoxThemLop.Text = "Nhập thông tin lớp";
            // 
            // btnHuyThemLop
            // 
            this.btnHuyThemLop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnHuyThemLop.ButtonImage = null;
            this.btnHuyThemLop.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnHuyThemLop.ButtonText = "Hủy";
            this.btnHuyThemLop.ClickBackColor = System.Drawing.Color.Gray;
            this.btnHuyThemLop.ClickTextColor = System.Drawing.Color.Lime;
            this.btnHuyThemLop.CornerRadius = 5;
            this.btnHuyThemLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyThemLop.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnHuyThemLop.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHuyThemLop.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.btnHuyThemLop.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnHuyThemLop.Location = new System.Drawing.Point(164, 140);
            this.btnHuyThemLop.Name = "btnHuyThemLop";
            this.btnHuyThemLop.Size = new System.Drawing.Size(122, 52);
            this.btnHuyThemLop.TabIndex = 7;
            this.btnHuyThemLop.TextColor = System.Drawing.Color.Lime;
            this.btnHuyThemLop.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnHuyThemLop.Click += new System.EventHandler(this.btnHuyThemLop_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnXacNhan.ButtonImage = null;
            this.btnXacNhan.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnXacNhan.ButtonText = "Xác nhận";
            this.btnXacNhan.ClickBackColor = System.Drawing.Color.Gray;
            this.btnXacNhan.ClickTextColor = System.Drawing.Color.Lime;
            this.btnXacNhan.CornerRadius = 5;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacNhan.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXacNhan.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXacNhan.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.btnXacNhan.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnXacNhan.Location = new System.Drawing.Point(26, 142);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(122, 52);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.TextColor = System.Drawing.Color.Lime;
            this.btnXacNhan.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txbThemSiSoLop
            // 
            this.txbThemSiSoLop.Location = new System.Drawing.Point(164, 95);
            this.txbThemSiSoLop.Name = "txbThemSiSoLop";
            this.txbThemSiSoLop.Size = new System.Drawing.Size(122, 30);
            this.txbThemSiSoLop.TabIndex = 3;
            // 
            // txbThemTenLop
            // 
            this.txbThemTenLop.Location = new System.Drawing.Point(164, 45);
            this.txbThemTenLop.Name = "txbThemTenLop";
            this.txbThemTenLop.Size = new System.Drawing.Size(122, 30);
            this.txbThemTenLop.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(8, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhập sỉ số lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(8, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập tên lớp:";
            // 
            // txbId
            // 
            this.txbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbId.Location = new System.Drawing.Point(129, 60);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(174, 30);
            this.txbId.TabIndex = 5;
            // 
            // txbSiso
            // 
            this.txbSiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSiso.Location = new System.Drawing.Point(129, 197);
            this.txbSiso.Name = "txbSiso";
            this.txbSiso.Size = new System.Drawing.Size(174, 30);
            this.txbSiso.TabIndex = 4;
            // 
            // txbTenLop
            // 
            this.txbTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbTenLop.Location = new System.Drawing.Point(129, 131);
            this.txbTenLop.Name = "txbTenLop";
            this.txbTenLop.Size = new System.Drawing.Size(174, 30);
            this.txbTenLop.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(33, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sỉ số:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(33, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(33, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "iDlop:";
            // 
            // grBoxDsLop
            // 
            this.grBoxDsLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxDsLop.Controls.Add(this.dtgvDanhSachLop);
            this.grBoxDsLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grBoxDsLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.grBoxDsLop.Location = new System.Drawing.Point(16, 375);
            this.grBoxDsLop.Name = "grBoxDsLop";
            this.grBoxDsLop.Size = new System.Drawing.Size(1249, 312);
            this.grBoxDsLop.TabIndex = 2;
            this.grBoxDsLop.TabStop = false;
            this.grBoxDsLop.Text = "Danh sách lớp";
            // 
            // dtgvDanhSachLop
            // 
            this.dtgvDanhSachLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSachLop.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvDanhSachLop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvDanhSachLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDanhSachLop.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDanhSachLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhSachLop.Location = new System.Drawing.Point(3, 35);
            this.dtgvDanhSachLop.Name = "dtgvDanhSachLop";
            this.dtgvDanhSachLop.RowHeadersWidth = 62;
            this.dtgvDanhSachLop.RowTemplate.Height = 28;
            this.dtgvDanhSachLop.Size = new System.Drawing.Size(1243, 274);
            this.dtgvDanhSachLop.TabIndex = 0;
            // 
            // imgbutton
            // 
            this.imgbutton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgbutton.ImageStream")));
            this.imgbutton.TransparentColor = System.Drawing.Color.Transparent;
            this.imgbutton.Images.SetKeyName(0, "add1.png");
            this.imgbutton.Images.SetKeyName(1, "add.png");
            this.imgbutton.Images.SetKeyName(2, "update.png");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(20, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(204, 277);
            this.panel1.TabIndex = 8;
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
            this.btnLuu.Location = new System.Drawing.Point(18, 185);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(166, 49);
            this.btnLuu.TabIndex = 4;
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
            this.btnSua.Location = new System.Drawing.Point(18, 129);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(166, 49);
            this.btnSua.TabIndex = 3;
            this.btnSua.TextColor = System.Drawing.Color.Lime;
            this.btnSua.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(18, 74);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(166, 49);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.TextColor = System.Drawing.Color.Lime;
            this.btnXoa.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnThem.Location = new System.Drawing.Point(18, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(166, 49);
            this.btnThem.TabIndex = 1;
            this.btnThem.TextColor = System.Drawing.Color.Lime;
            this.btnThem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1281, 71);
            this.panel2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label6.Location = new System.Drawing.Point(438, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 40);
            this.label6.TabIndex = 0;
            this.label6.Text = "QUẢN LÍ LỚP HỌC";
            // 
            // frmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1281, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grBoxDsLop);
            this.Controls.Add(this.grBoxThongTinLop);
            this.Name = "frmLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Lớp Học";
            this.grBoxThongTinLop.ResumeLayout(false);
            this.grBoxThongTinLop.PerformLayout();
            this.grBoxThemLop.ResumeLayout(false);
            this.grBoxThemLop.PerformLayout();
            this.grBoxDsLop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachLop)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grBoxThongTinLop;
        private System.Windows.Forms.GroupBox grBoxDsLop;
        private System.Windows.Forms.DataGridView dtgvDanhSachLop;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.TextBox txbSiso;
        private System.Windows.Forms.TextBox txbTenLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grBoxThemLop;
        private System.Windows.Forms.TextBox txbThemSiSoLop;
        private System.Windows.Forms.TextBox txbThemTenLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imgbutton;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton btnThem;
        private XanderUI.XUIButton btnLuu;
        private XanderUI.XUIButton btnSua;
        private XanderUI.XUIButton btnXoa;
        private XanderUI.XUIButton btnHuyThemLop;
        private XanderUI.XUIButton btnXacNhan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
    }
}
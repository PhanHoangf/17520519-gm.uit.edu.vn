namespace WindowsFormsApp1
{
    partial class frmTongKetHocKi
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
            this.btnXuatExcel = new XanderUI.XUIButton();
            this.btnXem = new XanderUI.XUIButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbHocKi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDanhSachLop = new System.Windows.Forms.ComboBox();
            this.Lớp = new System.Windows.Forms.Label();
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.dtgvTongKetHocKi = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.xuiCustomGroupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTongKetHocKi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 70);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG TỔNG KẾT HỌC KÌ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXuatExcel);
            this.panel2.Controls.Add(this.btnXem);
            this.panel2.Location = new System.Drawing.Point(12, 76);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(235, 163);
            this.panel2.TabIndex = 5;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnXuatExcel.ButtonImage = null;
            this.btnXuatExcel.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnXuatExcel.ButtonText = "Xuất excel";
            this.btnXuatExcel.ClickBackColor = System.Drawing.Color.Gray;
            this.btnXuatExcel.ClickTextColor = System.Drawing.Color.Lime;
            this.btnXuatExcel.CornerRadius = 5;
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatExcel.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXuatExcel.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXuatExcel.HoverTextColor = System.Drawing.Color.LavenderBlush;
            this.btnXuatExcel.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnXuatExcel.Location = new System.Drawing.Point(23, 90);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(189, 50);
            this.btnXuatExcel.TabIndex = 14;
            this.btnXuatExcel.TextColor = System.Drawing.Color.Lime;
            this.btnXuatExcel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
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
            this.btnXem.Location = new System.Drawing.Point(23, 23);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(189, 50);
            this.btnXem.TabIndex = 13;
            this.btnXem.TextColor = System.Drawing.Color.Lime;
            this.btnXem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbHocKi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbDanhSachLop);
            this.groupBox1.Controls.Add(this.Lớp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.groupBox1.Location = new System.Drawing.Point(254, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 163);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // cbHocKi
            // 
            this.cbHocKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbHocKi.FormattingEnabled = true;
            this.cbHocKi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbHocKi.Location = new System.Drawing.Point(314, 107);
            this.cbHocKi.Name = "cbHocKi";
            this.cbHocKi.Size = new System.Drawing.Size(164, 33);
            this.cbHocKi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(222, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Học kì:";
            // 
            // cbDanhSachLop
            // 
            this.cbDanhSachLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDanhSachLop.FormattingEnabled = true;
            this.cbDanhSachLop.Location = new System.Drawing.Point(314, 49);
            this.cbDanhSachLop.Name = "cbDanhSachLop";
            this.cbDanhSachLop.Size = new System.Drawing.Size(164, 33);
            this.cbDanhSachLop.TabIndex = 2;
            // 
            // Lớp
            // 
            this.Lớp.AutoSize = true;
            this.Lớp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Lớp.Location = new System.Drawing.Point(222, 53);
            this.Lớp.Name = "Lớp";
            this.Lớp.Size = new System.Drawing.Size(60, 29);
            this.Lớp.TabIndex = 0;
            this.Lớp.Text = "Lớp:";
            // 
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.dtgvTongKetHocKi);
            this.xuiCustomGroupbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xuiCustomGroupbox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(13, 245);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(1124, 452);
            this.xuiCustomGroupbox1.TabIndex = 7;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.Text = "Danh sách";
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            // 
            // dtgvTongKetHocKi
            // 
            this.dtgvTongKetHocKi.AllowUserToAddRows = false;
            this.dtgvTongKetHocKi.AllowUserToDeleteRows = false;
            this.dtgvTongKetHocKi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTongKetHocKi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvTongKetHocKi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTongKetHocKi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTongKetHocKi.Location = new System.Drawing.Point(3, 31);
            this.dtgvTongKetHocKi.Name = "dtgvTongKetHocKi";
            this.dtgvTongKetHocKi.ReadOnly = true;
            this.dtgvTongKetHocKi.RowHeadersWidth = 62;
            this.dtgvTongKetHocKi.RowTemplate.Height = 28;
            this.dtgvTongKetHocKi.Size = new System.Drawing.Size(1118, 418);
            this.dtgvTongKetHocKi.TabIndex = 2;
            // 
            // frmTongKetHocKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1149, 700);
            this.Controls.Add(this.xuiCustomGroupbox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTongKetHocKi";
            this.Text = "frmTongKetHocKi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTongKetHocKi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private XanderUI.XUIButton btnXuatExcel;
        private XanderUI.XUIButton btnXem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbHocKi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDanhSachLop;
        private System.Windows.Forms.Label Lớp;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private System.Windows.Forms.DataGridView dtgvTongKetHocKi;
    }
}
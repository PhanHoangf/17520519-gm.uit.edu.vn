namespace WindowsFormsApp1
{
    partial class frmTongKetMon
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
            this.dtgvTongKetMon = new System.Windows.Forms.DataGridView();
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbHocKi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSoDat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDanhSachMon = new System.Windows.Forms.ComboBox();
            this.cbDanhSachLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lớp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXuatExcel = new XanderUI.XUIButton();
            this.btnXem = new XanderUI.XUIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTongKetMon)).BeginInit();
            this.xuiCustomGroupbox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvTongKetMon
            // 
            this.dtgvTongKetMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTongKetMon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvTongKetMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTongKetMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTongKetMon.Location = new System.Drawing.Point(2, 21);
            this.dtgvTongKetMon.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvTongKetMon.Name = "dtgvTongKetMon";
            this.dtgvTongKetMon.ReadOnly = true;
            this.dtgvTongKetMon.RowHeadersWidth = 62;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtgvTongKetMon.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTongKetMon.RowTemplate.Height = 28;
            this.dtgvTongKetMon.Size = new System.Drawing.Size(745, 296);
            this.dtgvTongKetMon.TabIndex = 0;
            this.dtgvTongKetMon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTongKetMon_CellContentClick);
            // 
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.dtgvTongKetMon);
            this.xuiCustomGroupbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xuiCustomGroupbox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(9, 168);
            this.xuiCustomGroupbox1.Margin = new System.Windows.Forms.Padding(2);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.Padding = new System.Windows.Forms.Padding(2);
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(749, 319);
            this.xuiCustomGroupbox1.TabIndex = 1;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.Text = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 45);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(209, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG TỔNG KẾT MÔN HỌC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbHocKi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblSoDat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbDanhSachMon);
            this.groupBox1.Controls.Add(this.cbDanhSachLop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Lớp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.groupBox1.Location = new System.Drawing.Point(169, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(589, 106);
            this.groupBox1.TabIndex = 3;
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
            this.cbHocKi.Location = new System.Drawing.Point(467, 70);
            this.cbHocKi.Margin = new System.Windows.Forms.Padding(2);
            this.cbHocKi.Name = "cbHocKi";
            this.cbHocKi.Size = new System.Drawing.Size(111, 24);
            this.cbHocKi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(389, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Học kì:";
            // 
            // lblSoDat
            // 
            this.lblSoDat.AutoSize = true;
            this.lblSoDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoDat.Location = new System.Drawing.Point(237, 74);
            this.lblSoDat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoDat.Name = "lblSoDat";
            this.lblSoDat.Size = new System.Drawing.Size(46, 17);
            this.lblSoDat.TabIndex = 5;
            this.lblSoDat.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(148, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số HS đạt:";
            // 
            // cbDanhSachMon
            // 
            this.cbDanhSachMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDanhSachMon.FormattingEnabled = true;
            this.cbDanhSachMon.Location = new System.Drawing.Point(467, 32);
            this.cbDanhSachMon.Margin = new System.Windows.Forms.Padding(2);
            this.cbDanhSachMon.Name = "cbDanhSachMon";
            this.cbDanhSachMon.Size = new System.Drawing.Size(111, 24);
            this.cbDanhSachMon.TabIndex = 3;
            // 
            // cbDanhSachLop
            // 
            this.cbDanhSachLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDanhSachLop.FormattingEnabled = true;
            this.cbDanhSachLop.Location = new System.Drawing.Point(192, 32);
            this.cbDanhSachLop.Margin = new System.Windows.Forms.Padding(2);
            this.cbDanhSachLop.Name = "cbDanhSachLop";
            this.cbDanhSachLop.Size = new System.Drawing.Size(111, 24);
            this.cbDanhSachLop.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(389, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Môn học:";
            // 
            // Lớp
            // 
            this.Lớp.AutoSize = true;
            this.Lớp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Lớp.Location = new System.Drawing.Point(148, 34);
            this.Lớp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lớp.Name = "Lớp";
            this.Lớp.Size = new System.Drawing.Size(40, 20);
            this.Lớp.TabIndex = 0;
            this.Lớp.Text = "Lớp:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXuatExcel);
            this.panel2.Controls.Add(this.btnXem);
            this.panel2.Location = new System.Drawing.Point(9, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(13);
            this.panel2.Size = new System.Drawing.Size(157, 106);
            this.panel2.TabIndex = 4;
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
            this.btnXuatExcel.Location = new System.Drawing.Point(15, 58);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(126, 32);
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
            this.btnXem.Location = new System.Drawing.Point(15, 15);
            this.btnXem.Margin = new System.Windows.Forms.Padding(2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(126, 32);
            this.btnXem.TabIndex = 13;
            this.btnXem.TextColor = System.Drawing.Color.Lime;
            this.btnXem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // frmTongKetMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(766, 498);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xuiCustomGroupbox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTongKetMon";
            this.Text = "fTongKetMon";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTongKetMon)).EndInit();
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTongKetMon;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private XanderUI.XUIButton btnXuatExcel;
        private XanderUI.XUIButton btnXem;
        private System.Windows.Forms.ComboBox cbDanhSachMon;
        private System.Windows.Forms.ComboBox cbDanhSachLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lớp;
        private System.Windows.Forms.Label lblSoDat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHocKi;
        private System.Windows.Forms.Label label4;
    }
}
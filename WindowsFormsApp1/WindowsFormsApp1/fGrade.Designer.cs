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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpKhoi10 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flpKhoi11 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flpKhoi12 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDsKhoiLop
            // 
            this.lblDsKhoiLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDsKhoiLop.AutoSize = true;
            this.lblDsKhoiLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDsKhoiLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDsKhoiLop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDsKhoiLop.Location = new System.Drawing.Point(114, 9);
            this.lblDsKhoiLop.Name = "lblDsKhoiLop";
            this.lblDsKhoiLop.Size = new System.Drawing.Size(583, 58);
            this.lblDsKhoiLop.TabIndex = 0;
            this.lblDsKhoiLop.Text = "DANH SÁCH KHỐI LỚP";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.flpKhoi10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(13, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 521);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khối 10";
            // 
            // flpKhoi10
            // 
            this.flpKhoi10.AutoScroll = true;
            this.flpKhoi10.Location = new System.Drawing.Point(7, 30);
            this.flpKhoi10.Name = "flpKhoi10";
            this.flpKhoi10.Size = new System.Drawing.Size(227, 485);
            this.flpKhoi10.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(577, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(173, 72);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnQuay_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flpKhoi11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(279, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 521);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khối 11";
            // 
            // flpKhoi11
            // 
            this.flpKhoi11.AutoScroll = true;
            this.flpKhoi11.Location = new System.Drawing.Point(6, 30);
            this.flpKhoi11.Name = "flpKhoi11";
            this.flpKhoi11.Size = new System.Drawing.Size(227, 485);
            this.flpKhoi11.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flpKhoi12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(539, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 521);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Khối 12";
            // 
            // flpKhoi12
            // 
            this.flpKhoi12.AutoScroll = true;
            this.flpKhoi12.Location = new System.Drawing.Point(7, 30);
            this.flpKhoi12.Name = "flpKhoi12";
            this.flpKhoi12.Size = new System.Drawing.Size(227, 485);
            this.flpKhoi12.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Location = new System.Drawing.Point(20, 620);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 72);
            this.panel1.TabIndex = 5;
            // 
            // tbnXoa
            // 
            this.tbnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbnXoa.Location = new System.Drawing.Point(388, 0);
            this.tbnXoa.Name = "tbnXoa";
            this.tbnXoa.Size = new System.Drawing.Size(173, 72);
            this.tbnXoa.TabIndex = 5;
            this.tbnXoa.Text = "Xóa";
            this.tbnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(197, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(173, 72);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Thêm";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXem.Location = new System.Drawing.Point(3, 0);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(173, 72);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // fGrade
            // 
            this.AcceptButton = this.btnXem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(791, 704);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDsKhoiLop);
            this.Name = "fGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDsKhoiLop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.FlowLayoutPanel flpKhoi10;
        private System.Windows.Forms.FlowLayoutPanel flpKhoi11;
        private System.Windows.Forms.FlowLayoutPanel flpKhoi12;
        private System.Windows.Forms.Button tbnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}
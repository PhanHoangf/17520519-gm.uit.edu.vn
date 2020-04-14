namespace WindowsFormsApp1
{
    partial class Inserths
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txbgioitinh = new System.Windows.Forms.TextBox();
            this.txbidlop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.txbdiachi = new System.Windows.Forms.TextBox();
            this.txbhoten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txbgioitinh);
            this.panel1.Controls.Add(this.txbidlop);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txbemail);
            this.panel1.Controls.Add(this.txbdiachi);
            this.panel1.Controls.Add(this.txbhoten);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 460);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 163);
            this.dateTimePicker1.MaxDate = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 26);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.Value = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            // 
            // txbgioitinh
            // 
            this.txbgioitinh.Location = new System.Drawing.Point(641, 95);
            this.txbgioitinh.Name = "txbgioitinh";
            this.txbgioitinh.Size = new System.Drawing.Size(82, 26);
            this.txbgioitinh.TabIndex = 15;
            // 
            // txbidlop
            // 
            this.txbidlop.Enabled = false;
            this.txbidlop.Location = new System.Drawing.Point(607, 163);
            this.txbidlop.Name = "txbidlop";
            this.txbidlop.Size = new System.Drawing.Size(43, 26);
            this.txbidlop.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(505, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "ID lớp:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnhuy);
            this.panel2.Controls.Add(this.btnluu);
            this.panel2.Location = new System.Drawing.Point(487, 357);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 100);
            this.panel2.TabIndex = 12;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(276, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 94);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(140, 3);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(130, 94);
            this.btnhuy.TabIndex = 1;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(4, 3);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(130, 94);
            this.btnluu.TabIndex = 0;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(505, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Giới tính:";
            // 
            // txbemail
            // 
            this.txbemail.Location = new System.Drawing.Point(191, 328);
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(241, 26);
            this.txbemail.TabIndex = 8;
            // 
            // txbdiachi
            // 
            this.txbdiachi.Location = new System.Drawing.Point(191, 239);
            this.txbdiachi.Name = "txbdiachi";
            this.txbdiachi.Size = new System.Drawing.Size(241, 26);
            this.txbdiachi.TabIndex = 7;
            // 
            // txbhoten
            // 
            this.txbhoten.Location = new System.Drawing.Point(191, 90);
            this.txbhoten.Name = "txbhoten";
            this.txbhoten.Size = new System.Drawing.Size(241, 26);
            this.txbhoten.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(12, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(12, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm học sinh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inserths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 460);
            this.Controls.Add(this.panel1);
            this.Name = "Inserths";
            this.Text = "Inserths";
            this.Load += new System.EventHandler(this.Inserths_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.TextBox txbdiachi;
        private System.Windows.Forms.TextBox txbhoten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbidlop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbgioitinh;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
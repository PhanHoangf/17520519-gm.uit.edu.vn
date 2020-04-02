namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.lbTk = new System.Windows.Forms.Label();
            this.lbMk = new System.Windows.Forms.Label();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDangNhap.Location = new System.Drawing.Point(98, 9);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(153, 35);
            this.lbDangNhap.TabIndex = 0;
            this.lbDangNhap.Text = "Đăng nhập";
            // 
            // lbTk
            // 
            this.lbTk.AutoSize = true;
            this.lbTk.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTk.Location = new System.Drawing.Point(13, 66);
            this.lbTk.Name = "lbTk";
            this.lbTk.Size = new System.Drawing.Size(94, 22);
            this.lbTk.TabIndex = 1;
            this.lbTk.Text = "Tài khoản:";
            // 
            // lbMk
            // 
            this.lbMk.AutoSize = true;
            this.lbMk.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMk.Location = new System.Drawing.Point(17, 107);
            this.lbMk.Name = "lbMk";
            this.lbMk.Size = new System.Drawing.Size(88, 22);
            this.lbMk.TabIndex = 2;
            this.lbMk.Text = "Mật khẩu:";
            // 
            // txtTk
            // 
            this.txtTk.Location = new System.Drawing.Point(114, 66);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(182, 26);
            this.txtTk.TabIndex = 3;
            // 
            // txtMk
            // 
            this.txtMk.Location = new System.Drawing.Point(114, 102);
            this.txtMk.Name = "txtMk";
            this.txtMk.Size = new System.Drawing.Size(182, 26);
            this.txtMk.TabIndex = 4;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AutoSize = true;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangNhap.Location = new System.Drawing.Point(52, 167);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(108, 42);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.Location = new System.Drawing.Point(195, 167);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 42);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 235);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMk);
            this.Controls.Add(this.txtTk);
            this.Controls.Add(this.lbMk);
            this.Controls.Add(this.lbTk);
            this.Controls.Add(this.lbDangNhap);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.Label lbTk;
        private System.Windows.Forms.Label lbMk;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
    }
}


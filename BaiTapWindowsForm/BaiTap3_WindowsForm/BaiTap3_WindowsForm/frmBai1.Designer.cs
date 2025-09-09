namespace BaiTap3_WindowsForm
{
    partial class frmBai1
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
            this.btnHienThi = new System.Windows.Forms.Button();
            this.txtTongLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTongLuong = new System.Windows.Forms.Button();
            this.txtHeSoPhuCap = new System.Windows.Forms.TextBox();
            this.txtHeSoLuong = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rtxtHienThi = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(498, 84);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(100, 35);
            this.btnHienThi.TabIndex = 30;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // txtTongLuong
            // 
            this.txtTongLuong.Location = new System.Drawing.Point(222, 355);
            this.txtTongLuong.Name = "txtTongLuong";
            this.txtTongLuong.Size = new System.Drawing.Size(192, 22);
            this.txtTongLuong.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tổng lương:";
            // 
            // btnTongLuong
            // 
            this.btnTongLuong.Location = new System.Drawing.Point(289, 305);
            this.btnTongLuong.Name = "btnTongLuong";
            this.btnTongLuong.Size = new System.Drawing.Size(91, 36);
            this.btnTongLuong.TabIndex = 27;
            this.btnTongLuong.Text = "Xem kết quả";
            this.btnTongLuong.UseVisualStyleBackColor = true;
            this.btnTongLuong.Click += new System.EventHandler(this.btnTongLuong_Click);
            // 
            // txtHeSoPhuCap
            // 
            this.txtHeSoPhuCap.Location = new System.Drawing.Point(222, 263);
            this.txtHeSoPhuCap.Name = "txtHeSoPhuCap";
            this.txtHeSoPhuCap.Size = new System.Drawing.Size(192, 22);
            this.txtHeSoPhuCap.TabIndex = 26;
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Location = new System.Drawing.Point(222, 221);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.Size = new System.Drawing.Size(192, 22);
            this.txtHeSoLuong.TabIndex = 25;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(222, 141);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(192, 22);
            this.txtHoTen.TabIndex = 23;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(222, 100);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(192, 22);
            this.txtMaNhanVien.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Hệ số phụ cấp ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Hệ số lương:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Họ và tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã nhân viên:";
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThi.Location = new System.Drawing.Point(88, 48);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(209, 25);
            this.lblHienThi.TabIndex = 16;
            this.lblHienThi.Text = "Thông tin nhân viên ";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(222, 180);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaySinh.TabIndex = 32;
            // 
            // rtxtHienThi
            // 
            this.rtxtHienThi.Location = new System.Drawing.Point(498, 141);
            this.rtxtHienThi.Name = "rtxtHienThi";
            this.rtxtHienThi.Size = new System.Drawing.Size(186, 144);
            this.rtxtHienThi.TabIndex = 31;
            this.rtxtHienThi.Text = "";
            this.rtxtHienThi.TextChanged += new System.EventHandler(this.rtxtHienThi_TextChanged);
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.rtxtHienThi);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.txtTongLuong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTongLuong);
            this.Controls.Add(this.txtHeSoPhuCap);
            this.Controls.Add(this.txtHeSoLuong);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHienThi);
            this.Name = "frmBai1";
            this.Text = "frmBai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.TextBox txtTongLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTongLuong;
        private System.Windows.Forms.TextBox txtHeSoPhuCap;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RichTextBox rtxtHienThi;
    }
}
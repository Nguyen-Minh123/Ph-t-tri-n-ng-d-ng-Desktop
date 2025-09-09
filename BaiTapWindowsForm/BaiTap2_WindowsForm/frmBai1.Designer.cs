namespace BaiTapWindowsForm_Bai2
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
            this.lblHienThi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaThietBi = new System.Windows.Forms.TextBox();
            this.txtTenThietBi = new System.Windows.Forms.TextBox();
            this.txtNuocSanXuat = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnThanhTien = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.rtxtHienThi = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThi.Location = new System.Drawing.Point(64, 27);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(179, 25);
            this.lblHienThi.TabIndex = 0;
            this.lblHienThi.Text = "Thông tin thiết bị ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Thiết Bị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Thiết Bị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nước Sản Xuất";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đơn Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số Lượng ";
            // 
            // txtMaThietBi
            // 
            this.txtMaThietBi.Location = new System.Drawing.Point(198, 79);
            this.txtMaThietBi.Name = "txtMaThietBi";
            this.txtMaThietBi.Size = new System.Drawing.Size(192, 22);
            this.txtMaThietBi.TabIndex = 6;
            this.txtMaThietBi.TextChanged += new System.EventHandler(this.txtMaThietBi_TextChanged);
            // 
            // txtTenThietBi
            // 
            this.txtTenThietBi.Location = new System.Drawing.Point(198, 120);
            this.txtTenThietBi.Name = "txtTenThietBi";
            this.txtTenThietBi.Size = new System.Drawing.Size(192, 22);
            this.txtTenThietBi.TabIndex = 7;
            // 
            // txtNuocSanXuat
            // 
            this.txtNuocSanXuat.Location = new System.Drawing.Point(198, 156);
            this.txtNuocSanXuat.Name = "txtNuocSanXuat";
            this.txtNuocSanXuat.Size = new System.Drawing.Size(192, 22);
            this.txtNuocSanXuat.TabIndex = 8;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(198, 200);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(192, 22);
            this.txtDonGia.TabIndex = 9;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(198, 242);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(192, 22);
            this.txtSoLuong.TabIndex = 10;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // btnThanhTien
            // 
            this.btnThanhTien.Location = new System.Drawing.Point(265, 284);
            this.btnThanhTien.Name = "btnThanhTien";
            this.btnThanhTien.Size = new System.Drawing.Size(91, 36);
            this.btnThanhTien.TabIndex = 11;
            this.btnThanhTien.Text = "Tính Tiền";
            this.btnThanhTien.UseVisualStyleBackColor = true;
            this.btnThanhTien.Click += new System.EventHandler(this.btnThanhTien_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Thành Tiền ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(198, 334);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(192, 22);
            this.txtThanhTien.TabIndex = 13;
            this.txtThanhTien.TextChanged += new System.EventHandler(this.txtThanhTien_TextChanged);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(474, 63);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(100, 35);
            this.btnHienThi.TabIndex = 14;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // rtxtHienThi
            // 
            this.rtxtHienThi.Location = new System.Drawing.Point(474, 120);
            this.rtxtHienThi.Name = "rtxtHienThi";
            this.rtxtHienThi.Size = new System.Drawing.Size(186, 144);
            this.rtxtHienThi.TabIndex = 15;
            this.rtxtHienThi.Text = "";
            this.rtxtHienThi.TextChanged += new System.EventHandler(this.rtxtHienThi_TextChanged);
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxtHienThi);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThanhTien);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtNuocSanXuat);
            this.Controls.Add(this.txtTenThietBi);
            this.Controls.Add(this.txtMaThietBi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHienThi);
            this.Name = "frmBai1";
            this.Text = "Bài 1";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaThietBi;
        private System.Windows.Forms.TextBox txtTenThietBi;
        private System.Windows.Forms.TextBox txtNuocSanXuat;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnThanhTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.RichTextBox rtxtHienThi;
    }
}
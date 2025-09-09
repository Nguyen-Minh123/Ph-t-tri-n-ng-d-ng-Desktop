using System;

namespace BaiTap4_WindowsForm
{
    partial class frmBai3
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

        private void InitializeComponent()
        {
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lblSoM = new System.Windows.Forms.Label();
            this.txtSoM = new System.Windows.Forms.TextBox();
            this.lblSoN = new System.Windows.Forms.Label();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(18, 40);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(49, 16);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(88, 38);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(18, 72);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(57, 16);
            this.lblGioiTinh.TabIndex = 2;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(88, 70);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(200, 22);
            this.txtGioiTinh.TabIndex = 3;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(308, 52);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(94, 23);
            this.btnNhap.TabIndex = 4;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lblSoM
            // 
            this.lblSoM.AutoSize = true;
            this.lblSoM.Location = new System.Drawing.Point(25, 38);
            this.lblSoM.Name = "lblSoM";
            this.lblSoM.Size = new System.Drawing.Size(41, 16);
            this.lblSoM.TabIndex = 5;
            this.lblSoM.Text = "Số m:";
            // 
            // txtSoM
            // 
            this.txtSoM.Location = new System.Drawing.Point(95, 36);
            this.txtSoM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoM.Name = "txtSoM";
            this.txtSoM.Size = new System.Drawing.Size(100, 22);
            this.txtSoM.TabIndex = 6;
            // 
            // lblSoN
            // 
            this.lblSoN.AutoSize = true;
            this.lblSoN.Location = new System.Drawing.Point(215, 38);
            this.lblSoN.Name = "lblSoN";
            this.lblSoN.Size = new System.Drawing.Size(37, 16);
            this.lblSoN.TabIndex = 7;
            this.lblSoN.Text = "Số n:";
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(275, 36);
            this.txtSoN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(100, 22);
            this.txtSoN.TabIndex = 8;
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(395, 34);
            this.btnKetQua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(112, 49);
            this.btnKetQua.TabIndex = 9;
            this.btnKetQua.Text = "Xem kết quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(25, 78);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(55, 16);
            this.lblKetQua.TabIndex = 10;
            this.lblKetQua.Text = "Kết quả:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.lblGioiTinh);
            this.groupBox1.Controls.Add(this.txtGioiTinh);
            this.groupBox1.Controls.Add(this.btnNhap);
            this.groupBox1.Location = new System.Drawing.Point(36, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 130);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chào hỏi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSoM);
            this.groupBox2.Controls.Add(this.txtSoM);
            this.groupBox2.Controls.Add(this.lblKetQua);
            this.groupBox2.Controls.Add(this.lblSoN);
            this.groupBox2.Controls.Add(this.btnKetQua);
            this.groupBox2.Controls.Add(this.txtSoN);
            this.groupBox2.Location = new System.Drawing.Point(36, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 130);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm UCLN";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 422);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.Load += new System.EventHandler(this.frmBai3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

    
        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label lblSoM;
        private System.Windows.Forms.TextBox txtSoM;
        private System.Windows.Forms.Label lblSoN;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
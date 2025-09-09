namespace BaiTap3_WindowsForm
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
            this.btnTachChuoi = new System.Windows.Forms.Button();
            this.lblHo = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblSoN1 = new System.Windows.Forms.Label();
            this.txtSoN1 = new System.Windows.Forms.TextBox();
            this.lblSoN2 = new System.Windows.Forms.Label();
            this.txtSoN2 = new System.Windows.Forms.TextBox();
            this.btnKiemTra = new System.Windows.Forms.Button();
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
            this.lblHoTen.Location = new System.Drawing.Point(6, 31);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(49, 16);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(76, 29);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(250, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // btnTachChuoi
            // 
            this.btnTachChuoi.Location = new System.Drawing.Point(346, 27);
            this.btnTachChuoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTachChuoi.Name = "btnTachChuoi";
            this.btnTachChuoi.Size = new System.Drawing.Size(94, 23);
            this.btnTachChuoi.TabIndex = 2;
            this.btnTachChuoi.Text = "Tách chuỗi";
            this.btnTachChuoi.UseVisualStyleBackColor = true;
            this.btnTachChuoi.Click += new System.EventHandler(this.btnTachChuoi_Click);
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Location = new System.Drawing.Point(6, 67);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(28, 16);
            this.lblHo.TabIndex = 3;
            this.lblHo.Text = "Họ:";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(76, 65);
            this.txtHo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(150, 22);
            this.txtHo.TabIndex = 4;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(246, 67);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(34, 16);
            this.lblTen.TabIndex = 5;
            this.lblTen.Text = "Tên:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(296, 65);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(150, 22);
            this.txtTen.TabIndex = 6;
            // 
            // lblSoN1
            // 
            this.lblSoN1.AutoSize = true;
            this.lblSoN1.Location = new System.Drawing.Point(6, 27);
            this.lblSoN1.Name = "lblSoN1";
            this.lblSoN1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSoN1.Size = new System.Drawing.Size(44, 16);
            this.lblSoN1.TabIndex = 7;
            this.lblSoN1.Text = "Số n1:";
            // 
            // txtSoN1
            // 
            this.txtSoN1.Location = new System.Drawing.Point(76, 25);
            this.txtSoN1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoN1.Name = "txtSoN1";
            this.txtSoN1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSoN1.Size = new System.Drawing.Size(100, 22);
            this.txtSoN1.TabIndex = 8;
            // 
            // lblSoN2
            // 
            this.lblSoN2.AutoSize = true;
            this.lblSoN2.Location = new System.Drawing.Point(196, 27);
            this.lblSoN2.Name = "lblSoN2";
            this.lblSoN2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSoN2.Size = new System.Drawing.Size(44, 16);
            this.lblSoN2.TabIndex = 9;
            this.lblSoN2.Text = "Số n2:";
            // 
            // txtSoN2
            // 
            this.txtSoN2.Location = new System.Drawing.Point(266, 25);
            this.txtSoN2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoN2.Name = "txtSoN2";
            this.txtSoN2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSoN2.Size = new System.Drawing.Size(100, 22);
            this.txtSoN2.TabIndex = 10;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(386, 23);
            this.btnKiemTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnKiemTra.Size = new System.Drawing.Size(94, 23);
            this.btnKiemTra.TabIndex = 11;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(6, 67);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblKetQua.Size = new System.Drawing.Size(55, 16);
            this.lblKetQua.TabIndex = 12;
            this.lblKetQua.Text = "Kết quả:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.btnTachChuoi);
            this.groupBox1.Controls.Add(this.lblHo);
            this.groupBox1.Controls.Add(this.txtHo);
            this.groupBox1.Controls.Add(this.lblTen);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 157);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tách họ và  tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSoN1);
            this.groupBox2.Controls.Add(this.txtSoN1);
            this.groupBox2.Controls.Add(this.lblKetQua);
            this.groupBox2.Controls.Add(this.lblSoN2);
            this.groupBox2.Controls.Add(this.btnKiemTra);
            this.groupBox2.Controls.Add(this.txtSoN2);
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiểm tra 2 sô nguyên liên tiếp";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 379);
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
        private System.Windows.Forms.Button btnTachChuoi;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblSoN1;
        private System.Windows.Forms.TextBox txtSoN1;
        private System.Windows.Forms.Label lblSoN2;
        private System.Windows.Forms.TextBox txtSoN2;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

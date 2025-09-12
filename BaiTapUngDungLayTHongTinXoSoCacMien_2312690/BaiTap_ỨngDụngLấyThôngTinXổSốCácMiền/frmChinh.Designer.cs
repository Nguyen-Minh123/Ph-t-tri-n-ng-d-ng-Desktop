namespace BaiTap_ỨngDụngLấyThôngTinXổSốCácMiền
{
    partial class frmChinh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMienTrung = new System.Windows.Forms.Button();
            this.btnMienNam = new System.Windows.Forms.Button();
            this.btnMienBac = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMienTrung);
            this.groupBox1.Controls.Add(this.btnMienNam);
            this.groupBox1.Controls.Add(this.btnMienBac);
            this.groupBox1.Location = new System.Drawing.Point(112, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 269);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhấp vào đây để lấy thông tin xổ số các miền";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnMienTrung
            // 
            this.btnMienTrung.Location = new System.Drawing.Point(81, 120);
            this.btnMienTrung.Name = "btnMienTrung";
            this.btnMienTrung.Size = new System.Drawing.Size(109, 51);
            this.btnMienTrung.TabIndex = 9;
            this.btnMienTrung.Text = "Miền Trung";
            this.btnMienTrung.UseVisualStyleBackColor = true;
            this.btnMienTrung.Click += new System.EventHandler(this.btnMienTrung_Click);
            // 
            // btnMienNam
            // 
            this.btnMienNam.Location = new System.Drawing.Point(81, 41);
            this.btnMienNam.Name = "btnMienNam";
            this.btnMienNam.Size = new System.Drawing.Size(109, 50);
            this.btnMienNam.TabIndex = 7;
            this.btnMienNam.Text = "Miền Nam";
            this.btnMienNam.UseVisualStyleBackColor = true;
            this.btnMienNam.Click += new System.EventHandler(this.btnMienNam_Click);
            // 
            // btnMienBac
            // 
            this.btnMienBac.Location = new System.Drawing.Point(81, 197);
            this.btnMienBac.Name = "btnMienBac";
            this.btnMienBac.Size = new System.Drawing.Size(109, 50);
            this.btnMienBac.TabIndex = 8;
            this.btnMienBac.Text = "Miền Bắc";
            this.btnMienBac.UseVisualStyleBackColor = true;
            this.btnMienBac.Click += new System.EventHandler(this.btnMienBac_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 319);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChinh";
            this.Text = "Ứng dụng lấy thông tin xổ số các miền theo ngày";
            this.Load += new System.EventHandler(this.frmChinh_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMienTrung;
        private System.Windows.Forms.Button btnMienBac;
        private System.Windows.Forms.Button btnMienNam;
    }
}


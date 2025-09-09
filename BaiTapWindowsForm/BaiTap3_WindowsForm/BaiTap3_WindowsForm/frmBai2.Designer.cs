namespace BaiTap3_WindowsForm
{
    partial class frmBai2
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
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXemKq = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdGiaiThua = new System.Windows.Forms.RadioButton();
            this.rdTongTu1DenN = new System.Windows.Forms.RadioButton();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(204, 301);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(15, 24);
            this.lblKetQua.TabIndex = 19;
            this.lblKetQua.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 301);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Kết quả là:";
            // 
            // btnXemKq
            // 
            this.btnXemKq.Location = new System.Drawing.Point(131, 247);
            this.btnXemKq.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemKq.Name = "btnXemKq";
            this.btnXemKq.Size = new System.Drawing.Size(100, 28);
            this.btnXemKq.TabIndex = 17;
            this.btnXemKq.Text = "Xem kết quả";
            this.btnXemKq.UseVisualStyleBackColor = true;
            this.btnXemKq.Click += new System.EventHandler(this.btnXemKq_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdGiaiThua);
            this.groupBox1.Controls.Add(this.rdTongTu1DenN);
            this.groupBox1.Location = new System.Drawing.Point(108, 83);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 156);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn công việc";
            // 
            // rdGiaiThua
            // 
            this.rdGiaiThua.AutoSize = true;
            this.rdGiaiThua.Location = new System.Drawing.Point(23, 103);
            this.rdGiaiThua.Margin = new System.Windows.Forms.Padding(4);
            this.rdGiaiThua.Name = "rdGiaiThua";
            this.rdGiaiThua.Size = new System.Drawing.Size(141, 20);
            this.rdGiaiThua.TabIndex = 1;
            this.rdGiaiThua.Text = "Tính N giai thừa(N!)\r\n";
            this.rdGiaiThua.UseVisualStyleBackColor = true;
            this.rdGiaiThua.CheckedChanged += new System.EventHandler(this.rdGiaiThua_CheckedChanged);
            // 
            // rdTongTu1DenN
            // 
            this.rdTongTu1DenN.AutoSize = true;
            this.rdTongTu1DenN.Checked = true;
            this.rdTongTu1DenN.Location = new System.Drawing.Point(23, 43);
            this.rdTongTu1DenN.Margin = new System.Windows.Forms.Padding(4);
            this.rdTongTu1DenN.Name = "rdTongTu1DenN";
            this.rdTongTu1DenN.Size = new System.Drawing.Size(140, 52);
            this.rdTongTu1DenN.TabIndex = 0;
            this.rdTongTu1DenN.TabStop = true;
            this.rdTongTu1DenN.Text = "Tính tổng 1+2+...+N\r\n\r\n\r\n";
            this.rdTongTu1DenN.UseVisualStyleBackColor = true;
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(299, 37);
            this.txtSoN.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(132, 22);
            this.txtSoN.TabIndex = 15;
            this.txtSoN.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nhập một số nguyên dương N:";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXemKq);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.label3);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXemKq;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdGiaiThua;
        private System.Windows.Forms.RadioButton rdTongTu1DenN;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.Label label3;
    }
}
namespace BaiTapWindowsForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTongN = new System.Windows.Forms.RadioButton();
            this.rdTongAB = new System.Windows.Forms.RadioButton();
            this.btnXemKq = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "số a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "số b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "số n =";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(171, 137);
            this.txtSoA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(132, 22);
            this.txtSoA.TabIndex = 3;
            this.txtSoA.Text = "0";
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(171, 188);
            this.txtSoB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(132, 22);
            this.txtSoB.TabIndex = 4;
            this.txtSoB.Text = "0";
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(171, 239);
            this.txtSoN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(132, 22);
            this.txtSoN.TabIndex = 5;
            this.txtSoN.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTongN);
            this.groupBox1.Controls.Add(this.rdTongAB);
            this.groupBox1.Location = new System.Drawing.Point(80, 282);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(267, 123);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán";
            // 
            // rdTongN
            // 
            this.rdTongN.AutoSize = true;
            this.rdTongN.Location = new System.Drawing.Point(23, 95);
            this.rdTongN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdTongN.Name = "rdTongN";
            this.rdTongN.Size = new System.Drawing.Size(142, 20);
            this.rdTongN.TabIndex = 1;
            this.rdTongN.Text = "Tính tổng từ 1 dến n";
            this.rdTongN.UseVisualStyleBackColor = true;
            // 
            // rdTongAB
            // 
            this.rdTongAB.AutoSize = true;
            this.rdTongAB.Checked = true;
            this.rdTongAB.Location = new System.Drawing.Point(23, 37);
            this.rdTongAB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdTongAB.Name = "rdTongAB";
            this.rdTongAB.Size = new System.Drawing.Size(133, 20);
            this.rdTongAB.TabIndex = 0;
            this.rdTongAB.TabStop = true;
            this.rdTongAB.Text = "Tính tổng của a, b";
            this.rdTongAB.UseVisualStyleBackColor = true;
            this.rdTongAB.CheckedChanged += new System.EventHandler(this.rdTongAB_CheckedChanged);
            // 
            // btnXemKq
            // 
            this.btnXemKq.Location = new System.Drawing.Point(103, 426);
            this.btnXemKq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXemKq.Name = "btnXemKq";
            this.btnXemKq.Size = new System.Drawing.Size(100, 28);
            this.btnXemKq.TabIndex = 7;
            this.btnXemKq.Text = "Xem kết quả";
            this.btnXemKq.UseVisualStyleBackColor = true;
            this.btnXemKq.Click += new System.EventHandler(this.btnXemKq_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 485);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kết quả là:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(227, 485);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(15, 24);
            this.lblKetQua.TabIndex = 9;
            this.lblKetQua.Text = ".";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 554);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXemKq);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBai3";
            this.Text = "Bài 3";
            this.Load += new System.EventHandler(this.frmBai3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTongAB;
        private System.Windows.Forms.RadioButton rdTongN;
        private System.Windows.Forms.Button btnXemKq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKetQua;
    }
}
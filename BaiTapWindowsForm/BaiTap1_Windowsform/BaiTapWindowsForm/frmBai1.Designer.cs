namespace BaiTapWindowsForm
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
            this.lblHangHoa = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHangHoa
            // 
            this.lblHangHoa.AutoSize = true;
            this.lblHangHoa.Location = new System.Drawing.Point(68, 94);
            this.lblHangHoa.Name = "lblHangHoa";
            this.lblHangHoa.Size = new System.Drawing.Size(100, 13);
            this.lblHangHoa.TabIndex = 0;
            this.lblHangHoa.Text = "Thông tin hàng hóa";
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Location = new System.Drawing.Point(68, 149);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 13);
            this.lblThongBao.TabIndex = 1;
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.lblHangHoa);
            this.Name = "frmBai1";
            this.Text = "Bài 1";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHangHoa;
        private System.Windows.Forms.Label lblThongBao;
    }
}
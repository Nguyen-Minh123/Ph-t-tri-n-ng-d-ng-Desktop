namespace Baitapthietke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hoTenCuaSinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msibai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msiBai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.msiBai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.bai4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoTenCuaSinhVienToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hoTenCuaSinhVienToolStripMenuItem
            // 
            this.hoTenCuaSinhVienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msibai1,
            this.msiBai2,
            this.msiBai3,
            this.bai4ToolStripMenuItem});
            this.hoTenCuaSinhVienToolStripMenuItem.Name = "hoTenCuaSinhVienToolStripMenuItem";
            this.hoTenCuaSinhVienToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.hoTenCuaSinhVienToolStripMenuItem.Text = "Nguyễn Nhất Minh";
            // 
            // msibai1
            // 
            this.msibai1.Image = ((System.Drawing.Image)(resources.GetObject("msibai1.Image")));
            this.msibai1.Name = "msibai1";
            this.msibai1.Size = new System.Drawing.Size(224, 26);
            this.msibai1.Text = "Bai 1";
            this.msibai1.Click += new System.EventHandler(this.msibai1_Click);
            // 
            // msiBai2
            // 
            this.msiBai2.Image = ((System.Drawing.Image)(resources.GetObject("msiBai2.Image")));
            this.msiBai2.Name = "msiBai2";
            this.msiBai2.Size = new System.Drawing.Size(224, 26);
            this.msiBai2.Text = "Bai 2";
            this.msiBai2.Click += new System.EventHandler(this.msiBai2_Click);
            // 
            // msiBai3
            // 
            this.msiBai3.Image = ((System.Drawing.Image)(resources.GetObject("msiBai3.Image")));
            this.msiBai3.Name = "msiBai3";
            this.msiBai3.Size = new System.Drawing.Size(224, 26);
            this.msiBai3.Text = "Bai 3";
            this.msiBai3.Click += new System.EventHandler(this.msiBai3_Click);
            // 
            // bai4ToolStripMenuItem
            // 
            this.bai4ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bai4ToolStripMenuItem.Image")));
            this.bai4ToolStripMenuItem.Name = "bai4ToolStripMenuItem";
            this.bai4ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bai4ToolStripMenuItem.Text = "Bai 4";
            this.bai4ToolStripMenuItem.Click += new System.EventHandler(this.bai4ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Chương trình chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hoTenCuaSinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msibai1;
        private System.Windows.Forms.ToolStripMenuItem msiBai2;
        private System.Windows.Forms.ToolStripMenuItem msiBai3;
        private System.Windows.Forms.ToolStripMenuItem bai4ToolStripMenuItem;
    }
}


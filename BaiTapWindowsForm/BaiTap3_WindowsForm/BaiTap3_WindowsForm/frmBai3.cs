﻿using System;
using System.Windows.Forms;

namespace BaiTap3_WindowsForm
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnTachChuoi_Click(object sender, EventArgs e)
        {
            var hoTen = txtHoTen.Text;
            var ho = "";
            var ten = "";
            PhepTinh.TachChuoi(hoTen, out ho, out ten);
            txtHo.Text = ho;
            txtTen.Text = ten;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            var n1 = string.IsNullOrEmpty(txtSoN1.Text) ? 0 : int.Parse(txtSoN1.Text);
            var n2 = string.IsNullOrEmpty(txtSoN2.Text) ? 0 : int.Parse(txtSoN2.Text);
            var kq = PhepTinh.ThuTu(n1, n2);
            if (kq == true)
                lblKetQua.Text = "là hai số nguyên liên tiếp";
            else
                lblKetQua.Text = "không là hai số nguyên liên tiếp";
        }

        private void frmBai3_Load(object sender, EventArgs e)
        {

        }
    }
}

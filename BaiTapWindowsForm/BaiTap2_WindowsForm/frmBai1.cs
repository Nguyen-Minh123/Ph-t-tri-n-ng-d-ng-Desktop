using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm_Bai2
{
    public partial class frmBai1 : Form
    {
        private ThietBi thietBi;

        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhTien_Click(object sender, EventArgs e)
        {
            string ma = txtMaThietBi.Text;
            string ten = txtTenThietBi.Text;
            string nuocSX = txtNuocSanXuat.Text;
            int donGia = int.Parse(txtDonGia.Text);
            int soLuong = int.Parse(txtSoLuong.Text);

            thietBi = new ThietBi(ma , ten , nuocSX ,donGia,  soLuong);

            txtThanhTien.Text = thietBi.ThanhTien().ToString();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            if (thietBi != null)
            {
                rtxtHienThi.Text = thietBi.HienThi().ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin thiết bị!");
            }
        }

        private void txtMaThietBi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtxtHienThi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

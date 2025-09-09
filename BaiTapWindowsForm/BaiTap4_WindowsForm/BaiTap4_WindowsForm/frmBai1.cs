using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap4_WindowsForm
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            var maSP = txtMaSP.Text;
            var tenSP = txtTenSP.Text;
            var loaiSP = txtLoaiSP.Text;
            var ngaySX = dtpNgaySanXuat.Value;

            SanPham sp = new SanPham()
            {
                MaSanPham = maSP,
                TenSanPham = tenSP,
                LoaiSanPham = loaiSP,
                NgaySanXuat = ngaySX
            };

            lblHienThi.Text = sp.HienThi();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

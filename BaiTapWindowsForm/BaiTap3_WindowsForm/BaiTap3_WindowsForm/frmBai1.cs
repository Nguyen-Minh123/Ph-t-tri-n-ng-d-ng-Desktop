using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap3_WindowsForm
{
    public partial class frmBai1 : Form
    {
        private NhanVien nhanVien;
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnTongLuong_Click(object sender, EventArgs e)
        {
            string ma = txtMaNhanVien.Text;
            string ten = txtHoTen.Text;
            DateTime ns = DateTime.Parse(dtpNgaySinh.Text);
            double hsl = int.Parse(txtHeSoLuong.Text);
            double hspc = int.Parse(txtHeSoPhuCap.Text);

            nhanVien = new NhanVien(ma, ten, ns, hsl, hspc);

            txtTongLuong.Text = nhanVien.TongLuong().ToString();
        }


        private void btnHienThi_Click(object sender, EventArgs e)
        {

            
            if (nhanVien != null)
            {
                string ma = txtMaNhanVien.Text;
                string ten = txtHoTen.Text;
                DateTime ns = DateTime.Parse(dtpNgaySinh.Text);
                double hsl = double.Parse(txtHeSoLuong.Text);
                double hspc = double.Parse(txtHeSoPhuCap.Text);

                nhanVien = new NhanVien(ma, ten, ns, hsl, hspc);

                // Mỗi thông tin sẽ xuống dòng bằng Environment.NewLine
                rtxtHienThi.Text =
                    "Mã NV: " + ma + Environment.NewLine +
                    "Họ tên: " + ten + Environment.NewLine +
                    "Ngày sinh: " + ns.ToShortDateString() + Environment.NewLine +  
                    "Hệ số lương: " + hsl + Environment.NewLine +
                    "Hệ số phụ cấp: " + hspc + Environment.NewLine +
                    "Tổng lương: " + nhanVien.TongLuong();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin nhân viên!");
            }
        }

        private void rtxtHienThi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

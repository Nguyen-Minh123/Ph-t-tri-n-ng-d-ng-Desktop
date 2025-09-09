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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            var hoTen = txtHoTen.Text;
            var gioiTinh = txtGioiTinh.Text;

            // Gọi hàm chào hỏi
            string loiChao = TinhToan.ChaoHoi(hoTen, gioiTinh);
            MessageBox.Show(loiChao, "Chào hỏi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            try
            {
                var m = int.Parse(txtSoM.Text);
                var n = int.Parse(txtSoN.Text);

                lblKetQua.Text = "Kết quả: " + TinhToan.USCLN(m, n).ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBai3_Load(object sender, EventArgs e)
        {

        }
    }
}

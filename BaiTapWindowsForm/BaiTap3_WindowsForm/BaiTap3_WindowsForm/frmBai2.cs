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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXemKq_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoN.Text);
            int kq = 0;

            if (rdTongTu1DenN.Checked)
            {
                // gọi hàm tính tổng 1..n
                kq = TinhToan.TongDaySo(n);
            }
            else if (rdGiaiThua.Checked)
            {
                // gọi hàm tính giai thừa
                kq = (int)TinhToan.GiaiThua(n);
            }

            // Hiển thị kết quả
            lblKetQua.Text = kq.ToString();
         
        }

        private void rdGiaiThua_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

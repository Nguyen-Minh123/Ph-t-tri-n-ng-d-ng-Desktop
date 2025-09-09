using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm_Bai2
{
    public partial class frmBai2 : Form
    {
        private object ex;

        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            int soThuNhat = int.Parse(txtSoThuNhat.Text);
            int soThuHai = int.Parse(txtSoThuHai.Text);
            PhepTinh phepTinh = new PhepTinh(soThuNhat, soThuHai);
            double kq = 0;
            if (rdCong.Checked)
                kq = phepTinh.Cong();
            if (rdTru.Checked)
                kq = phepTinh.Tru();
            if (rdNhan.Checked)
                kq = phepTinh.Nhan();
            if (rdChia.Checked)
                kq = phepTinh.Chia();

            lblKetQua.Text = kq.ToString();

        }
    }
}

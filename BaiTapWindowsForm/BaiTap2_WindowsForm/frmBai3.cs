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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnNoiChuoi_Click(object sender, EventArgs e)
        {
            XuLyChuoiSo xuLyChuoiSo = new XuLyChuoiSo();
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string hoten;
            xuLyChuoiSo.NoiChuoi(ho, ten , out hoten);
            lblHoVaTen.Text = hoten;
        }

        private void btnGiaiThua_Click(object sender, EventArgs e)
        {
            XuLyChuoiSo xuLyChuoiSo = new XuLyChuoiSo();
            int n;
            if (int.TryParse(txtSoNguyenN.Text, out n))
            {
                try
                {
                    long kq = xuLyChuoiSo.GiaiThua(n);
                    lblKetQua.Text =  "" + kq;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Thông báo");
            }
        }
    }
}

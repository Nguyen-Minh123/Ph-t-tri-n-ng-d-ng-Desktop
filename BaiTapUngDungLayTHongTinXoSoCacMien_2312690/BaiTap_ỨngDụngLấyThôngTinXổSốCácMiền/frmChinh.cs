using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_ỨngDụngLấyThôngTinXổSốCácMiền
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
           

                InitializeComponent();
               
            }
        private void btnMienBac_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã chọn Miền Bắc để lấy thông tin!");
            var form = new frmMienBac();
            form.ShowDialog();
        }
        private void btnMienTrung_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã chọn Miền Trung để lấy thông tin!");
            var form = new frmMienTrung();
            form.ShowDialog();
        }
        private void btnMienNam_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Bạn đã chọn Miền Nam để lấy thông tin!");

            var form = new frmMienNam();
            form.ShowDialog();
        }
        private void frmChinh_Load(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            var form = new frmBai1();
            form.ShowDialog();
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            int formWidth = this.ClientSize.Width;   // chiều rộng vùng hiển thị của form
            int formHeight = this.ClientSize.Height; // chiều cao vùng hiển thị của form

            int btnWidth = btnBai1.Width;
            int btnHeight = btnBai1.Height;

            int space = 20; // khoảng cách giữa các nút

            // tổng chiều rộng của cả 3 nút + khoảng cách
            int totalWidth = btnWidth * 3 + space * 2;

            // vị trí X để căn giữa theo chiều ngang
            int startX = (formWidth - totalWidth) / 2;
            // vị trí Y để căn giữa theo chiều dọc
            int posY = (formHeight - btnHeight) / 2;

            // đặt lại vị trí các nút
            btnBai1.Location = new Point(startX, posY);
            btnBai2.Location = new Point(startX + btnWidth + space, posY);
            btnBai3.Location = new Point(startX + 2 * (btnWidth + space), posY);
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            var form = new frmBai2();
            form.ShowDialog();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            var form = new frmBai3();
            form.ShowDialog();
        }
    }
    
}

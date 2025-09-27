using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ThongTinSV
{
    public partial class frmTimKiem : Form
    {
        public string MSSV_TK { get; set; }
        public string Ten_TK { get; set; }
        public string Lop_TK { get; set; }

        public frmTimKiem()
        {
            InitializeComponent();
        }

        public void btn_Tim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtxtMSSV_TK.Text) &&
                string.IsNullOrEmpty(txtTen_TK.Text) &&
                string.IsNullOrEmpty(cboLop_TK.Text))
            {
                MessageBox.Show("Xin hãy nhập thông tin tìm kiếm", "Lỗi tìm kiếm",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MSSV_TK = mtxtMSSV_TK.Text.Trim();
            Ten_TK = txtTen_TK.Text.Trim();
            Lop_TK = cboLop_TK.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {

        }
    }
}

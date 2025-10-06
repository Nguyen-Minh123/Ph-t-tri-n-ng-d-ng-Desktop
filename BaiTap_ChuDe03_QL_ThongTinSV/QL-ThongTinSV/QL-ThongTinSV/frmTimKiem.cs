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
        // Thuộc tính trả về cho frmChinh
        public string MSSV_TK { get; private set; }
        public string Ten_TK { get; private set; }
        public string Lop_TK { get; private set; }

        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Reset trước
            MSSV_TK = string.Empty;
            Ten_TK = string.Empty;
            Lop_TK = string.Empty;


            // Kiểm tra nhập thông tin
            if (string.IsNullOrWhiteSpace(txtThongTin.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin sinh viên cần tìm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThongTin.Focus(); // đưa con trỏ vào ô nhập
                return;
            }

            // Nếu có nhập thì gán
            if (rdMSSV.Checked)
                MSSV_TK = txtThongTin.Text.Trim();
            else if (rdTen.Checked)
                Ten_TK = txtThongTin.Text.Trim();
            else if (rdLop.Checked)
                Lop_TK = txtThongTin.Text.Trim();

            // Trả kết quả về frmChinh
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        

        private void frmTimKiem_Load(object sender, EventArgs e)
        {

        }
    }
}
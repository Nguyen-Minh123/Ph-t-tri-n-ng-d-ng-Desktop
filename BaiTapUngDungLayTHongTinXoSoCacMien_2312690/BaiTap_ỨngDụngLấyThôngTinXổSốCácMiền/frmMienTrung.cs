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
    public partial class frmMienTrung : Form
    {
        public frmMienTrung()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {



        }

        private void frmMienTrung_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
        }
        private void btnXem2_Click(object sender, EventArgs e)
        {
            var url = $"https://www.minhngoc.com.vn/ket-qua-xo-so/mien-trung/{dateTimePicker2.Text}.html";
            var data = new KQXS().GetKQXS(url);
            dataGridView2.DataSource = data;
        }
    }
}

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
    public partial class frmMienNam : Form
    {
        public frmMienNam()
        {
            InitializeComponent();
        }

        private void frmMienNam_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            var url = $"https://www.minhngoc.com.vn/ket-qua-xo-so/mien-nam/{dateTimePicker1.Text}.html";
            var data = new KQXS().GetKQXS(url);
            dataGridView1.DataSource = data;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

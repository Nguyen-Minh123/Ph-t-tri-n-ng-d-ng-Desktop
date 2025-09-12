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
    public partial class frmMienBac : Form
    {
        
        public frmMienBac()
        {
            InitializeComponent();
        }
        private void frmMienBac_Load(object sender, EventArgs e)
        {
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "dd-MM-yyyy";
        }
        private void btnXem2_Click(object sender, EventArgs e)
        {
            var url = $"https://www.minhngoc.com.vn/ket-qua-xo-so/mien-bac/{dateTimePicker3.Text}.html";
            var data = new KQXSMienBac().GetKQXSMienBac(url);
            dataGridView3.DataSource = data;
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView3.Columns[1].Width = 250;

        }
        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}

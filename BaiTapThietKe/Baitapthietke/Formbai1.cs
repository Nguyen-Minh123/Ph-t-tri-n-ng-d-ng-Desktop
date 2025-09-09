using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitapthietke
{
    public partial class Formbai1 : Form
    {
        public Formbai1()
        {
            InitializeComponent();
        }

        private void rdxanh_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "22000";
        }

        private void rdtrang_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "20000";
        }

        private void rddo_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "21000";
        }

        private void btntinhtien_Click(object sender, EventArgs e)
        {
            int SoTien = int.Parse(txtDonGia.Text) * int .Parse(txtSoLuong.Text);
            lblSoTien.Text = SoTien.ToString();
        }
    }
}

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
    public partial class Formbai2 : Form
    {
        public Formbai2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            listBox2.Items.Add(item);
        }

        private void btnBoHang_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int sotien = 0;
            foreach(string hang in listBox2.Items) 
            {
                switch (hang) 
                {
                    case "Chuột":
                        sotien += 100000;
                        break;
                    case "Bàn Phím":
                        sotien += 150000;
                        break;
                    case "Máy in":
                        sotien += 2000000;
                        break;
                    case "USB Kingmax":
                        sotien += 200000;
                        break;
                    default:
                        break;
                }
                lblSoTien.Text = sotien + " đồng";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Formbai2_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

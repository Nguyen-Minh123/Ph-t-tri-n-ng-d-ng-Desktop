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
    public partial class Formbai4 : Form
    {
        public Formbai4()
        {
            InitializeComponent();
        }

        private void Formbai4_Load(object sender, EventArgs e)
        {
            Random ran = new Random();
            int so;
            for(int i = 0; i <=10; i++)
            {
                so = ran.Next(1, 100);
                listBox1.Items.Add(so);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int socantim = int.Parse(txtSo.Text);
            lblketqua.Text = "Không Tìm Thấy ";

            foreach (int so in listBox1.Items)
            {
                if (so == socantim)
                {
                    lblketqua.Text = "Tìm Thấy ";
                    break;
                }
                
            }
        }

        private void txtSo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

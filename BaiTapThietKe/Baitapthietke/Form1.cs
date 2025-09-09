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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void msibai1_Click(object sender, EventArgs e)
        {
            var form = new Formbai1();
            form.ShowDialog();
        }

        private void msiBai2_Click(object sender, EventArgs e)
        {
            var form = new Formbai2();
            form.ShowDialog();
        }

        private void msiBai3_Click(object sender, EventArgs e)
        {
            var form = new Formbai3();
            form.ShowDialog();
        }

        private void bai4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Formbai4();
            form.ShowDialog();
        }
    }
}

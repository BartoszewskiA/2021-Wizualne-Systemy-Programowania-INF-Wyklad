using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w02p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = hScrollBar1.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = hScrollBar1.Value.ToString();
            vScrollBar1.Value = hScrollBar1.Value;
            progressBar1.Value = hScrollBar1.Value;
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

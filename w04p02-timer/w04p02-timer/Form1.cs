using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w04p02_timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 25 - trackBar1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value > 99) 
                timer1.Stop();
            else
                progressBar1.Value = progressBar1.Value + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = 25- trackBar1.Value;
        }
    }
}

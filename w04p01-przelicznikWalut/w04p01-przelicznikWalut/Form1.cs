using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w04p01_przelicznikWalut
{
    public partial class Form1 : Form
    {
        PrzelicznikWalut przelicznikWalut;
        public Form1()
        {
            InitializeComponent();
            przelicznikWalut = new PrzelicznikWalut();
            przelicz();
            opisy();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
            przelicz();
        }

        private void przelicz()
        {
            if (radioButton1.Checked)
                przelicznikWalut.setPLN(hScrollBar1.Value);
            else if (radioButton2.Checked)
                przelicznikWalut.setEURO(hScrollBar1.Value);
            else
                przelicznikWalut.setUSD(hScrollBar1.Value);

            if (radioButton4.Checked)
                textBox2.Text = przelicznikWalut.getPLN().ToString();
            else if (radioButton5.Checked)
                textBox2.Text = przelicznikWalut.getEURO().ToString();
            else
                textBox2.Text = przelicznikWalut.getUSD().ToString();

        }

        private void opisy()
        {
            if (radioButton1.Checked)
                label3.Text = "PLN";
            else if (radioButton2.Checked)
                label3.Text = "EURO";
            else
                label3.Text = "USD";

            if (radioButton4.Checked)
                label4.Text = "PLN";
            else if (radioButton5.Checked)
                label4.Text = "EURO";
            else
                label4.Text = radioButton6.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            przelicz();
            opisy();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            przelicz();
            opisy();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            przelicz();
            opisy();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            przelicz();
            opisy();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            przelicz();
            opisy();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            przelicz();
            opisy();
        }

        private void oAutorachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program wykonany na wykładzie", "Info", MessageBoxButtons.OK);
        }
    }
}

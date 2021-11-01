using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w03p03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.AliceBlue;
            panel2.BackColor = Color.Green;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "Clikc\n";
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "DoubleClikc\n";
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
 
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.AliceBlue;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Green;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString() + " : " + e.Y.ToString();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                panel2.BackColor = Color.Red;
            if (e.Button == MouseButtons.Right)
                panel2.BackColor = Color.Blue;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.Green;
        }
    }
}

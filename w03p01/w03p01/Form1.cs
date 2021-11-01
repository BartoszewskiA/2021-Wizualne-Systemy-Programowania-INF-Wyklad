using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w03p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "Nastąpiło zdarzenie LOAD\n";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = this.Width.ToString() + " : " + this.Height.ToString();
            richTextBox1.Text = richTextBox1.Text + "Nastąpiło zdarzenie SHOWN\n";
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.Text = richTextBox1.Text + "Nastąpiło zdarzenie ACTIVATE\n";
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "Nastąpiło zdarzenie DEACTIVATE\n";
            richTextBox1.ForeColor = Color.LightGray;
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "Nastąpiło zdarzenie ResizeBegin\n";
            toolStripStatusLabel1.ForeColor = Color.Red;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "Nastąpiło zdarzenie ResizeEnd\n";
            toolStripStatusLabel1.ForeColor = Color.Black;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = this.Width.ToString() + " : " + this.Height.ToString();
            richTextBox1.Text = richTextBox1.Text + "Nastąpiło zdarzenie Resize\n";
        }
    }
}

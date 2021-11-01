using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w03p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I tak nikt nie czyta", "Jakiś ważny komunikat", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult odpowiedz = MessageBox.Show("Wybierz!", "Oknao z pytaniem", MessageBoxButtons.YesNo);

            if (odpowiedz == DialogResult.Yes)
                label1.Text = "TAK";
            else
                label1.Text = "NIE";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Jesteś tego pewien?", "Pytanie", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}

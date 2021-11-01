using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w02p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0;
            int wynik;
            //a = int.Parse(textBox1.Text);
            //b = int.Parse(textBox2.Text);
            //c = int.Parse(textBox3.Text);
            if (int.TryParse(textBox1.Text, out wynik))
                a = wynik;
            else
            { 
                a = 0;
                textBox1.Text = "0";
            }
            if (int.TryParse(textBox2.Text, out wynik))
                b = wynik;
            else
            {
                b = 0;
                textBox2.Text = "0";
            }
            if (int.TryParse(textBox3.Text, out wynik))
                c = wynik;
            else
            {
                c = 0;
                textBox3.Text = "0";
            }

            int delta = b * b - 4 * a * c;

            if (delta>0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                string s = "x1 = ";
                s += x1.ToString();
                s += "\nx2 = ";
                s += x2.ToString();
                label4.Text = s;
            }
            else if (delta ==0)
            {
                double x = (double)-b / (2 * a);
                String s = "x0 = ";
                s += x.ToString();
                label4.Text = s;
            }
            else
            {
                label4.Text = "Brak rozwiązań";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace w06p01_okna_dialogowe
{
    /// <summary>
    /// Logika interakcji dla klasy OknoWlasne_01.xaml
    /// </summary>
    public partial class OknoWlasne_01 : Window
    {

        public int dana=10;
        public OknoWlasne_01()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            tb_okno2_01.Text = dana.ToString();
        }
    }
}

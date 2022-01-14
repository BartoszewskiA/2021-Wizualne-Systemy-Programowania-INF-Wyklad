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
    /// Logika interakcji dla klasy OknoSterujace.xaml
    /// </summary>
    public partial class OknoSterujace : Window
    {
        MainWindow mainWindow;
        public OknoSterujace(MainWindow adresZwrotny)
        {
            InitializeComponent();
            mainWindow = adresZwrotny;
        }

        private void suwak_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
          
            mainWindow.tb_07.Text = e.NewValue.ToString();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mainWindow.oknoSterujace = null;
        }
    }
}

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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace w06p01_probnik_kol_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void suwakR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            opisR.Content = Math.Round(e.NewValue).ToString();
            p1.Fill = new SolidColorBrush(Color.FromRgb((Byte)e.NewValue, 0, 0));
            zmienKolorPanelu();
            
        }

        private void zmienKolorPanelu()
        {
            if (suwakR!=null && suwakG!=null && suwakB!=null)
                panel.Fill = new SolidColorBrush(Color.FromRgb((Byte)suwakR.Value, (Byte)suwakG.Value, (Byte)suwakB.Value));
        }

        private void suwakG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            opisG.Content = Math.Round(e.NewValue).ToString();
            p2.Fill = new SolidColorBrush(Color.FromRgb(0,(Byte)e.NewValue, 0));
            zmienKolorPanelu();
        }

        private void suwakB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            opisB.Content = Math.Round(e.NewValue).ToString();
            p3.Fill = new SolidColorBrush(Color.FromRgb(0,0,(Byte)e.NewValue));
            zmienKolorPanelu();
        }
    }
}

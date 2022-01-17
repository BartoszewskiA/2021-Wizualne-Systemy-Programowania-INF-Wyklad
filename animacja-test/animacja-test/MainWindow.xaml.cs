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
using System.Windows.Threading;

namespace animacja_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer timer;
        Ellipse el;
        Line line;
        int poz_x = 0;
        int poz_y = 400;
        int w_x = 10;
        int w_y = 10;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += timer_Tick;

            line = new Line();
            line.X1 = 5;
            line.Y1 = 400-5;
            line.X2 = w_x;
            line.Y2 = 400-w_y;
            line.Stroke = new SolidColorBrush(Colors.Red);
            tlo.Children.Add(line);
        }

        private void timer_Tick(object? sender, EventArgs e)
        {
            poz_x++;
            poz_y--;
            Canvas.SetLeft(el, poz_x);
            Canvas.SetTop(el, poz_y - 20);
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.GetPosition(this);
            Canvas.SetLeft(pozycja, p.X+5);
            Canvas.SetTop(pozycja, p.Y+5);
            pozycja_tekst.Content = Math.Round(p.X) + ":" + Math.Round(p.Y);


        }

        private void bt_start_Click(object sender, RoutedEventArgs e)
        {
            

            el = new Ellipse();
            
            el.Width = 20;
            el.Height = 20;
            el.Stroke = new SolidColorBrush(Colors.Red);
            el.Fill = new SolidColorBrush(Colors.White);
            Canvas.SetLeft(el, poz_x);
            Canvas.SetTop(el,poz_y-20);
            tlo.Children.Add(el);
            Canvas.SetZIndex(el, 1);
            timer.Start();
        }

        private void sl_x_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            w_x = (int)Math.Round(sl_x.Value);
            if (line != null)
                line.X2 = w_x;
        }

        private void sl_y_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            w_y = (int)Math.Round(sl_y.Value);
            if (line != null)
                line.Y2 = 400 - w_y;
        }

        private void _pilke(int x, int y)
        {

        }
    }
}

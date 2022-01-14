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

namespace testCanvas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Ellipse el;
        int x = 0, y = 0;


        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += timer_Tick;
            timer.Start();

            el = new Ellipse();
            el.Width = 100;
            el.Height = 100;
            el.Stroke = new SolidColorBrush(Colors.Red);
            el.Fill = new SolidColorBrush(Colors.Salmon);
            canvas.Children.Add(el);
            Canvas.SetZIndex(el, 1);

        }

        private void timer_Tick(object? sender, EventArgs e)
        {
            //opis.Text = DateTime.Now.ToLongTimeString();
          /*  Canvas.SetLeft(el, x++);
            Canvas.SetTop(el, y++);*/

        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
  
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.GetPosition(this);
            Canvas.SetLeft(el, p.X - el.Width /2);
            Canvas.SetTop(el, p.Y - el.Height /2);
            Canvas.SetLeft(pilka, p.X);
            Canvas.SetTop(pilka, p.Y);
            opis.Text = " " + p.X + " " + p.Y;
        }

        private void Window_TouchMove(object sender, TouchEventArgs e)
        {
        }
    }
}

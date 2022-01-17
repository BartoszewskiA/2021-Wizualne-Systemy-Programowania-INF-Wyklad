using System.Collections.Generic;
using System.Windows;

namespace test_listaboektow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Kulka> kulki;

        public MainWindow()
        {
            InitializeComponent();
            kulki = new List<Kulka>();
            Kulka.ile = 0;
            for (int i = 0; i < 10; i++)
                kulki.Add(new Kulka());
            foreach (var item in kulki)
            {
                /*text.Text += item.numer.ToString() + "\t";
                text.Text += item.X.ToString() + "\t";
                text.Text += item.Y.ToString() + "\t";
                text.Text += item.d.ToString() + "\t";
                text.Text += item.kolor.R.ToString() + "\t";
                text.Text += item.kolor.G.ToString() + "\t";
                text.Text += item.kolor.B.ToString() + "\n";*/
                text.Text += item.ToString();
            }

        }
    }
}

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace w07p01_pliki
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(TXT)|*.txt|All files|*.*";
            openFileDialog.Title = "Otwórz plik";
            if (openFileDialog.ShowDialog() == true)
            {
                //poleTekstowe.Text = File.ReadAllText(openFileDialog.FileName);
                List<string> linie = new List<string>(File.ReadAllLines(openFileDialog.FileName));
                string s = "";
                foreach (string l in linie)
                { 
                    s += l;
                    s+="\n";
                }
                poleTekstowe.Text = s;

                label.Content = openFileDialog.FileName;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(TXT)|*.txt|All files|*.*";
            saveFileDialog.Title = "zapis";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, poleTekstowe.Text);
                label.Content = saveFileDialog.FileName;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            List<String> linie = new List<String>(poleTekstowe.Text.Split('\n'));
            linie.Sort();
            string s = "";
            foreach(String l in linie)
            {
                if (l.Length>0)
                {
                    s += l;
                    s += '\n';
                }
            }
            poleTekstowe.Text=s;
        }
    }
}

using Microsoft.Win32;
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

namespace w06p01_okna_dialogowe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OknoWlasne_01 oknoWlasne_01;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliku (*.*)|*.*";
            openFileDialog.Title = "Okno otwierania pliku";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (openFileDialog.ShowDialog() == true)
                tb_01.Text = openFileDialog.FileName;
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliku (*.*)|*.*";
            saveFileDialog.Title = "Okno zapisu";
            saveFileDialog.DefaultExt = "bmp";
            if (saveFileDialog.ShowDialog() == true)
                tb_02.Text = saveFileDialog.FileName;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OknoWlasne_01 oknoWlasne_01 = new OknoWlasne_01();
            oknoWlasne_01.Title = "Nowe okno dialogowe";
            //oknoWlasne_01.tb_okno2_01.Text = "tekst przekazany z rodzica";
            oknoWlasne_01.dana = 101;
            if (oknoWlasne_01.ShowDialog() == true)
                tb_03.Text = oknoWlasne_01.textBox_okno2.Text;
            else
                tb_03.Text = "Anulowano";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                tb_04.Text = folderBrowserDialog.SelectedPath;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FontDialog fontDialog = new System.Windows.Forms.FontDialog();
            if (fontDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tb_05.Text = fontDialog.Font.Name + "\n" + tb_05.Text;
                tb_05.FontSize = fontDialog.Font.Size;
                tb_05.FontFamily = new FontFamily(fontDialog.Font.Name);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.ColorDialog colorDialog = new System.Windows.Forms.ColorDialog();  
            if (colorDialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                byte R = colorDialog.Color.R;
                byte G = colorDialog.Color.G;   
                byte B = colorDialog.Color.B;
                Color c = Color.FromRgb(R, G, B);
                SolidColorBrush pedzel = new SolidColorBrush(c);
                tb_06.Background = pedzel;
            }
        }
        public OknoSterujace? oknoSterujace = null;
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            
            if (oknoSterujace == null)
            {
                oknoSterujace = new OknoSterujace(this);
                oknoSterujace.Show();
                tb_07.Text = oknoSterujace.suwak.Value.ToString();
            }
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (oknoSterujace != null)
                oknoSterujace.Close();
        }
    }
}

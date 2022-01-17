using System;

namespace test_listaboektow
{
    internal class Kulka
    {
        private static Random random = new Random();
        public static int ile;
        public int numer { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int d { get; set; }
        public System.Windows.Media.Color kolor { get; set; }

        public Kulka(int maxX = 400, int maxY = 600)
        {
            numer = ile++;
            X = random.Next(maxY);
            Y = random.Next(maxY);
            d = 5 + random.Next(34);
            kolor = System.Windows.Media.Color.FromRgb((Byte)random.Next(256), (Byte)random.Next(256), (Byte)random.Next(256));
        }
        public override string ToString()
        {
            String s = "";
            s += numer.ToString() + "\t";
            s += X.ToString() + "\t";
            s += Y.ToString() + "\t";
            s += d.ToString() + "\t";
            s += kolor.R.ToString() + "\t";
            s += kolor.G.ToString() + "\t";
            s += kolor.B.ToString() + "\n";

            return s;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace w01p01_konsola
{
    class klasaPochodna : nowaKlasa
    {
        public klasaPochodna(int dana = 0) : base(dana)
        {
        }

        public void wypisz()
        {
            Console.WriteLine("przechowywana liczba to: " + getLiczba().ToString());
        }
    }
}

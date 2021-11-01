using System;
using System.Collections.Generic;
using System.Text;

namespace w01p01_konsola
{
    class nowaKlasa
    {
        private int liczba;
        
        public nowaKlasa(int dana = 0)
        {
            liczba = dana;
        }

        public int getLiczba() { return liczba; }
        public void setLiczba(int liczba) { this.liczba = liczba; }
    }
}

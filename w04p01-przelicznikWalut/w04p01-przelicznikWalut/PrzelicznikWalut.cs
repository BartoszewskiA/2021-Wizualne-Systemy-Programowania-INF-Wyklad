using System;
using System.Collections.Generic;
using System.Text;

namespace w04p01_przelicznikWalut
{
    class PrzelicznikWalut
    {
        private double walutaPrzeliczeniowaPLN;
        public double kursEURO;
        public double kursUSD;

        public PrzelicznikWalut()
        {
            walutaPrzeliczeniowaPLN = 0;
            kursEURO = 4.5;
            kursUSD = 4;
        }
        public void setPLN(double kwota) { walutaPrzeliczeniowaPLN = kwota; }
        public void setEURO(double kwota) { walutaPrzeliczeniowaPLN = kwota * kursEURO; }
        public void setUSD(double kwota) { walutaPrzeliczeniowaPLN = kwota * kursUSD; }
        public double getPLN() { return Math.Round(walutaPrzeliczeniowaPLN,2); }
        public double getEURO() { return Math.Round(walutaPrzeliczeniowaPLN / kursEURO,2); }
        public double getUSD() { return Math.Round(walutaPrzeliczeniowaPLN / kursUSD,2); }
    }
}

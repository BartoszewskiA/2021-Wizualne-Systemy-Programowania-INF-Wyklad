using System;

namespace w01p01_konsola
{
    class Program
    {
        decimal w = (decimal)100.5;
        double w1 = 100.5;
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //nowaFunkcja();

            //var schowek = new nowaKlasa(101);
            //Console.WriteLine(schowek.getLiczba());

            var schowek = new klasaPochodna(102);
            schowek.wypisz();
        }

        static void nowaFunkcja() 
        {
            int x = 0;
            Console.WriteLine("programowania");
        }
    }
}



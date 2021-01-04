using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {

        //static double Przelicz(int n) {

        //    // int wynik = 0;
        //    int cyfra;
        //    int wykladnik = 0;
        //    double suma = 0;

        //    while (n > 0) {

        //        cyfra = n % 10;
        //        suma += cyfra * Math.Pow(4, wykladnik);
        //        wykladnik++;
        //        n = n / 10;
        //    }


        //    return suma;
        //}

        static int Przelicz(int n) {

            if (n < 10) return n;
            else return (n % 10) + 4 * Przelicz(n / 10);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Przelicz(11)); // odp: 5 = 1*4^1 + 1*4^0
            Console.WriteLine(Przelicz(110)); // 20
            Console.WriteLine(Przelicz(1100)); // 80

            Console.ReadKey();
        }
    }
}

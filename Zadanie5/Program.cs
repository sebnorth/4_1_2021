using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj a: ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++) // i - numer wiersza
            {

                if (i == 1 || i == 2 || i == a)
                {

                    for (int j = 1; j <= i; j++) // j - która gwiazdka w wierszu
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();

                }

                else
                {

                    // 1 gwiazdka
                    Console.Write("*");
                    // i-2 spacje

                    for (int j = 1; j <= i-2; j++) // j - która spacja w wierszu
                    {
                        Console.Write(" ");
                    }

                    // 1 gwiazdka
                    Console.Write("*");
                    // przejść do nowej linii
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}

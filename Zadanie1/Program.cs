using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {

        //static double Walec(double r, double h, ref double objetosc) {

        //    objetosc = Math.PI * r * r * h; 
        //    return Math.PI * r * r * h;  
        //}

        static double Walec(double r, double h) {
            
            return Math.PI* r *r * h;

        }

        static void Main(string[] args)
        {

            //double r = 1;
            //double h = 1;
            // double objetosc = 0; 
            // Console.WriteLine(Walec(r,h, ref objetosc));
            Console.WriteLine(Walec(1,1));
            // Console.WriteLine(objetosc);
            Console.ReadKey();
        }
    }
}

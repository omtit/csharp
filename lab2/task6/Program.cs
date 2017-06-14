using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            t = Console.ReadLine();
            double a, h;
            a = double.Parse(t);
            t = Console.ReadLine();
            h = double.Parse(t);
            double S;
            if (a <= 0) { 
                Console.WriteLine("Значение \"а\" должно быть положительным");
                    return;
            }
            if (h<=0) {
                Console.WriteLine("Значение \"h\" должно быть положительным");
                    return;
            }
            S=(a*h)/2;
            Console.WriteLine("{0:F4}", S);
        }
    }
}

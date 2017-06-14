using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            double l, p;
            string t;
            t = Console.ReadLine();
            l = double.Parse(t);
            t = Console.ReadLine();
            p = double.Parse(t);
            if (l < 0)
            {
                Console.WriteLine("Значение l должно быть не отрицательным");
                return;
            }
            if (p < 0)
            {
                Console.WriteLine("Значение p должно быть не отрицательным");
                return;
            }
            if (l * 1000 < p * 0.305)
            {
                Console.WriteLine("Расстояние в футах больше");
            }
            else
            {
                Console.WriteLine("Расстояние в километрах больше");
            }
        }
    }
}

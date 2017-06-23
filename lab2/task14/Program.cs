using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            t = Console.ReadLine();
            double a,b;
            a = double.Parse(t);
            t = Console.ReadLine();
            b = double.Parse(t);
            double x;

            if (b > 0)
            {
                Console.WriteLine("Значение b должно быть не положительным");
            }
            else
            {
                x = a * Math.Sqrt(-7*b);
                Console.WriteLine("{0:F4}", x);
            }
        }
    }
}

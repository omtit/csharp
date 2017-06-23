using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            t = Console.ReadLine();
            double a;
            a = double.Parse(t);
            double b;
           
            if (61 - a < 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть не отрицательным");
            }
            else
            {
                b = 3*Math.Sqrt(61-a);
                Console.WriteLine("{0:F4}", b);
            }
        }
    }
}

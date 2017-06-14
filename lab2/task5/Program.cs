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
            string s;
            s = Console.ReadLine();
            double x;
            x = double.Parse(s);
            double y;
            if (x <= 0) { 
                Console.WriteLine ("Значение \"x\" должно быть положительным");
                    return;
            }
            y = 4 * Math.PI * (x * x * x) / 3;
            Console.WriteLine("{0:F4}", y);
        }
    }
}

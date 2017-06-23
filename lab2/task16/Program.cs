using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task16
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            t = Console.ReadLine();
            double x, y;
            x = double.Parse(t);
            t = Console.ReadLine();
            y = double.Parse(t);
            double a;
            if (y < 0)
            {
                Console.WriteLine("Значение y должно быть не отрицательным");
                return;
            }
            if (x + Math.Sqrt(y) < 0)
            {
                Console.WriteLine("Подкоренное значение должно быть не отрицительным");
                return;
            }
                a = -5 * Math.Sqrt(x + Math.Sqrt(y));
                Console.WriteLine("{0:F4}", a);              
            
           
        }
    }
}

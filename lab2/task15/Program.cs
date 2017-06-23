using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task15
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

            if (a <= -273.16)
            {
                Console.WriteLine("Температура должна быть выше абсолютного нуля");
            }
            else
            {
                b = (a * 1.8) + 32;
                Console.WriteLine("{0:F4}", b);
            }
        }
    }
}

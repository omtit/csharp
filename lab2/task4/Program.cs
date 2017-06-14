using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string R;
            R = Console.ReadLine();
            double x;
            x = double.Parse(R);
            double t;
            if (x <= 0)
            {
                Console.WriteLine("Значение \"x\" должно быть положительным");
                return;
            }
            t = 2*Math.PI*x;
            Console.WriteLine("{0:F4}", t);
        }
    }
}

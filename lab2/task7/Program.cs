using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
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
            b = a * Math.PI / 180;
            Console.WriteLine("{0:F4}", b);
        }
    }
}

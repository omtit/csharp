using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            double x, y, z;
            t = Console.ReadLine();
            x = double.Parse(t);
            t = Console.ReadLine();
            y = double.Parse(t);
            t = Console.ReadLine();
            z = double.Parse(t);

            if (x > 0)
            {
                Console.WriteLine(x * x);
            }
            else
            {
                Console.WriteLine(x);
            }


            if (y > 0)
            {
                Console.WriteLine(y * y);
            }
            else
            {
                Console.WriteLine(y);
            }

            if (z > 0)
            {
                Console.WriteLine(z * z);
            }
            else
            {
                Console.WriteLine(z);
            }
        }
    }
}

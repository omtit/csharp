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
            int r, a;
            t = Console.ReadLine();
            r = int.Parse(t);
            t = Console.ReadLine();
            a = int.Parse(t);

            if (r < 0)
            {
                Console.WriteLine("Значение r должно быть не отрицательным");
                return;
            }
            if (a < 0)
            {
                Console.WriteLine("Значение a должно быть не отрицательным");
                return;
            }

            int x, y;

            x = r * r;
            y = a * a;

            if (x == y)
            {
                Console.WriteLine("Площадь одинакова");
                return;
            }

            if (x > y)
            {
                Console.WriteLine("Площадь круга больше");
            }
            else
            {
                Console.WriteLine("Площадь квадрата больше");
            }
        }
    }
}

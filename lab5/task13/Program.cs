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
            int x, y, z;
            t = Console.ReadLine();
            x = int.Parse(t);
            t = Console.ReadLine();
            y = int.Parse(t);
            t = Console.ReadLine();
            z = int.Parse(t);

            if (x != y && y != z && z != x)
            {
                Console.WriteLine("Числа не равны друг другу");
                return;
            }

            if (x == y || y == z || z == x)
            {
                Console.WriteLine("Среди чисел есть равные");
                return;
            }
        }
    }
}

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
            int a, b, c;
            t = Console.ReadLine();
            a = int.Parse(t);
            t = Console.ReadLine();
            b = int.Parse(t);
            t = Console.ReadLine();
            c = int.Parse(t);

            if (a < 0)
            {
                Console.WriteLine("Значение А должно быть не отрицательным");
                return;
            }
            if (b < 0)
            {
                Console.WriteLine("Значение B должно быть не отрицательным");
                return;
            }
            if (c < 0)
            {
                Console.WriteLine("Значение С должно быть не отрицательным");
                return;
            }

            if (a != b && b != c && c != a)
            {
                Console.WriteLine("Треугольник не является равнобедренным");
                return;
            }
            if (a == b && b == c && c == a)
            {
                Console.WriteLine("Треугольник равнобедренный");
                return;
            }
            if (a == b && b != c && c != a)
            {
                Console.WriteLine("Треугольник равнобедренный");
                return;
            }
            if (a != b && b != c && c == a)
            {
                Console.WriteLine("Треугольник равнобедренный");
                return;
            }
            if (a != b && b == c && c != a)
            {
                Console.WriteLine("Треугольник равнобедренный");
                return;
            }
        }
    }
}

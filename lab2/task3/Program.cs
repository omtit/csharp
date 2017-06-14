using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            String s;
            s = Console.ReadLine();
            int x;
            x = int.Parse(s);
            int y;
            if (x <= 0)
            {
                Console.WriteLine("Значение \"x\" должно быть положительным");
                return;
            }
            y = x * x * x;
            Console.WriteLine("{0:F4}", y);
        }
    }
}

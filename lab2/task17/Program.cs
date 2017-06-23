using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task17
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            double vel1, vel2, x;
            t = Console.ReadLine();
            vel1 = double.Parse(t);
            t = Console.ReadLine();
            vel2 = double.Parse(t);
            t = Console.ReadLine();
            x = double.Parse(t);

            double d;
            if (vel1 < 0)
            {
                Console.WriteLine("Скорость должна быть не отрицательной");
                return;
            }
            if (vel2 < 0)
            {
                Console.WriteLine("Скорость должна быть не отрицательна");
                return;
            }
            d = x/(vel1+vel2);
            Console.WriteLine("{0:F4}", d);
        }
    }
}

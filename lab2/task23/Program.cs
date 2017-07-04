using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task23
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

            if (a==0)
            {
                Console.WriteLine("Данное уравнение не является квадратным");
                return;
            }

            double dis;
            dis = b * b - 4 * (a * c);
            Console.WriteLine("{0:F4}", dis);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task18
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            int x1, x2, x3;
            t = Console.ReadLine();
            x1 = int.Parse(t);
            t = Console.ReadLine();
            x2 = int.Parse(t);
            t = Console.ReadLine();
            x3 = int.Parse(t);

            int y;
            y = (x1 * x2) + (x1 * x3) + (x2 * x3);
            Console.WriteLine(y);
        }
    }
}

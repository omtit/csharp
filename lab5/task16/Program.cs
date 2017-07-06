using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task16
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

            if (x > y && x > z)
            {
                Console.WriteLine(x);
                return;
            }
            if (y > x && y > z)
            {
                Console.WriteLine(y);
                return;
            }
            if (z > x && z > y)
            {
                Console.WriteLine(z);
                return;
            }
        }
    }
}

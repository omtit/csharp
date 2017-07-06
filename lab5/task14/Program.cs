using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14
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

            if (-3 < x && x < 5)
            {
                Console.Write(x+" ");
            }
            else
            {
                Console.Write(" ");
            }

            if (-3 < y && y < 5)
            {
                Console.Write(y+" ");
            }
            else
            {
                Console.Write(" ");
            }

            if (-3 < z && z < 5)
            {
                Console.Write(z + " ");
            }
            else
            {
                Console.Write(" ");
            }
        }
    }
}

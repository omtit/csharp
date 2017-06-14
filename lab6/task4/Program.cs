using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string t;
            t = Console.ReadLine();
            a = int.Parse(t);
            t = Console.ReadLine();
            b = int.Parse(t);
            if (a > b)
            {
                Console.WriteLine("а не должно быть больше б");
                return;
            }
            while (a <= b)
            {
                Console.Write(b + " ");
                b = b - 1;
            }
        }
    }
}

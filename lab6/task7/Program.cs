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
            int a, b;
            string t;
            t = Console.ReadLine();
            a = int.Parse(t);
            t = Console.ReadLine();
            b = int.Parse(t);
            if (a < b)
            {
                a = a + 1;
                while (a <= b)
                {
                    Console.WriteLine(a + " ");
                    a = a + 1;
                }
            }
            else
            {
                b = b-1;
                while (b < a)
                {
                    Console.WriteLine(a + " ");
                    a = a - 1;
                }
            }
            
        }
    }
}

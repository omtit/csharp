using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, n, x;
            string t;
            t = Console.ReadLine();
            a = int.Parse(t);
            t = Console.ReadLine();
            b = int.Parse(t);
            int i = 0;
            if (a > b)
            {
                x = b;
               n = a;
            }
            else
            {
                x=a;
               n = b;
            }
            while (x < n)
            {
                Console.WriteLine(x + " ");
                x = x + 1;
            }
                i = i + 1;
                
            Console.Write(n + " ");
            }
    }
}

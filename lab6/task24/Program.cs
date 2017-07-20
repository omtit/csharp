using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task24
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            int x;
            t = Console.ReadLine();
            x = int.Parse(t);

            int a = 30;
            int b = 40;

            while (a <= b)
            {
                if (x == a)
                {
                    Console.WriteLine("{0}+", a);
                }
                else
                {
                    Console.WriteLine("{0}-" ,a);
                }
                a = a + 1;
            }
        }
    }
}

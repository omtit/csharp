using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string t, b;
            t = Console.ReadLine();
            b = Console.ReadLine();
            a = int.Parse(t);
            if (a < 0)
            {
                Console.WriteLine("а не должно быть отрицательным");
                return;
            }
                int n=a;
                int i=0;
                Console.Write("\"");
            while (i<n)
            {
                Console.Write(b);
                i = i + 1;
            }
            Console.Write("\"");
        }
    }
}

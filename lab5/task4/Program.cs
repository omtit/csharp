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
            string t;
            t = Console.ReadLine();
            int a;
            a = int.Parse(t);
            int b;
            b = Math.Abs(a);
            Console.WriteLine(b);
        }
    }
}

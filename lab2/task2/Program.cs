using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            String S;
            S = Console.ReadLine();
            int x;
            x = int.Parse(S);
            int S1;
            if (x <= 0)
            {
                Console.WriteLine("Значение \"х\" должно быть положительным");
                return;
            }
            S1 = 6*(x*x);
            Console.WriteLine("{0}", S1);
        }
    }
}

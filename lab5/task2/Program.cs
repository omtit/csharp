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
            string t;
            t = Console.ReadLine();
            int P, Q;
            P = int.Parse(t);
            t = Console.ReadLine();
            Q = int.Parse(t);
            if (P < Q)
            {
                Console.WriteLine("Максимальное " + Q + " минимальное " + P);
            }
            else
            {
                Console.WriteLine("Максимальное " + P + " минимальное " + Q);
            }
        }
    }
}

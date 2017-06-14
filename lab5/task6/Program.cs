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
            string t;
            t = Console.ReadLine();
            double V1, V2;
            V1 = double.Parse(t);
            t = Console.ReadLine();
            V2 = double.Parse(t);
            if (V1 * 1000 < V2 * 0.001)
            {
                Console.WriteLine("V1(км/ч) больше");
            }
            else
            {
                Console.WriteLine("V2(м/с) больше");
            }
        }
    }
}

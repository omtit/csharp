using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            t = Console.ReadLine();
            int a, b;
            a = int.Parse(t);
            t = Console.ReadLine();
            b = int.Parse(t);
            int q, p;
            if (a <= 0) { 
                Console.WriteLine ("Значение \"а\" должно быть положительным");
                return;
                }
            if (b <= 0)
            {
                Console.WriteLine("Значение \"b\" должно быть положительным");
                return;
            }
            q = (a * 100) / b;
            p = a * 100 % b;
            Console.WriteLine("{0}шт и {1}см", q, p);
        }
    }
}

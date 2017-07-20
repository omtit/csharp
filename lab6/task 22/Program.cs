using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_22
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            int n;
            t = Console.ReadLine();
            n = int.Parse(t);

            int i = 0;
            int i1 = 0;

            if (n < 0)
            {
                Console.WriteLine("Значение n должно быть не отрицательным");
                return;
            }

            while (i < n)
            {
                Console.Write("!");
                i = i + 1;
                i1 = i1 + 1;

                if (i1 == 5)
                {
                    Console.Write(" ");
                    i1 = i1 - 5;
                }
            }
        }
    }
}

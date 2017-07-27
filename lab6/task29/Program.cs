using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task29
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            int y;
            t = Console.ReadLine();
            y = int.Parse(t);

            if (y<=0) 
            {
                Console.WriteLine("Значение y должно быть положительным");
                return;
            }
            int i = 0;
            int n = 0;

            while (i<=y)
            {

                i = i + 1;

            if (y%i==0)
            {
                n = n + 1;
            }
            }

            if (n == 2)
            {
                Console.WriteLine("число простое");
            }
            else
            {
                Console.WriteLine("число не простое");
                    return;
            }
        }
    }
}

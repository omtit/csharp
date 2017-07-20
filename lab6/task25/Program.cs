using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task25
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            int y;
            t = Console.ReadLine();
            y = int.Parse(t);

            if (y < 0)
            {
                Console.WriteLine("Значение y должно быть в интервале [0 ; 15]");
                return;
            }
            if (y > 15)
            {
                Console.WriteLine("Значение y должно быть в интервале [0 ; 15]");
                    return;
            }

            int i = 0;

            while (i < 15)
            {
                i = i + 1;

                if (i <= y)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
        }
    }
}

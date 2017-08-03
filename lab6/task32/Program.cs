using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task32
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, t;
            int w, h;
            
            s = Console.ReadLine();
            t = Console.ReadLine();
            w = int.Parse(t);
            t = Console.ReadLine();
            h = int.Parse(t);

            if (w < 0)
            {
                Console.WriteLine("значение w должно быть неотрицательным");
                return;
            }
            if (h < 0)
            {
                Console.WriteLine("значение h должно быть неотрицательным");
                return;
            }

            int n = 0;
            int i = 0;

            while (n < h)
            {
                i = 0;
                while (i<w)
                {
                    Console.Write(s);
                    i = i+1;
                }
                n = n+1;
                Console.WriteLine();
            }
        }
    }
}

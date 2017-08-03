using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task31
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            int w;
            t = Console.ReadLine();
            w = int.Parse(t);

            if (w < 0)
            {
                Console.WriteLine("Значение w должно быть в интервале [0;20]");
                return;
            }
            if (w > 20)
            {
                Console.WriteLine("Значение w должно быть в интервале [0;20]");
                return;
            }

            
            int n = 0;
            int i = 0;

            while (n <= 9)
            {
                i = 0;
                while (i < w)
                {
                    Console.Write(n);
                    i = i + 1;
                }
                n = n + 1;
               
                Console.WriteLine();
            }
           
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task30
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

            int i = 0;
            

            while (i<w) 
            {
                Console.Write("a");                
                i = i + 1;
            }
            Console.WriteLine();
            i = 0;
            while (i < w)
            {
                Console.Write("b");
                i = i + 1;
            }
            Console.WriteLine();
            i = 0;
            while (i < w)
            {
                Console.Write("c");
                i = i + 1;
            }
            Console.WriteLine();
            i= 0;
            while (i < w)
            {
                Console.Write("d");
                i = i + 1;
            }
            Console.WriteLine();
            i= 0;
            while (i < w)
            {
                Console.Write("e");
                i = i + 1;
            }
            Console.WriteLine();
            i = 0;
            while (i < w)
            {
                Console.Write("f");
                i = i + 1;
            }
            Console.WriteLine();
            i = 0;
            while (i < w)
            {
                Console.Write("g");
                i = i + 1;
            }
            Console.WriteLine();
            i = 0;
            while (i < w)
            {
                Console.Write("h");
                i = i + 1;
            }
            Console.WriteLine();
        }
    }
}

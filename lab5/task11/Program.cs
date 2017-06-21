using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
           
            int a, b, c; 
            t = Console.ReadLine();
            a = int.Parse(t);
            t = Console.ReadLine();
            b = int.Parse(t);
            t = Console.ReadLine();
            c = int.Parse(t);

            if (a<b&&b<c)
            {
                Console.WriteLine("Выполняется");
            }
            else
            {
                Console.WriteLine("Не выполняется");
            }
        }
    }
}

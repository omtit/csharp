using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            t = Console.ReadLine();
            int a;
            a = int.Parse(t);
            if (a < -10 || a > 10000)
            {
                Console.WriteLine("а должно быть в диапазоне [-10:10000]");
                return;
            }
         
            int n=-10;
            int sum = 0;
            while (n<=a)
            {
                sum = sum + n;
                n = n + 1;
            }
            Console.Write(sum);
        }
    }
}

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
            t = Console.ReadLine();
            int a;
            a = int.Parse(t);
            if (a < -100 || a > 500)
            {
                Console.WriteLine("а должно быть в диапазоне [-100:500]");
                return;
            }
            int n = a;
            int b = 500;
            int sum = 0;
            while (-100<=a && a<=500) 
            {
                sum = sum + a;
                a = a + 1;
            }
            Console.Write(sum);
        }
    }
}

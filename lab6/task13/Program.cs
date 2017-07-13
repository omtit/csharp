using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
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

            int sum = 0;
            int n;

            if (a > b)
            {
                n = b;
                while (n <= a)
                {
                    
                    sum = sum + n;
                    n = n + 1;
                }
                
            }
            n = a;

            while (n <= b)
            {
                
                sum = sum + n;
                n = n + 1;
            }
            Console.WriteLine(sum);
        }
    }
}

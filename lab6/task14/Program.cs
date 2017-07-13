using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14
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

            long product = 1;
            int n;

            if (a > b)
            {
                n = b;
                while (n <= a)
                {
                    
                    product = product * n;
                    n = n + 1;
                }
                
            }
            n = a;

            while (n <= b)
            {

                product = product * n;
                n = n + 1;
            }
            Console.WriteLine(product);
        }
    }
}

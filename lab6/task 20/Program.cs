using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            int a, b;
            t = Console.ReadLine();
            a = int.Parse(t);
            t = Console.ReadLine();
            b = int.Parse(t);

            int i, n;
           
            long sum = 0;

            if (b > a)
            {
                i = a;
                while (i <= b)
                {
                    n = i * i;
                    i = i + 1;
                    sum = sum + n;
                }
            }
            else
            {
                i = b;
                while (i <= a)
                {
                    n = i * i;
                    i = i + 1;
                    sum = sum + n;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

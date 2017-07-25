using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task26
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

            int sum = 0;
            int n;

            if (a < b)
            {
                
                while (a <= b)
                {

                    if (a % 7 == 0)
                    {
                        n = a;
                        sum = sum + a;
                    }
                    a = a + 1;
                }
            }
            else
            {
                while (b <= a)
                {
                    if (b%7==0)
                    {
                        n = b;
                        sum = sum + b;
                    }
                    b = b + 1;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

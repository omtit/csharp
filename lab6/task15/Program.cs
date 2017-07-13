using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = 20;
            y = 40;

            int i = x;
            int a;
            int sum = 0;
            while (i <= y)
            {
                a = i * i * i;
                i = i + 1; 
                sum = sum + a;
                                              
            }
            Console.WriteLine(sum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task21
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            t = Console.ReadLine();
            int a, b, x;
            a = 10;
            b = 20;
            x = int.Parse(t);
               
            
            while (a <= b)
            {
                    if (x==a) 
                {
                    Console.WriteLine("{0}+", a);
                } 
                else
                {
                    Console.WriteLine(a);
                }
                a = a+1;
            }
            
        }
    }
}

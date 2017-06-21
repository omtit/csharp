using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            t = Console.ReadLine();
            int k;
            k = int.Parse(t);
            double i;
            if (k < 0)
            {
                i = k * k;
                Console.WriteLine(i);
            }
            else
            {
                i = Math.Sqrt(k);
                Console.WriteLine(i);
            }
            
            
                
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task28
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            int x;
            t = Console.ReadLine();
            x = int.Parse(t);
            int i = 0;

            if (x <= 0)
            {
                Console.WriteLine("Значение х должно быть положительным");
                return;
            }

            while (i <= x)
            {
                i = i+1;
                if (x%i==0)
                {

                    Console.Write("{0} ", i);
                }
                
            }
            
        }
    }
}

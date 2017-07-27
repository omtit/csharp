using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task27
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 100;
            int b = 1000;
            int count = 0;
            

            while (a <= b)
            {
               
                if (a % 13 == 0)
                {
                    count = count + 1;
                    
                }
                 a = a + 1;
               
            }
            Console.WriteLine("{0}", count);
        }
    }
}

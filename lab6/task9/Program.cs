using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, z;
            x = 1;            
            z = x * 7;
            while (x <= 9)
            {
                Console.WriteLine("{0} * 7 = {1}", x, z);
                x = x + 1;
                z = x * 7;
            }
        }
    }
}

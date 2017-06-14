using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task19
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            int x;
            int sum = 0;
            int count = 0;
            do
            {
                t = Console.ReadLine();
                x = int.Parse(t);
                sum = sum + x;
                count = count + 1;


            }
            while (sum < 1000);
            Console.WriteLine("{0}", count);
        }
    }
}

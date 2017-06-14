using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task18
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            int x;
            int sum=0;
            do
            {
                t = Console.ReadLine();
                x = int.Parse(t);
                sum = sum + x;
            }
            while (x != 0);

            Console.WriteLine("{0}", sum);
        }
    }
}

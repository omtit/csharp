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
            string t;
            t = Console.ReadLine();
            int A;
            A = int.Parse(t);
            int  M;
            M= A%360;
            Console.WriteLine("{0}", M);
        }
    }
}

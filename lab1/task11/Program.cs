using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            String CX, CY, R, FILL;
            CX = Console.ReadLine();
            CY = Console.ReadLine();
            R = Console.ReadLine();
            FILL = Console.ReadLine();
            Console.WriteLine("<circle cx=\"{0}\" cy=\"{1}\" r=\"{2}\" fill=\"{3}\"/>", CX, CY, R, FILL);
        }
    }
}

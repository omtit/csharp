using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {String msg;
            msg=Console.ReadLine();
            double a;
            a = Double.Parse(msg);
            Console.WriteLine("{0:F4}", a);
        }
    }
}

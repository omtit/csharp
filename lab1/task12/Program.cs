using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    class Program
    {
        static void Main(string[] args)
        {
            String xUSER, xPASS, xHOST, xPORT, xDB;
            xUSER = Console.ReadLine();
            xPASS = Console.ReadLine();
            xHOST = Console.ReadLine();
            xPORT = Console.ReadLine();
            xDB = Console.ReadLine();
            Console.WriteLine("User ID={0}; Password={1}; Host={2}; Port={3}; Database={4};", xUSER, xPASS, xHOST, xPORT, xDB);
        }
    }
}

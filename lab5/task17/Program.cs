using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task17
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            int M, P;
            t = Console.ReadLine();
            M = int.Parse(t);
            t = Console.ReadLine();
            P = int.Parse(t);

            if (P == 0)
            {
                Console.WriteLine("Значение P не должно быть равно нулю");
                return;
            }

            int MP;
            MP = M / P;

            
            
            if (M % P > 0)
            {
                Console.WriteLine("Не делится без остатка");
                return;
            }
            if (M % P == 0)
            {
                Console.WriteLine(MP);
                return;
            }
        }
    }
}

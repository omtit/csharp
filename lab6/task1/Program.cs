using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 13;// сколько нужно
            int i = 0;// сколько уже выполнено
            while (i < n)//работает пока меньше, чем надо
            {
                Console.Write("!");
                i = i + 1;//
                        }
            Console.WriteLine();
        }
    }
}

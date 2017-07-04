using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            int a, b, c;
            t = Console.ReadLine();
            a = int.Parse(t);
            t = Console.ReadLine();
            b = int.Parse(t);
            t = Console.ReadLine();
            c = int.Parse(t);

            if (a == 0)
            {
                Console.WriteLine("Данное уравнение не является квадратным");
                return;
            }
            int dis;
            dis = b * b - 4 * (a * c);
            
            if (dis>0)
            {
                Console.WriteLine("У уравнения {0}x^2+{1}x+{2}=0 два вещественных корня", a, b, c);
                return;
            }
            if (dis == 0)
            {
                Console.WriteLine("У уравнения {0}x^2+{1}x+{2}=0 один вещественный корень", a, b, c);
                return;
            }
            if (dis < 0)
            {
                Console.WriteLine("У уравнения {0}x^2+{1}x+{2}=0 нет вещественных корней", a, b,c);
                return;
            }
        }
    }
}

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
            double sc, ss;
            t = Console.ReadLine();
            sc = double.Parse(t);
            t = Console.ReadLine();
            ss = double.Parse(t);

            if (sc < 0)
            {
                Console.WriteLine("Площадь круга должна быть положительна");
                return;
            }
            if (ss < 0)
            {
                Console.WriteLine("Площадь квадрата должна быть положительна");
                return;
            }
            double scdi, ss1;
            scdi = (Math.Sqrt(sc / Math.PI))*2;
            ss1 = Math.Sqrt(ss) ;

             if (scdi > ss1)
            {
                Console.WriteLine("Круг не поместится в квадрате");                
            } else {
                Console.WriteLine("Круг поместится в квадрате");                
            }
            
        }
    }
}

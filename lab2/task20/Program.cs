using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task20
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            double mass, vel, height;

            t = Console.ReadLine();
            mass = double.Parse(t);
            t = Console.ReadLine();
            vel = double.Parse(t);
            t = Console.ReadLine();
            height = double.Parse(t);

            double g;
            g = 9.8067;

            if (mass <= 0)
            {
                Console.WriteLine("Значение mass должно быть положительным");
                return;
            }
            if (vel <= 0)
            {
                Console.WriteLine("Значение vel должно быть положительным");
                return;
            }
            if (height <= 0)
            {
                Console.WriteLine("Значение height должно быть положительным");
                return;
            }
            double kenergy, penergy;
            kenergy = (mass * (vel * vel))/2;
            penergy = mass * g * height;
            Console.WriteLine("Кинетическая энергия составляет: {0:F4} \n"  
            + "Потенциальная энергия составляет: {1:F4} \n", kenergy, penergy);
        }
    }
}

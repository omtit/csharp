using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task19
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            double vel, time, acc;
            t = Console.ReadLine();
            vel = double.Parse(t);
            t = Console.ReadLine();
            time = double.Parse(t);
            t = Console.ReadLine();
            acc = double.Parse(t);

            double dist;
            dist = vel * time + ((acc*(time*time))/2);
            Console.WriteLine("{0:F4}", dist);
        }
    }
}

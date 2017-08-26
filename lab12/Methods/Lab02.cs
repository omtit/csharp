using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    public class Lab02
    {
        public static double Task4411(double x)
        {
            return x + 7;
        }

        public static double Task8428(int a)
        {
            return a * Math.PI / 180;
        }

        public static double Task1262(int y)
        {
            return 5 * Math.Cos(y * Math.PI / 180);
        }

        public static double Task2790(int x)
        {
            double Sin = Math.Sin(x * Math.PI / 180.0);
            return Math.Sqrt(1.0 - Sin * Sin);
        }

        public static int Task3832(int x1, int x2, int x3)
        {
            return x1 * x2 + x1 * x3 + x2 * x3;
        }
    }
}

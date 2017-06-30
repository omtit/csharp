using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
      //      int x = 0;
          //  Console.WriteLine(x);
         //   x = 31;
         //   Console.WriteLine(x);

        //    int y = 0;
        //    y = 31;
        //    Console.WriteLine(y);
        //    Console.WriteLine(y);
            //------------------------------------------------
            int a, b;
            

            string data;
            string[] arrleft, arrright;
            data = Console.ReadLine();//
            arrleft = data.Split(' ');
            data = Console.ReadLine();//
            arrright = data.Split(' ');
           
                       
            if (arrleft.Length != arrright.Length)
            {
                Console.WriteLine ("Размер массива должен быть одинаковым");
                return;
            }
            int c;

           // a = int.Parse(arrleft[0]);
           // b = int.Parse(arrright[0]);
          //  c = a * b;
          //  Console.WriteLine(c);
          //  a = int.Parse(arrleft[1]);
          //  b = int.Parse(arrright[1]);
          //  c = a * b;
         //   Console.WriteLine(c);
          //  a = int.Parse(arrleft[2]);
          //  b = int.Parse(arrright[2]);
          //  c = a * b;
          //  Console.WriteLine(c);
          //  a = int.Parse(arrleft[3]);
          //  b = int.Parse(arrright[3]);
           // c = a * b;
           // Console.WriteLine(c);

            int i;
            i = 0;
            
            while (i<arrleft.Length)
            {
            a = int.Parse(arrleft[i]);
            b = int.Parse(arrright[i]);
            i = i + 1;
            c = a * b;
            Console.WriteLine(c);
            }
           
        }
    }
}

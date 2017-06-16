using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string data;
            
            data = Console.ReadLine();
            string[] arr;
            arr = data.Split(' ');
            int i = 0;

            //Console.WriteLine(arr[0] + " " + 0);
            //Console.WriteLine(arr[1] + " " + 1);
            //Console.WriteLine(arr[2] + " " + 2);
            //Console.WriteLine(arr[3] + " " + 3);

            //Console.WriteLine("-----------");

            //Console.WriteLine(arr[i] + " " + i);
            //i = i + 1;
            //Console.WriteLine(arr[i] + " " + i);
            //i = i + 1;
            //Console.WriteLine(arr[i] + " " + i);
            //i = i + 1;
            //Console.WriteLine(arr[i] + " " + i);
            //i = i + 1;

            Console.WriteLine("-------------");
            i = 0;
            while (i < arr.Length)
            {
                Console.WriteLine(arr[i] + " " + i);
                i = i + 1;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            data = Console.ReadLine();
            string[] arr;
            arr = data.Split(' ');
            

            Console.WriteLine(arr[4] + " ");
            Console.WriteLine(arr[3] + " ");
            Console.WriteLine(arr[2] + " ");
            Console.WriteLine(arr[1] + " ");
            Console.WriteLine(arr[0] + " ");

            Console.WriteLine("------------");
            int i;
            i = i - 1;

            Console.WriteLine(arr[i] + " ");
            i = i - 1;
            Console.WriteLine(arr[i] + " ");
            i = i - 1;
            Console.WriteLine(arr[i] + " ");
            i = i - 1;
            Console.WriteLine(arr[i] + " ");
            i = i - 1;
            Console.WriteLine(arr[i] + " ");
            i = i - 1;

           
        }
    }
}

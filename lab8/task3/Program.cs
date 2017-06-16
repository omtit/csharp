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
            

            

            Console.WriteLine("------------");

            int i = arr.Length;
            i = i - 1;

            while (i >= 0)
            {
                Console.WriteLine(arr[i] + " ");
                i = i - 1;
            }
        }
    }
}

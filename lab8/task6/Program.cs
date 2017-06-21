using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string t, data;
            t = Console.ReadLine();
            int a, b;
            a = int.Parse(t);//переменная первого элемента
            t = Console.ReadLine();
            b = int.Parse(t);//переменная последнего элемента
            
            data = Console.ReadLine();

            string[] arr;
            arr = data.Split(' ');

            if (0 > a)
            {
                Console.WriteLine("a должно быть в диапазоне [0, размер массива)");
                return;
            }
            if (a > arr.Length)
            {
                Console.WriteLine("a должно быть в диапазоне [0, размер массива)");
                return;
            }
            if (0 > b)
            {
                Console.WriteLine("b должно быть в диапазоне [0, размер массива)");
                return;
            }
            if (b > arr.Length)
            {
                Console.WriteLine("b должно быть в диапазоне [0, размер массива)");
                return;
            }

            int i;
            i = a;
            while (i<=b)
            {
            Console.Write(arr[i] + " ");
            i = i + 1;
            }
            
            
           
            
        }
    }
}

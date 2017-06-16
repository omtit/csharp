using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string data;
            string t;
            t = Console.ReadLine();
            data = Console.ReadLine();
            a = int.Parse(t);
            string[] arr;
            arr = data.Split(' ');
            if (a < 0)
            {
                Console.WriteLine ("a должно быть в диапазоне [0, размер массива)");
                return;
            }
            if (a > arr.Length)
            {
                Console.WriteLine("a должно быть в диапазоне [0, размер массива)");
                return;
            }
            if (string.IsNullOrWhiteSpace(data)) 
            {
                Console.WriteLine("Исходная строка пуста");
                return;
            }
            Console.WriteLine(arr[a]);
        }
    }
}

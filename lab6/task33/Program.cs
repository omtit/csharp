using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task33
{
    class Program
    {
        static void Main(string[] args)
        {
            //Получить от пользователя значение width
            string t;
            int w;
            t = Console.ReadLine();
            w = int.Parse(t);
            //Если width отрицательно, вывести сообщение об ошибке и завершить работу программы

            if (w < 0)
            {
                Console.WriteLine("Ширина не должна быть равной или меньше 0");
                return;
            }
            //Если width 0, то завершить работу программы
            if (w == 0)
            {
                return;
            }

            //Напечатать символ "плюс"
            Console.Write("+");
            //Напечатать width-2 символов "минус"
            int n = w - 2;
            int i = 0;
            while (i < n)
            {
                Console.Write("-");
                i = i + 1;
            }
            //Напечатать символ "плюс" и перенести на новую строку
            Console.WriteLine("+");
            //Напечатать вертикальную черту
            Console.Write("|");
            //Напечатать width-2 символов "точка"
             n = w - 2;
             i = 0;
             while (i < n)
             {
                 Console.Write(".");
                 i = i + 1;
             }
            //Напечатать вертикальную черту и перенести на новую строку
             Console.WriteLine("|");
            //Напечатать символ "плюс"
             Console.Write("+");
            //Напечатать width-2 символов "минус"
              n = w - 2;
              i = 0;
             while (i < n)
             {
                 Console.Write("-");
                 i = i + 1;
             }
            //Напечатать символ "плюс"
             Console.Write("+");

        }
    }
}

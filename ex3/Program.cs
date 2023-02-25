using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = 28800;
            int a, result;
            Console.WriteLine("Введите время првоеденное на рабочем месте в секундах");
            a = int.Parse(Console.ReadLine());
            if (a>=0)
            {
                result = (28800 - a) / 3600;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Ввели некорректное число, время не может быть отрицателным");
            }
        }
    }
}

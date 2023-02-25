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
            double a, roundedResult;
            Console.WriteLine("Введите время првоеденное на рабочем месте в секундах");
            a = int.Parse(Console.ReadLine());
            if (a>=0)
            {
                roundedResult = Math.Round((day - a) / 3600, 0);
                Console.WriteLine(roundedResult);
            }
            else
            {
                Console.WriteLine("Ввели некорректное число, время не может быть отрицательным");
            }
        }
    }
}

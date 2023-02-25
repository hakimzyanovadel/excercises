using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace excercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            double firstNumber, secondNumber, thirdNumber, fourthNumber;
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Исходное число - " + a);
            if (a.ToString().Length == 4)
            {
                firstNumber = a % 10;
                Console.WriteLine(firstNumber);
                secondNumber = a / 10 % 10;
                Console.WriteLine(secondNumber);
                thirdNumber = a / 100 % 10;
                Console.WriteLine(thirdNumber);
                fourthNumber = a / 1000;
                Console.WriteLine(fourthNumber);
                Console.WriteLine("Перевернутое значение - " + firstNumber.ToString() + secondNumber.ToString() + thirdNumber.ToString() + fourthNumber.ToString());
            }
            else
            {
                Console.WriteLine("Вы ввели не четырехзначное число");
            }
        }
    }
}

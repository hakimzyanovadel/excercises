using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, n6, n7;
            Console.WriteLine("Введите число n1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число n2");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число n3");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число n4");
            n4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число n5");
            n5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число n6");
            n6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число n7");
            n7 = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[7] { n1, n2, n3, n4, n5, n6, n7 };
            Console.WriteLine("Максимальное число =" + mas.Max());
            Console.WriteLine();
        }

        public static void ReferenceSolve()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());

            int i = 0;

            for (i = 0; i <= a || i <= b || i <= c || i <= d || i <= e || i <= f || i <= j; i++) { }

            Console.WriteLine(i - 1);
        }

    }
}

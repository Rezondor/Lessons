using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Anya
{
    internal class Lesson3
    {
        // Вводим метод с неопределенным числом параметров
        static int Sum(params int[] nums)
        {
            int sum = 0;
            foreach (int x in nums)
            {
                sum += x;
            }
            return sum;
        }

        class PropreSale
        {

            // Чистая функция - ничего не меняет вовне
            static int Propre(int a, int b)
            {
                return (a + b);
            }

            // Грязная функция - меняет внешнюю переменную
            public static int func_count = 0;
            public static int Sale(int a, int b)
            {
                func_count += 1;
                return (a - b);

            }

        }

        static void Main(string[] args)
        {
            int[] a = { 1, 2, 6, 7, 20, 39 };
            Console.WriteLine(Sum(a)); // Выводит 75

            // Три раза вызываем функцию, и func_count становится 3
            PropreSale.Sale(1, 2);
            PropreSale.Sale(1, 2);
            PropreSale.Sale(1, 2);
            Console.WriteLine(PropreSale.func_count); // Выводит 3

        }
    }
}

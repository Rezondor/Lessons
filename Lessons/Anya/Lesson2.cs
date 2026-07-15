using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Anya
{
    internal class Lesson2
    {
        /// <summary>
        /// Считаем сумму от 0 до х через рекурсию
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static int Sum(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            else
            {
                return Sum(x - 1) + x;
            }
        }


        static int Sum1(int x)
        {
            int s = 0;
            for (int i = 1; i <= x; i++)
            {
                s += i;
            }
            return s;
        }


        public static void main2(string[] args)
        {
            // Получаем число и обращаемся к методу
            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sum(num));

            // ________________________________________________

            // Лесенка с while
            int i = 1;
            int j = 1;
            while (i <= 5)
            {
                while (j <= i)
                {
                    Console.Write("-");
                    j += 1;
                }
                Console.WriteLine();
                j = 1;
                i += 1;
            }

            // Console.WriteLine(new string('-', 5));

            // Лесенка с do-while
            i = 1;
            j = 1;
            do
            {
                do
                {
                    Console.Write("-");
                    j += 1;
                } while (j <= i);
                Console.WriteLine();
                j = 1;
                i += 1;
            } while (i <= 5);

            // Лесенка с for
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();

            }

            // _________________________________

            // Создаем массив от 0 до 1000
            const int x = 1001;
            int[] a = new int[x];
            for (int k = 0; k < x; k++)
            {
                a[k] = k;
            }

            // Выводим в строку четные или кратные 3
            String str = "";
            foreach (int k in a)
            {
                //Console.WriteLine(k);
                if (k % 2 == 0 || k % 3 == 0)
                {
                    str = str + k.ToString() + " ";
                }
            }
            Console.WriteLine(str);

        }

    }
}

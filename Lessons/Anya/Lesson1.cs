using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Anya
{
    internal class Lesson1
    {
        public static void main1()
        {
            // Вводим строку
            Console.WriteLine("Введите строку: ");
            String str = Console.ReadLine();

            // Считаем слова и выводим
            int words = 0;
            /*for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    words += 1;
                }

            }
            words += 1;
            */

            string[] words1 = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            words = words1.Length;

            Console.WriteLine($"Количество слов в строке: {words}");
            //Console.WriteLine("Количество слов в строке: " + words);
            Console.WriteLine("Количество символов в строке: " + str.Length);

            //Заменяем а
            str = str.ToLower();
            if (words > 3)
            {
                str = str.Replace("а", "-");
            }
            else
            {
                str = str.Replace("а", "*");
            }

            Console.WriteLine("Измененная строка: " + str);

            // Смотрим, больше ли строка 15 символов
            if (str.Length > 15)
            {
                Console.WriteLine("Введённая строка больше 15 символов");
            }
            else
            {
                Console.WriteLine("Введённая строка меньше 15 символов");
            }
        }
    }
}

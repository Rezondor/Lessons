using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Artem
{
    internal class Lesson1
    {
        public static void GoGoGadget()
        {
            string inp = Console.ReadLine();

            int WordCount = Lesson1.WordCount(inp);

            Console.WriteLine($"Amount of words: {WordCount}");
            Console.WriteLine($"String length: {inp.Length}");

            Lesson1.CalculateAndPrintOutp(inp);

            if (inp.Length > 15)
            {
                Console.WriteLine("Введённая строка больше 15 символов");
            }
            else
            {
                Console.WriteLine("Введённая строка меньше 15 символов");
            }
        }

        static int WordCount(string inp)
        {
            int WordCount = 0;
            bool isAlphaNumeric = false;
            for (int i = 0; i < inp.Length; i++)
            {
                if ((isAlphaNumeric) && (inp[i] == ' '))
                {
                    isAlphaNumeric = false;
                }
                else if (!isAlphaNumeric && inp[i] != ' ')
                {
                    WordCount++;
                    isAlphaNumeric = true;
                }
            }
            return WordCount;
        }

        static void CalculateAndPrintOutp(string inp)
        {
            int WordCount = Lesson1.WordCount(inp);
            string Outp = inp.ToLower();

            if (WordCount > 3)
            {
                Outp = Outp.Replace("а", "-");
            }
            else
            {
                Outp = Outp.Replace("а", "*");
            }

            Console.WriteLine(Outp);
        }
    }
}

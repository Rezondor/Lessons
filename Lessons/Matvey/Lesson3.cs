using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Matvey
{
    internal class Lesson3
    {
        public static void Start()
        {
            do
            {
                Interacticve();
            } while (AnswerIsTrue());
        }

        static void Interacticve()
        {
            Console.WriteLine("Введите числа через запятую:");
            string userInput = Console.ReadLine();
            var stringDigits = userInput.Split(',').Where(x => x.Length > 1).Select(x => int.Parse(x)).ToList();

            int[] digits = Pure.Digits(stringDigits);
            int sum = Pure.Sum(digits);

            Console.WriteLine();
            Console.WriteLine($"Сумма введенных числен равна: {sum}");

            //Чистые
            int amountOfLetters = Pure.PureWords(Pure.word);
            int sumPlusOne = Pure.PureDigits(sum);

            //Грязная
            string dirtyWord = Dirty.DirtyWords();

            Console.WriteLine($"{Pure.word}");
        }

        static bool AnswerIsTrue()
        {
            Console.WriteLine("\nПовторим? Да/Нет\n");

            string trueAnswer = "да";
            string falseAnswer = "нет";
            string[] correctAnswers = new string[] { trueAnswer, falseAnswer };

            string answer = Answer();

            while (string.IsNullOrEmpty(answer) || !correctAnswers.Contains(answer))
            {
                Console.WriteLine("Нормально введи, заебал");
                answer = Answer();
            }

            if (answer.Equals(trueAnswer))
            {
                return true;
            }

            return false;
        }

        static string Answer()
        {
            string answer = Console.ReadLine();
            string lowerAnswer = answer.ToLower();
            return lowerAnswer;
        }
    }

    public static class Pure
    {
        public static int[] Digits(string[] stringDigits)
        {
            List<int> digits = new List<int> { };

            foreach (string stringDigit in stringDigits)
            {
                int.TryParse(stringDigit, out int digit);
                digits.Add(digit);
            }

            return digits.ToArray();
        }

        public static int Sum(params int[] digits)
        {
            int sum = 0;
            foreach (int digit in digits)
            {
                sum += digit;
            }

            return sum;
        }

        public static string word = "ОПА";

        public static int PureDigits(int sum)
        {
            sum += 1;
            return sum;
        }
        public static int PureWords(string word)
        {
            int sum = 0;
            foreach (char letter in word)
            {
                sum += 1;
            }
            return sum;
        }
    }

    public static class Dirty
    {
        public static int count;
        public static string DirtyWords()
        {
            Pure.word = "привет" + count;
            count++;
            return Pure.word;
        }
    }
}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Matvey
{
    internal class Lesson2
    {
        public static void Start()
        {
            do
            {
                Dialogue();
            } while (AnswerIsTrue());
        }

        static bool AnswerIsTrue()
        {
            Console.WriteLine("\nПовторим? Да/Нет\n");
            string answer = Console.ReadLine();

            string trueAnswer = "да";
            string falseAnswer = "нет";

            string[] correctAnswers = new string[] { trueAnswer, falseAnswer };

            string lowerAnswer = answer.ToLower();

            if (string.IsNullOrEmpty(answer) || !correctAnswers.Contains(lowerAnswer))
            {
                Console.WriteLine("Нормально введи, заебал");
                return AnswerIsTrue();
            }

            if (lowerAnswer.Equals(trueAnswer))
            {
                return true;
            }

            return false;
        }

        static void Dialogue()
        {
            Console.WriteLine("Выберите команду для проверки дз:");
            Console.WriteLine("1. Сумма чисел до введенного.");
            Console.WriteLine("2. Цикл 'While'.");
            Console.WriteLine("3. Цикл 'DoWhile'.");
            Console.WriteLine("4. Цикл 'For'.");
            Console.WriteLine("5. Цикл 'ForEach'.");

            string userInput = Console.ReadLine();
            bool isDigit = int.TryParse(userInput, out int numberOfComand);
            if (!isDigit)
            {
                Console.WriteLine();
                Console.WriteLine("Требуется ввести число.");
                Main();
            }

            switch (numberOfComand)
            {
                case 1:

                    Console.WriteLine("Введите число для проверки:");
                    int digit = UsersInput();
                    TriangelDigit(digit);

                    break;
                case 2:

                    Console.WriteLine("Введите желаемую длину лесенки:");
                    int lengthOfLadder = UsersInput();
                    WhileCycle(lengthOfLadder);

                    break;
                case 3:

                    Console.WriteLine("Введите желаемую длину лесенки:");
                    int lengthOfLadder2 = UsersInput();
                    DoWhileCycle(lengthOfLadder2);

                    break;
                case 4:

                    Console.WriteLine("Введите желаемую длину лесенки:");
                    int lengthOfLadder3 = UsersInput();
                    ForCycle(lengthOfLadder3);

                    break;
                case 5:

                    ForEach();

                    break;
                default:

                    Console.WriteLine("Команда не распознана");
                    break;
            }
        }

        static void TriangelDigit(int digit)
        {
            int TriangelDigit = 0;
            while (digit > 0)
            {
                TriangelDigit += digit;
                digit -= 1;
            }

            Console.WriteLine($"{TriangelDigit}"); ;
        }

        static void WhileCycle(int lengthOfLadder)
        {
            int currentNumberOfSteps = 1;
            while (lengthOfLadder >= currentNumberOfSteps)
            {
                LadderOuput(currentNumberOfSteps);
                currentNumberOfSteps++;
            }
        }

        static void DoWhileCycle(int lengthOfLadder)
        {
            int currentNumberOfSteps = 1;
            do
            {
                LadderOuput(currentNumberOfSteps);
                currentNumberOfSteps++;
            }
            while (lengthOfLadder >= currentNumberOfSteps);
        }

        static void ForCycle(int lengthOfLadder)
        {
            for (int currentNumberOfSteps = 1; lengthOfLadder >= currentNumberOfSteps; currentNumberOfSteps++)
            {
                LadderOuput(currentNumberOfSteps);
            }
        }

        static void ForEach()
        {
            // Верхняя граница вывода чисел
            int targetNumber = 1000;
            int[] digits = new int[targetNumber];
            for (int i = 1; i != targetNumber; i++)
            {
                digits[i] = i;
            }

            string outputDigits = "";
            char space = ' ';
            var sb = new StringBuilder();
            foreach (int i in digits)
            {
                if (int.IsEvenInteger(i) || i % 3 == 0)
                {
                    outputDigits = string.Concat(outputDigits, i, space);
                    sb.Append(i);
                    sb.Append(space);

                }

            }
            Console.WriteLine($"{outputDigits}");
        }
        /// <summary>
        /// Описание
        /// </summary>
        /// <param name="currentNumberOfSteps"> Описание параметра </param>
        static void LadderOuput(int currentNumberOfSteps)
        {
            char dash = '-';
            string output = string.Concat(Enumerable.Repeat(dash, currentNumberOfSteps));
            string output2 = new string(dash, currentNumberOfSteps);
            Console.WriteLine($"{output}");
        }

        static int UsersInput()
        {
            string userInput = Console.ReadLine();
            bool isDigit = int.TryParse(userInput, out int usersInput);
            if (!isDigit)
            {
                Console.WriteLine("Требуется ввести число.");
                return UsersInput();
            }
            else if (usersInput == 0 || int.IsNegative(usersInput))
            {
                Console.WriteLine("Введите число больше 0 :");
                return UsersInput();
            }

            return usersInput;
        }
    }
}

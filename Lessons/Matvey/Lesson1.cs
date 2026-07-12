using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Matvey
{
    internal static class Lesson1
    {
        public static void Start()
        {
            while (MessageParsing.ParseMessageUntilExit())
            {
                continue;
            }
        }
    }

    internal static class MessageParsing
    {
        public static bool ParseMessageUntilExit()
        {

            Console.WriteLine("Введи предложение:");
            string message = Console.ReadLine();

            if (string.IsNullOrEmpty(message))
            {
                Console.WriteLine("Нормально введи, заебал");
                return false;
            }

            int amountOfLetters = message.Length;
            int amountOfWords = message.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;

            string lowerMessage = message.ToLower();
            char newChar;

            int limitOfWords = 3;

            if (amountOfWords > limitOfWords)
            {
                newChar = '-';
            }
            else
            {
                newChar = '*';
            }

            lowerMessage = lowerMessage.Replace('а', newChar);

            Console.WriteLine();
            Console.WriteLine($"Количество символов: {amountOfLetters}");
            Console.WriteLine($"Количество слов: {amountOfWords}");

            Console.WriteLine($"Обновленное предложение: {lowerMessage}");

            int limitOfLetters = 15;

            if (amountOfLetters > limitOfLetters)
            {
                Console.WriteLine($"Строка БОЛЬШЕ {limitOfLetters} символов.");
            }
            else
            {
                Console.WriteLine($"Строка МЕНЬШЕ ИЛИ РАВНО {limitOfLetters} символов.");
            }

            return MessageParsing.Question();
        }

        private static bool Question()
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
                MessageParsing.Question();
            }

            if (lowerAnswer.Equals(trueAnswer))
            {
                return true;
            }

            return false;
        }
    }
}

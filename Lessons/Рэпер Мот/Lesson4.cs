using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lessons.Рэпер_Мот
{
    internal class Lesson4
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
            Console.WriteLine("Первое:");
            Console.WriteLine();
            FirstExercise.FirstOne();
            Console.WriteLine();

            Console.WriteLine("Второе:");
            Console.WriteLine();
            SecondExercise.SecondOne();
            Console.WriteLine();

            Console.WriteLine("Третье:");
            Console.WriteLine();
            ThirdExercise.ThirdOne();
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

    public static class FirstExercise
    {
        public static void FirstOne()
        {
            List<int> list1 = new List<int>();
            list1.Capacity = 10;

            for (int i = 0; i < 10; i++)
            {
                int numberIntoTheList = -1;
                list1.Add(numberIntoTheList);
            }

            string FirstExersice = string.Join("\t", list1);
            Console.WriteLine(FirstExersice);

            for (int i = 0; i < 10; i++)
            {
                if ((i - 2) % 3 == 0)
                {
                    list1[i] = i;
                }

                if (int.IsEvenInteger(i))
                {
                    list1[i] = list1[i] * 2;
                }
            }

            FirstExersice = string.Join("\t", list1);
            Console.WriteLine(FirstExersice);
        }
    }

    public static class SecondExercise
    {
        public static void SecondOne()
        {
            int[] mas1 = new int[100];
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                mas1[i] = random.Next(-1000, 1000);
            }

            string beforeSort = string.Join("\t", mas1);
            Console.WriteLine(beforeSort);
            Console.WriteLine();

            //факин бабл сорт
            int[] mas2 = new int[100];
            mas1.CopyTo(mas2);

            mas2 = BubbleSort(mas2);

            string bubbleSortString = string.Join("\t", mas2);
            Console.WriteLine("баблсорт \n");
            Console.WriteLine(bubbleSortString);
            Console.WriteLine();

            //квиксорт
            mas1.CopyTo(mas2);
            mas2 = QuickSort(mas2);
            string quickSortString = string.Join("\t", mas2);
            Console.WriteLine("квиксорт \n");
            Console.WriteLine(quickSortString);
        }

        public static int[] BubbleSort(int[] mas2)
        {
            for (int i = mas2.Length; i > 0; i--)
            {
                bool flag = false;
                for (int j = 1; j < mas2.Length; j++)
                {
                    if (mas2[j - 1] > mas2[j])
                    {
                        int temp = mas2[j];
                        mas2[j] = mas2[j - 1];
                        mas2[j - 1] = temp;
                        flag = true;
                    }
                }
                if (!flag)
                {
                    break;
                }
            }

            return mas2;
        }

        public static int[] QuickSort(int[] mas)
        {
            if (mas.Length < 2)
            {
                return mas;
            }

            List<int> lowerMas = new List<int> { };
            List<int> equalMas = new List<int> { };
            List<int> higherMas = new List<int> { };

            int middleOfMass = mas[mas.Length / 2];
            foreach (int i in mas)
            {
                if (i > middleOfMass)
                {
                    higherMas.Add(i);
                }
                else if (i < middleOfMass)
                {
                    lowerMas.Add(i);
                }
                else if (i == middleOfMass)
                {
                    equalMas.Add(i);
                }
            }
            int[] lowerArray = lowerMas.ToArray();

            if (lowerMas.Count >= 2)
            {

                lowerArray = QuickSort(lowerArray);

            }

            int[] higherArray = higherMas.ToArray();

            if (higherMas.Count >= 2)
            {
                higherArray = QuickSort(higherArray);
            }

            int[] fullSortedArray = lowerArray.Append(middleOfMass).Concat(higherArray).ToArray();
            return fullSortedArray;
        }
    }

    public static class ThirdExercise
    {
        public static void ThirdOne()
        {
            int[] ints1 = new int[100];
            int[] ints2 = new int[1000];
            int[] ints3 = new int[10000];
            int[] ints4 = new int[100000];

            ints1 = FullInts(ints1);
            ints2 = FullInts(ints2);
            ints3 = FullInts(ints3);
            ints4 = FullInts(ints4);

            double orderTime1 = OrderSortTime(ints1);
            double orderTime2 = OrderSortTime(ints2);
            double orderTime3 = OrderSortTime(ints3);
            double orderTime4 = OrderSortTime(ints4);

            double arraySortTime1 = ArraySortTime(ints1);
            double arraySortTime2 = ArraySortTime(ints2);
            double arraySortTime3 = ArraySortTime(ints3);
            double arraySortTime4 = ArraySortTime(ints4);

            double bubbleTime1 = BubbleSortTime(ints1);
            double bubbleTime2 = BubbleSortTime(ints2);
            double bubbleTime3 = BubbleSortTime(ints3);
            double bubbleTime4 = BubbleSortTime(ints4);

            double quickTime1 = BubbleSortTime(ints1);
            double quickTime2 = BubbleSortTime(ints2);
            double quickTime3 = BubbleSortTime(ints3);
            double quickTime4 = BubbleSortTime(ints4);

            string format = "{0, 15} | {1, -15} | {2, -15} | {3, -15} | {4, -15}";

            Console.WriteLine(format, " Размер массива ", "order", "arraySort", "bubble", "quick");
            Console.WriteLine(new string('-', 95));

            Console.WriteLine(format, "100", orderTime1, arraySortTime1, bubbleTime1, quickTime1);
            Console.WriteLine(new string('-', 95));
            Console.WriteLine(format, "1000", orderTime2, arraySortTime2, bubbleTime2, quickTime2);
            Console.WriteLine(new string('-', 95));
            Console.WriteLine(format, "10000", orderTime3, arraySortTime3, bubbleTime3, quickTime3);
            Console.WriteLine(new string('-', 95));
            Console.WriteLine(format, "100000", orderTime4, arraySortTime4, bubbleTime4, quickTime4);
            Console.WriteLine(new string('-', 95));

        }


        public static int[] FullInts(int[] ints)
        {

            Console.WriteLine(ints.Length);
            Random random = new Random();
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = random.Next(-1000000, 1000000);
            }
            return ints;
        }

        public static double OrderSortTime(int[] ints)
        {
            var watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < 5; i++)
            {
                ints = ints.Order().ToArray();
            }
            watch.Stop();
            double seconds = watch.Elapsed.TotalSeconds;

            return seconds;
        }

        public static double ArraySortTime(int[] ints)
        {
            var watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < 5; i++)
            {
                Array.Sort(ints);
            }
            watch.Stop();
            double seconds = watch.Elapsed.TotalSeconds;

            return seconds;
        }

        public static double BubbleSortTime(int[] ints)
        {
            var watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < 5; i++)
            {
                ints = SecondExercise.BubbleSort(ints);
            }
            watch.Stop();
            double seconds = watch.Elapsed.TotalSeconds;

            return seconds;
        }

        public static double QuickSortTime(int[] ints)
        {
            var watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < 5; i++)
            {
                ints = SecondExercise.QuickSort(ints);
            }
            watch.Stop();
            double seconds = watch.Elapsed.TotalSeconds;

            return seconds;
        }
    }
}

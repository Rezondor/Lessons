using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lessons.Artyom
{
    internal class Lesson4
    {
        public static void Task1()
        {
            List<int> ListTask1 = new List<int>(10);

            for (int i = 0; i < 10; i++)
            {
                ListTask1.Add(-1);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i % 3 == 0)
                {
                    ListTask1[i] = i;
                }

                if (i % 2 == 0)
                {
                    ListTask1[i] *= 2;
                }
            }

            Console.WriteLine(string.Join("\t", ListTask1));
        }

        public static void Task2()
        {

            Random rand = new Random();
            int[] arr = new int[100];

            for (int i = 0;i < arr.Length; i++)
            {
                arr[i] = rand.Next(-1000, 1000);
            }

            Console.WriteLine("Generated array:");
            Console.WriteLine(string.Join("\t", arr));
            Console.WriteLine("__________________________________");

            Lesson4.BubbleSort(ref arr);

            Console.WriteLine("Sorted generated array:");
            Console.WriteLine(string.Join("\t", arr));
        }

        public static void Task3()
        {
            // Порядок результатов в массиве:
            // 100, 1k, 10k, 100k
            long[] ResultsBubble = new long[4] {0, 0, 0, 0 };
            long[] ResultsOrder = new long[4] { 0, 0, 0, 0 };
            long[] ResultsSort = new long[4] { 0, 0, 0, 0 };

            CalculateAverageTime("bubble", ref ResultsBubble);
            CalculateAverageTime("order", ref ResultsOrder);
            CalculateAverageTime("sort", ref ResultsSort);

            Console.WriteLine("\t100|\t1k|\t10k|\t100k");

            Console.WriteLine($"Bubble|\t{string.Join("|\t", ResultsBubble)}");
            Console.WriteLine($"Order|\t{string.Join("|\t", ResultsOrder)}");
            Console.WriteLine($"Sort|\t{string.Join("|\t", ResultsSort)}");
        }

        static void CalculateAverageTime(string Method, ref long[] ResultArray)
        {
            Stopwatch stopwatch = new Stopwatch();

            for (int i = 0; i < ResultArray.Length; i++)
            {
                int curSize = 100;
                for (int j = 0; j < i; j++)
                {
                    curSize *= 10;
                }

                for (int j = 1; j <= 5; j++)
                {
                    int[] curArr = Lesson4.GenerateArray(curSize);
                    if (Method == "bubble")
                    {
                        stopwatch.Start();
                        Lesson4.BubbleSort(ref curArr);
                        stopwatch.Stop();
                    }
                    else if (Method == "order")
                    {
                        stopwatch.Start();
                        curArr.Order();
                        stopwatch.Stop();
                    }
                    else
                    {
                        stopwatch.Start();
                        curArr.Sort();
                        stopwatch.Stop();
                    }

                    ResultArray[i] = ResultArray[i] + (stopwatch.ElapsedMilliseconds - ResultArray[i]) / j;
                    stopwatch.Reset();

                }
            }
        }

        static int[] GenerateArray(int Len)
        {
            Random rand = new Random();
            int[] arr = new int[Len];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100000, 100000);
            }

            return arr;
        }

        static void BubbleSort(ref int[] arr)
        {
            bool swapped;
            int buf = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                swapped = false;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        buf = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = buf;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }
    }
}

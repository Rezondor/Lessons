using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Artyom
{
    internal class Lesson2
    {
        public static int CalculateSum(int n)
        {
            int sum = (n * (n + 1)) / 2;
            Console.WriteLine(sum);
            return sum;
        }

        public static void PrintLadderFor(int n)
        {
            for (int i = 1; i <= n; i++) 
            { 
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }   
        }
        public static void PrintLadderDoWhile(int n)
        {
            if (n <= 0)
            {
                return;
            }

            int i = 1;
            do
            {
                int j = 1;
                do
                {
                    Console.Write("-");
                    j++;
                }
                while (j <= i);
                Console.WriteLine();
                i++;
            }
            while (i <= n);
        }

        public static void PrintLadderWhile(int n)
        {
            int i = 1;
            while (i <= n)
            {
                int j = 1;
                while (j <= i)
                {
                    Console.Write("-");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }

        public static void ArrayFunc()
        {
            int[] arr = new int[1001];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            foreach (int i in arr)
            {
                if ((i % 2 == 0) || (i % 3 == 0))
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}

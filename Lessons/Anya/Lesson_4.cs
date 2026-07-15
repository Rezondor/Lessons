using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lessons.Anya
{
    internal class Lesson_4
    {
        static TimeSpan Sort_Order(int number_of_elems)
        {
            int[] array = new int[number_of_elems];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100000, 100000);

            }

            DateTime time1 = DateTime.Now;
            array = array.Order().ToArray();
            DateTime time2 = DateTime.Now;

            TimeSpan time_order = time2 - time1;

            return time_order;
        }

        static TimeSpan Sort_Arraysort(int number_of_elems)
        {
            int[] array = new int[number_of_elems];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100000, 100000);

            }

            DateTime time1 = DateTime.Now;
            Array.Sort(array);
            DateTime time2 = DateTime.Now;

            TimeSpan time_arraysort = time2 - time1;

            return time_arraysort;
        }

        static TimeSpan Sort_Bubblesort(int number_of_elems)
        {
            int[] array = new int[number_of_elems];
            Random rand = new Random();
            int x;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100000, 100000);

            }

            DateTime time1 = DateTime.Now;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        x = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = x;
                    }
                }
            }
            DateTime time2 = DateTime.Now;

            TimeSpan time_bubblesort = time2 - time1;

            return time_bubblesort;
        }

        public static void Lesson_4_Main()
        {
            
            /*Задача №1
            Создать Список int из 10 элементов и заполнить все -1
            Каждый 3 элемент необходимо заменить на порядковый номер ячейки в массиве (Начиная с 0)
            Каждый 2 элемент умножаем на 2
            Вывести на экран все элементы списка в строку с разделителем \t
            */
            List<int> lst1 = new List<int>();
            int num_elem = 10;
            for (int i = 0; i < num_elem; i++)
            {
                lst1.Add(-1);
            }

            for (int i = 0; i < num_elem; i++)
            {
                if ((i + 1) % 3 == 0)
                {
                    lst1[i] = i;
                }
                if ((i + 1) % 2 == 0)
                {
                    lst1[i] *= 2;
                }
            }

            foreach (int i in lst1)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine("\n______________");

            /*Задача №2
            Создать массив на 100 элементов
            Заполнить его случайными числами от -1000 до 1000
            Реализовать простейшую сортировку пузырьком
            Вывести элементы до сортировки в строку с разделителем \t
            Вывести элементы после сортировки в строку с разделителем \t
            */
            num_elem = 100;
            int x;
            int[] arr = new int[num_elem];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-1000, 1000);
                Console.Write($"{arr[i]}\t");
            }

            Console.WriteLine("\n______________");

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        x = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = x;
                    }
                }
            }

            foreach (int i in arr)
            {
                Console.Write($"{i}\t");
            }

            Console.WriteLine("\n______________\n");

            /*Задача №3
            Изучить что за метод расширения.Order()
            Реализовать сравнение скорости работы .Order(), Array.Sort(...) и сортировки пузырьком
            Для коллекции в 100, 1к, 10к, 100к заполненных случайными числами от - 100к до 100к
            В результате должна получиться таблица:
            По вертикали -Тип сортировки
            По горизонтали - размер массива
            В каждую ячейку вывести среднее время работы сортировки для 5 попыток
            */

            int num_tries = 5;
            Console.WriteLine("Тип сортировки:       100 элементов       1к элементов        10к элементов       100к элементов");
            Console.WriteLine("_______________");

            Console.Write("Order: ");

            TimeSpan sum_time = TimeSpan.Zero;
            for (int i = 0; i < num_tries; i++)
            {
                sum_time += Sort_Order(100);
            }
            Console.Write($"        {sum_time / num_tries}");

            sum_time = TimeSpan.Zero;
            for (int i = 0; i < num_tries; i++)
            {
                sum_time += Sort_Order(1000);
            }
            Console.Write($"        {sum_time / num_tries}");

            sum_time = TimeSpan.Zero;
            for (int i = 0; i < num_tries; i++)
            {
                sum_time += Sort_Order(10000);
            }
            Console.Write($"        {sum_time / num_tries}");

            sum_time = TimeSpan.Zero;
            for (int i = 0; i < num_tries; i++)
            {
                sum_time += Sort_Order(100000);
            }
            Console.Write($"        {sum_time / num_tries}");

            Console.WriteLine("\n_______________");

            Console.Write("ArraySort: ");

            sum_time = TimeSpan.Zero;
            for (int i = 0; i < num_tries; i++)
            {
                sum_time += Sort_Arraysort(100);
            }
            Console.Write($"        {sum_time / num_tries}");

            sum_time = TimeSpan.Zero;
            for (int i = 0; i < num_tries; i++)
            {
                sum_time += Sort_Arraysort(1000);
            }
            Console.Write($"        {sum_time / num_tries}");

            sum_time = TimeSpan.Zero;
            for (int i = 0; i < num_tries; i++)
            {
                sum_time += Sort_Arraysort(10000);
            }
            Console.Write($"        {sum_time / num_tries}");

            sum_time = TimeSpan.Zero;
            for (int i = 0; i < num_tries; i++)
            {
                sum_time += Sort_Arraysort(100000);
            }
            Console.Write($"        {sum_time / num_tries}");

            Console.WriteLine("\n_______________");

            Console.Write("BubbleSort: ");

            sum_time = TimeSpan.Zero;
            for (int i = 0; i < num_tries; i++)
            {
                sum_time += Sort_Bubblesort(100);
            }
            Console.Write($"        {sum_time / num_tries}");

            sum_time = TimeSpan.Zero;
            for (int i = 0; i < num_tries; i++)
            {
                sum_time += Sort_Bubblesort(1000);
            }
            Console.Write($"        {sum_time / num_tries}");

            sum_time = TimeSpan.Zero;
            for (int i = 0; i < num_tries; i++)
            {
                sum_time += Sort_Bubblesort(10000);
            }
            Console.Write($"        {sum_time / num_tries}");

            sum_time = TimeSpan.Zero;
            for (int i = 0; i < num_tries; i++)
            {
                sum_time += Sort_Bubblesort(100000);
            }
            Console.Write($"        {sum_time / num_tries}");

            Console.WriteLine("\n_______________");

        }
    }

}

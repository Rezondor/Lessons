using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Artyom
{
    internal class Lesson3
    {
        public static int Sum(params int[] nums)
        {
            int sum = 0;
            foreach (int num in nums) 
            {
                sum += num;
            }

            return sum;
        }
    }

    internal class Lesson3Clean
    {
        public static int Sum(params int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }

            return sum;
        }
    }
    internal class Lesson3Dirty
    {
        public static int SumAndUpdateTotal(ref int total, params int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }

            total = sum;
            return sum;
        }
    }
}

using System;
using System.Collections.Generic;

namespace DelegatesPractice
{
    class Program
    {

        public delegate bool IsEvenDelegate(int num);

        static void Main(string[] args)
        {

            List<int> nums = new List<int>();
            nums.Add(2);
            nums.Add(8);
            nums.Add(7);
            nums.Add(242);
            nums.Add(193);
            nums.Add(13);
            nums.Add(100);
            Console.Write("List: ");
            foreach (int num in nums)
                Console.Write(num + ", ");
            Console.WriteLine();

            Console.WriteLine("Count of even numbers: " + CountEvenNumbers(nums, IsEven));

        }

        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        public static int CountEvenNumbers(List<int> nums, IsEvenDelegate func)
        {
            int count = 0;
            foreach (int num in nums)
            {
                if (func(num))
                    count++;
            }
            return count;
        }

    }
}

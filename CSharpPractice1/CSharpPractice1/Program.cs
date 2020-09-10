using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpPractice1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("List:\n");
            List<int> list = FillList();
            for (int i = 0; i < list.Count; i++)
                Console.Write(list[i] + " ");
            Console.WriteLine("\n");

            var listAttributes = GetListAttributes(list);
            Console.WriteLine("Average: " + listAttributes.average);
            Console.WriteLine("Count: " + listAttributes.count);
            Console.WriteLine();

            var longestStrings = GetLongestStrings();
            foreach (var tuple in longestStrings)
                Console.WriteLine("({0}, {1})", tuple.Item1, tuple.Item2);

        }

        public static List<int> FillList()
        {
            List<int> list = new List<int>();
            int i = 1;
            while (list.Count < 500)
            {
                if (i % 2 == 0 && i % 3 == 0 && i % 10 != 0)
                    list.Add(i);
                i++;
            }
            return list;
        }

        public static (int average, int count) GetListAttributes(List<int> list)
        {
            int sum = 0;
            foreach (int value in list)
                sum += value;
            int average = sum / list.Count;
            return (average: average, count: list.Count);
        }

        public static string GetLongestString(List<string> list)
        {
            string str = "";
            int maxLength = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length > maxLength)
                {
                    str = list[i];
                    maxLength = list[i].Length;
                }
            }
            return str;
        }
        
        public static List<(string, int)> GetLongestStrings()
        {
            List<string> strings = new List<string>();
            while (strings.Count < 4)
            {
                Console.Write("Please enter a string: ");
                string str = Console.ReadLine();
                strings.Add(str);
            }
            List<(string, int)> list = new List<(string, int)>();
            for (int i = 0; i < 2; i++)
            {
                string longestString = GetLongestString(strings);
                list.Add((longestString, longestString.Length));
                strings.Remove(longestString);
            }
            return list;
        }

    }
}


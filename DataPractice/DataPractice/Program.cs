using System;
using System.Collections.Generic;

namespace DataPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<(string First, string Last)>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Name " + (i + 1) + ": ");
                string name = Console.ReadLine();
                string[] nameComponents = name.Split(" ");
                list.Add((First: nameComponents[0], Last: nameComponents[1]));
            }
            Console.WriteLine();
            foreach (var name in list)
                Console.WriteLine(name);
            Console.WriteLine();

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            for (int i = 0; i < list.Count; i++)
                dictionary.Add(i, list[i].First);
            foreach (var kvp in dictionary)
                Console.WriteLine(kvp);

        }
    }
}

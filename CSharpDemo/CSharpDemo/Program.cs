using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDemo
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Please enter a string : ");
            string str1 = Console.ReadLine();
            Console.Write("Please enter a second string : ");
            var str2 = Console.ReadLine();
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            int total = 0;
            do
            {
                Console.Write("Please enter a number - 0 to stop : ");
                str1 = Console.ReadLine();
                try
                {
                    total += Int32.Parse(str1);
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("Please enter an integer.");
                }
            } while (!str1.Equals("0"));
            Console.WriteLine(total);

            List<int> list = new List<int>();
            int x = 1;
            while (x <= 10)
            {
                list.Add(x);
                x++;
            }
            // Console.WriteLine(list);
            for (int i = 1; i < list.Count; i++)
                Console.WriteLine(list.ElementAt(i) + " or " + list[i]);
            foreach (int number in list)
                Console.WriteLine("Num : {0} is a number. {1} is the string we used before.", number, str1);

            var tupleOne = (1, "apple", 2);
            var tupleTwo = (firstName: "Bob", secondName: "Smith");
            Console.WriteLine(tupleOne.Item1);
            Console.WriteLine(tupleTwo.firstName);

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("E302", "Schiff");
            dictionary.Add("100", "Miller");
            dictionary.Add("205", "Hayston");
            string name = "";
            dictionary.TryGetValue("100", out name);
            Console.WriteLine(name);

            Console.WriteLine(NamePairMaker("first word", "second word"));

        }

        public static (string, string) NamePairMaker(string first, string second)
        {
            return (first, second);
        }

    }
}


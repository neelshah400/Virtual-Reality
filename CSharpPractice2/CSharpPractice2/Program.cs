using System;
using System.Collections.Generic;

namespace CSharpPractice2
{
    class Program
    {

        static void Main(string[] args)
        {

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("English", "Ms. Lehre");
            // dictionary.Add("Computer Science", "Mr. Dentler");
            dictionary.Add("Computer Science", "Mr. Schiff");
            dictionary.Add("Science", "Mr. Sadowsky");
            dictionary.Add("Gym", "Mr. Hoehman");
            dictionary.Add("World Language", "Mr. Kostovny");
            dictionary.Add("Math", "Dr. Cakir");

            List<string> teachers1 = GetSubsetOfTeachers1(dictionary);
            List<string> teachers2 = GetSubsetOfTeachers2(dictionary);
            foreach (List<string> teachers in new[] { teachers1, teachers2 })
            {
                foreach (string teacher in teachers)
                    Console.WriteLine(teacher);
                Console.WriteLine();
            }

        }

        public static List<string> GetSubsetOfTeachers1(Dictionary<string, string> dictionary)
        {
            string mathTeacher = "";
            string scienceTeacher = "";
            string artTeacher = "";
            dictionary.TryGetValue("Math", out mathTeacher);
            dictionary.TryGetValue("Science", out scienceTeacher);
            dictionary.TryGetValue("Art", out artTeacher);
            List<string> teachers = new List<string>();
            foreach (string teacher in new [] { mathTeacher, scienceTeacher, artTeacher })
            {
                if (teacher != null)
                    teachers.Add(teacher);
            }
            return teachers;
        }

        public static List<string> GetSubsetOfTeachers2(Dictionary<string, string> dictionary)
        {
            List<string> teachers = new List<string>();
            List<String> allowedKeys = new List<string>();
            allowedKeys.Add("Math");
            allowedKeys.Add("Science");
            allowedKeys.Add("Art");
            foreach (KeyValuePair<string, string> pair in dictionary)
            {
                if (allowedKeys.Contains(pair.Key))
                    teachers.Add(pair.Value);
            }
            return teachers;
        }

    }
}

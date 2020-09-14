using System;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Neel", 5000, "Black");
            p.LastName = "Shah";
            Console.WriteLine(p.LastName);
            Console.WriteLine(p);
            Console.WriteLine(p.YearsAlive);
            p.YearsAlive = 17;
            Console.WriteLine(p);
        }
    }
}

using System;

namespace CSharpQuiz
{
    class Program
    {
        static void Main(string[] args)
        {

            Character character = new Character(("Neel", "Wizard"));
            Console.WriteLine(character + "\n");

            character.AddXP(500);
            Console.WriteLine(character);
            Console.WriteLine("Level: {0}\n", character.Level);

            character.AddXP(1300);
            Console.WriteLine(character);
            Console.WriteLine("Level: {0}\n", character.Level);

        }
    }
}

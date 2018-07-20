using System;

namespace DndCharacterGenerator
{
    class Program
    {
        private static string[] Classes = new string[] { "Bard", "Rogue", "Ranger", "Paladin", "Fighter"};
        private static int ClassIndex;

        static void Main(string[] args)
        {
            Console.WriteLine("Choose your class");
            Console.WriteLine();
            for (int i = 1; i < Classes.Length + 1; i++)
            {
                Console.WriteLine("Type " + i + " for " + Classes[i - 1]);
            }
            Console.WriteLine();
            var command = Console.ReadLine();
            ClassIndex = int.Parse(command) - 1;
            Console.WriteLine();
            Console.WriteLine("You have chosen: " + Classes[ClassIndex]);
            command = Console.ReadLine();
        }
    }
}

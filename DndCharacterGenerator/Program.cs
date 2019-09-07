using DndCharacterGenerator.Models;
using DndCharacterGenerator.Models.Builder;
using System;

namespace DndCharacterGenerator
{
    class Program
    {
        private static int ClassIndex;
        private static int RaceIndex;
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your class");
            Console.WriteLine();
            var character = new Character();
            for (int i = 1; i < Selector.Classes.Length + 1; i++)
            {
                Console.WriteLine("Type " + i + " for " + Selector.Classes[i - 1]);
            }
            var command = Console.ReadLine();
            ClassIndex = int.Parse(command) - 1;

            Console.WriteLine("Choose your race");
            for (int i = 1; i < Selector.Races.Length; i++)
            {
                Console.WriteLine("Type " + i + " for " + Selector.Races[i - 1]);
            }
            command = Console.ReadLine();
            RaceIndex = int.Parse(command) - 1;
            Console.WriteLine();
            Console.WriteLine("You have chosen: " + Selector.Classes[ClassIndex]);
            Console.WriteLine("You have chosen: " + Selector.Races[RaceIndex]);
            command = Console.ReadLine();
        }
    }
}

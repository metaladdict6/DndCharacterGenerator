using DndCharacterGenerator.Models.Classes;
using System;

namespace DndCharacterGenerator.Models.Builder
{
    public static class ClassBuilder
    {
        public static CharachterClass BuildClass()
        {
            Console.WriteLine("Choose your class");
            for (int i = 1; i < Selector.Classes.Length + 1; i++)
            {
                Console.WriteLine("Type " + i + " for " + Selector.Classes[i - 1]);
            }
            var command = Console.ReadLine();
            var classIndex = int.Parse(command) - 1;
            Console.WriteLine();
            return null;
        }
    }
}

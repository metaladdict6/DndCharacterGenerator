using DndCharacterGenerator.Models.Classes;
using System;

namespace DndCharacterGenerator.Models.Builder
{
    public static class ClassSelector
    {
        public static CharachterClass BuildClass()
        {
            Console.WriteLine("Choose your class");
            for (int i = 1; i < ClasessData.Classes.Length + 1; i++)
            {
                Console.WriteLine("Type " + i + " for " + ClasessData.Classes[i - 1]);
            }
            var command = Console.ReadLine();
            var classIndex = int.Parse(command) - 1;
            Console.WriteLine();
            return ClassBuilder.GetCharachterClass(ClasessData.Classes[classIndex]);
        }
    }
}

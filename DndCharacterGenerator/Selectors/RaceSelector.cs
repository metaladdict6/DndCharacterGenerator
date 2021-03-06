using DndCharacterGenerator.data;
using DndCharacterGenerator.Races;
using System;

namespace DndCharacterGenerator.Models.Builder
{
    public static class RaceSelector
    {
        public static Race SelectRace()
        {

            Console.WriteLine("Choose your race");
            for (int i = 1; i < RacesData.Races.Length; i++)
            {
                Console.WriteLine("Type " + i + " for " + RacesData.Races[i - 1]);
            }
            var command = Console.ReadLine();
            var raceIndex = int.Parse(command) - 1;
            Console.WriteLine();
            return RaceBuilder.GetRace(RacesData.Races[raceIndex]);
        }
    }
}

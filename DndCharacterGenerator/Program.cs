using DndCharacterGenerator.Models;
using DndCharacterGenerator.Models.Builder;
using System;

namespace DndCharacterGenerator
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            int classIndex = 0;
            int raceIndex = 0;
            
            var character = new Character();
            var charachterClass = ClassBuilder.BuildClass();
            var race = RaceSelector.SelectRace();
            Console.WriteLine();
            Console.WriteLine("You have chosen: " + Selector.Classes[classIndex]);
            Console.WriteLine("You have chosen: " + Selector.Races[raceIndex]);
            Console.WriteLine("Time to set your stats");
            var command = Console.ReadLine();
            StatRollerService.SetStates(race, character);
        }
    }
}

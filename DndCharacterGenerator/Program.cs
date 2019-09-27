using DndCharacterGenerator.Models;
using DndCharacterGenerator.Models.Builder;
using DndCharacterGenerator.Models.Classes;
using DndCharacterGenerator.Races;
using System;

namespace DndCharacterGenerator
{
  class Program
  {
    static void Main(string[] args)
    {
      int classIndex = 0;
      int raceIndex = 0;

      Character character = new Character();
      Race race = RaceSelector.SelectRace();
      CharachterClass charachterClass = ClassSelector.BuildClass();

      Console.WriteLine();
      Console.WriteLine("You have chosen: " + Selector.Classes[classIndex]);
      Console.WriteLine("You have chosen: " + Selector.Races[raceIndex]);
      Console.WriteLine("Time to set your stats");
      var command = Console.ReadLine();
      StatRollerService.SetStates(race, character);
    }
  }
}

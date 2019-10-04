using DndCharacterGenerator.Builder;
using DndCharacterGenerator.data;
using DndCharacterGenerator.Models;
using DndCharacterGenerator.Models.Builder;
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
      character.Race = RaceSelector.SelectRace();
      character.CharachterClass = ClassSelector.BuildClass();
      Console.WriteLine();
      Console.WriteLine("You have chosen: " + ClasessData.Classes[classIndex]);
      Console.WriteLine("You have chosen: " + RacesData.Races[raceIndex]);
      Console.WriteLine("Time to set your stats");
      var command = Console.ReadLine();
      StatRollerService.SetStates(character.Race, character);
      Console.WriteLine("Time to choose your background");
      Console.WriteLine("This will help you with extra set of skills to select");
      Console.WriteLine("Your background also informers your charachters traits. These charachter traits are suggestions, not absolute rules");
      Console.WriteLine("But your background is way more than only your skills. For more details, read the players manual. Starting at page 126");
      SkillListBuilder.SelectSkills(character);

      BuildTextFile.PrintCharachterToTextFile(character);
    }
  }
}

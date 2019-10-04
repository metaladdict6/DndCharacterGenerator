using DndCharacterGenerator.Models.Classes;
using DndCharacterGenerator.Races;
using System.Collections.Generic;
using static DndCharacterGenerator.Models.Builder.CharachterModifiersData;

namespace DndCharacterGenerator.Models
{
  public class Character
  {
    public string Name { get; set; }

    public Dictionary<Stats, int> CharachterStats { get; set; }

    public Race Race { get; set; }

    public CharachterClass CharachterClass { get; set; }

    public Character()
    {
      CharachterStats = new Dictionary<Stats, int>();
    }

    public Character(Race race, CharachterClass charachterClass) : this()
    {
      Race = race;
      CharachterClass = charachterClass;
    }


  }
}

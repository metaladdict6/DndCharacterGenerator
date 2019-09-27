using DndCharacterGenerator.Races;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacterGenerator.Models.Builder
{
  public class RaceBuilder
  {
    private static Dictionary<String, Race> Races
    {
      get
      {
        return new Dictionary<string, Race>
                {
                    { Selector.Dwarf, new Race(Selector.Dwarf, 0, 0, 0, 0, 2, 0, false, 25) },
                    { Selector.Elf, new Race(Selector.Elf, 0, 0, 0, 2, 0, 0, false, 30) },
                    { Selector.Halfling, new Race(Selector.Halfling, 0, 0, 0, 2, 0, 0, false, 25) },
                    { Selector.Human, new Race(Selector.Human, 1, 1, 1, 1, 1, 1, false, 30) },
                    { Selector.Dragonborn, new Race(Selector.Dragonborn, 2, 0, 0, 0, 0, 1, false, 30) },
                    { Selector.Gnome, new Race(Selector.Gnome, 0,2, 0, 0, 0, 0, false, 25) },
                    { Selector.HalfElf, new Race(Selector.HalfElf, 0, 0, 0, 0, 0, 2, false, 30) },
                    { Selector.HalfOrc, new Race(Selector.HalfOrc, 2, 0, 0, 0, 1, 0, false, 30) },
                    { Selector.Tiefling, new Race(Selector.Tiefling, 0, 1, 0, 0, 0, 2, false, 30) }
                };
      }
    }

    public static Race GetRace(string raceName)
    {
      return Races[raceName];
    }
  }
}

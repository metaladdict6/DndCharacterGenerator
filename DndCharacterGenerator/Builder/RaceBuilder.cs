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
                    { ClasessData.Dwarf, new Race(ClasessData.Dwarf, 0, 0, 0, 0, 2, 0, false, 25) },
                    { ClasessData.Elf, new Race(ClasessData.Elf, 0, 0, 0, 2, 0, 0, false, 30) },
                    { ClasessData.Halfling, new Race(ClasessData.Halfling, 0, 0, 0, 2, 0, 0, false, 25) },
                    { ClasessData.Human, new Race(ClasessData.Human, 1, 1, 1, 1, 1, 1, false, 30) },
                    { ClasessData.Dragonborn, new Race(ClasessData.Dragonborn, 2, 0, 0, 0, 0, 1, false, 30) },
                    { ClasessData.Gnome, new Race(ClasessData.Gnome, 0,2, 0, 0, 0, 0, false, 25) },
                    { ClasessData.HalfElf, new Race(ClasessData.HalfElf, 0, 0, 0, 0, 0, 2, false, 30) },
                    { ClasessData.HalfOrc, new Race(ClasessData.HalfOrc, 2, 0, 0, 0, 1, 0, false, 30) },
                    { ClasessData.Tiefling, new Race(ClasessData.Tiefling, 0, 1, 0, 0, 0, 2, false, 30) }
                };
      }
    }

    public static Race GetRace(string raceName)
    {
      return Races[raceName];
    }
  }
}

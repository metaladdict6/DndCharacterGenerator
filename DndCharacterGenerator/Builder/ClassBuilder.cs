using DndCharacterGenerator.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using static DndCharacterGenerator.Models.Builder.CharachterModifiersData;

namespace DndCharacterGenerator.Models.Builder
{
  public class ClassBuilder
  {
    private static Dictionary<string, CharachterClass> Classes
    {
      get
      {
        return new Dictionary<string, CharachterClass>
        {
          { ClasessData.Barbarian, new CharachterClass(ClasessData.Barbarian, 12, Stats.Strength, 1, new Stats[] {Stats.Strength, Stats.Constitution }) },
          { ClasessData.Bard, new CharachterClass(ClasessData.Bard, 8, Stats.Charisma, 1, new Stats[] {Stats.Dexerity, Stats.Charisma }) },
          { ClasessData.Cleric, new CharachterClass(ClasessData.Cleric, 8, Stats.Wisdom, 1, new Stats[] {Stats.Wisdom, Stats.Charisma }) },
          { ClasessData.Druid, new CharachterClass(ClasessData.Druid, 8, Stats.Wisdom, 1) },
          { ClasessData.Fighter, new CharachterClass(ClasessData.Fighter, 10, Stats.Strength, 1) },
          { ClasessData.Monk, new CharachterClass(ClasessData.Monk, 8, Stats.Dexerity, 1) },
          { ClasessData.Paladin, new CharachterClass(ClasessData.Paladin, 10, Stats.Strength, 1) },
          { ClasessData.Ranger, new CharachterClass(ClasessData.Ranger, 10, Stats.Dexerity, 1) },
          { ClasessData.Rogue, new CharachterClass(ClasessData.Rogue, 8, Stats.Dexerity, 1) },
          { ClasessData.Sorcerer, new CharachterClass(ClasessData.Sorcerer, 6, Stats.Charisma, 1) },
          { ClasessData.Warlock, new CharachterClass(ClasessData.Warlock, 8, Stats.Charisma, 1) },
          { ClasessData.Wizard, new CharachterClass(ClasessData.Wizard, 6, Stats.Intelligence, 1) }
        };
      }
    }

    public static CharachterClass GetCharachterClass(string charachterClass)
    {
      return Classes[charachterClass];
    }
  }
}

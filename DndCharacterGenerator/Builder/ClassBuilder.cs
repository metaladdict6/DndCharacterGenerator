using DndCharacterGenerator.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using static DndCharacterGenerator.Models.Builder.CharachterModifiers;

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
          { Selector.Barbarian, new CharachterClass(Selector.Barbarian, 12, Stats.Strength, 1, new Stats[] {Stats.Strength, Stats.Constitution }) },
          { Selector.Bard, new CharachterClass(Selector.Bard, 8, Stats.Charisma, 1, new Stats[] {Stats.Dexerity, Stats.Charisma }) },
          { Selector.Cleric, new CharachterClass(Selector.Cleric, 8, Stats.Wisdom, 1, new Stats[] {Stats.Wisdom, Stats.Charisma }) },
          { Selector.Druid, new CharachterClass(Selector.Druid, 8, Stats.Wisdom, 1) },
          { Selector.Fighter, new CharachterClass(Selector.Fighter, 10, Stats.Strength, 1) },
          { Selector.Monk, new CharachterClass(Selector.Monk, 8, Stats.Dexerity, 1) },
          { Selector.Paladin, new CharachterClass(Selector.Paladin, 10, Stats.Strength, 1) },
          { Selector.Ranger, new CharachterClass(Selector.Ranger, 10, Stats.Dexerity, 1) },
          { Selector.Rogue, new CharachterClass(Selector.Rogue, 8, Stats.Dexerity, 1) },
          { Selector.Sorcerer, new CharachterClass(Selector.Sorcerer, 6, Stats.Charisma, 1) },
          { Selector.Warlock, new CharachterClass(Selector.Warlock, 8, Stats.Charisma, 1) },
          { Selector.Wizard, new CharachterClass(Selector.Wizard, 6, Stats.Intelligence, 1) }
        };
      }
    }

    public static CharachterClass GetCharachterClass(string charachterClass)
    {
      return Classes[charachterClass];
    }
  }
}

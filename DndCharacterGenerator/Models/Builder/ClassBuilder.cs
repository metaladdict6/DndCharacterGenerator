using DndCharacterGenerator.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;

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
          { Selector.Barbarian, new CharachterClass(Selector.Barbarian) },
          { Selector.Bard, new CharachterClass(Selector.Bard) },
          { Selector.Cleric, new CharachterClass(Selector.Cleric) },
          { Selector.Druid, new CharachterClass(Selector.Druid) },
          { Selector.Fighter, new CharachterClass(Selector.Fighter) },
          { Selector.Monk, new CharachterClass(Selector.Monk) },
          { Selector.Paladin, new CharachterClass(Selector.Paladin) },
          { Selector.Ranger, new CharachterClass(Selector.Ranger) },
          { Selector.Rogue, new CharachterClass(Selector.Rogue) },
          { Selector.Sorcerer, new CharachterClass(Selector.Sorcerer) },
          { Selector.Warlock, new CharachterClass(Selector.Warlock) },
          { Selector.Wizard, new CharachterClass(Selector.Wizard) }
        };
      }
    }

    public static CharachterClass GetCharachterClass(string charachterClass)
    {
      return Classes[charachterClass];
    }
  }
}

using DndCharacterGenerator.Models.Interfaces;
using System.Collections.Generic;
using static DndCharacterGenerator.Models.Builder.CharachterModifiers;
using static DndCharacterGenerator.Models.Selectors.SkillSelector;

namespace DndCharacterGenerator.Models.Classes
{
  public class CharachterClass
  {
    public string Name { get; set; }

    public int Level { get; set; }
    public int ProfiencyBonus
    {
      get
      {
        switch (Level)
        {
          case 1:
          case 2:
          case 3:
          case 4:
            return 2;
          case 5:
          case 6:
          case 7:
          case 8:
            return 3;
          case 9:
          case 10:
          case 11:
          case 12:
            return 4;
          case 13:
          case 14:
          case 15:
          case 16:
            return 5;
          case 17:
          case 18:
          case 19:
          case 20:
            return 6;
             
        }
        return 0;
      }
    }
    public Stats PrimaryStat { get; set; }

    public int HitDie { get; set; }

    public Stats[] SavingThrowProfiencies { get; set; }
    public List<IAbility> Abilities { get; set; }

    public int SkillSelectAmount { get; set; }

    public Skills[] PickAbleSkills { get; set; }
    public CharachterClass(string name)
    {
      Name = name;
      Abilities = new List<IAbility>();
      SkillSelectAmount = 2;
    }

    public CharachterClass(string name, int hitDie) : this(name)
    {
      HitDie = hitDie;
    }

    public CharachterClass(string name, int hitDie, Stats primaryStat): this(name, hitDie)
    {
      PrimaryStat = primaryStat;
    }


    public CharachterClass(string name, int hitDie, int level): this(name, hitDie)
    {
      Level = level;
    }


    public CharachterClass(string name, int hitDie, Stats primaryStat, int level)
      : this(name, hitDie, primaryStat)
    {
      Level = level;
    }

    public CharachterClass(string name, int hitDie, Stats primaryStat, int level, Stats[] savingThrowProfiencies)
      : this(name, hitDie, primaryStat, level)
    {
      SavingThrowProfiencies = savingThrowProfiencies;
    }

    public CharachterClass(string name, int hitDie, Stats primaryStat, int level, Stats[] savingThrowProfiencies, Skills[] pickAbleSkills)
      : this(name, hitDie, primaryStat, level, savingThrowProfiencies)
    {
      PickAbleSkills = pickAbleSkills;
    }

  }
}

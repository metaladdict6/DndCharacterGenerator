using DndCharacterGenerator.Models.Interfaces;
using System.Collections.Generic;

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
    public string PrimaryAbilityModifier { get; set; }

    public int HitDie { get; set; }

    public string[] SavingThrowProfiencies { get; set; }
    public List<IAbility> Abilities { get; set; }
    public CharachterClass(string name)
    {
      Name = name;
    }
  }
}

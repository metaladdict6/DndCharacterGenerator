using DndCharacterGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static DndCharacterGenerator.Models.Builder.CharachterModifiers;

namespace DndCharacterGenerator.Builder
{
  public class BuildTextFile
  {
    public static void PrintCharachterToTextFile(Character charachter)
    {
      List<string> lines = new List<string>();
      lines.Add("Name: " + charachter.Name);
      lines.Add("Race: " + charachter.Race.Name);
      lines.Add("Hit die: " + charachter.CharachterClass.HitDie);
      lines.Add("Primary stat" + charachter.CharachterClass.PrimaryStat);
      lines.Add("Profiency bonus: " + charachter.CharachterClass.ProfiencyBonus);
      lines.Add(Stats.Strength.ToString() + ": " + charachter.CharachterStats[Stats.Strength]);
      lines.Add(Stats.Intelligence.ToString() + ": " + charachter.CharachterStats[Stats.Intelligence]);
      lines.Add(Stats.Wisdom.ToString() + ": " + charachter.CharachterStats[Stats.Wisdom]);
      lines.Add(Stats.Dexerity.ToString() + ": " + charachter.CharachterStats[Stats.Dexerity]);
      lines.Add(Stats.Constitution.ToString() + ": " + charachter.CharachterStats[Stats.Constitution]);
      lines.Add(Stats.Charisma.ToString() + ": " + charachter.CharachterStats[Stats.Charisma]);
      lines.Add("Saving throw profiencie: ");
      foreach(var ability in charachter.Race.Abilities)
      {
        lines.Add("Race ability: " + ability.Name);
        lines.Add("Race ability description: " + ability.Description);
      }
      foreach(var ability in charachter.CharachterClass.Abilities)
      {
        lines.Add("Class ability: " + ability.Name);
        lines.Add("Class ability description: " + ability.Description);
      }
      System.IO.File.WriteAllLines(@"D:\projects\Dnd character generator\Charachter.txt",lines.ToArray());
    }
  }
}

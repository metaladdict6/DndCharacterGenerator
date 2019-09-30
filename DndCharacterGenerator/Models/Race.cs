using DndCharacterGenerator.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacterGenerator.Races
{
  public class Race
  {
    public List<IAbility> Abilities { get; set; }
    public string Name { get; set; }

    public int StrenghtIncrease { get; set; }

    public int IntelligenceIncrease { get; set; }

    public int WisdomIncrease { get; set; }

    public int DexerityIncrease { get; set; }

    public int ConstitutionIncrease { get; set; }

    public int CharismaIncrease { get; set; }

    public bool IsSubRace { get; set; }

    public int Speed { get; set; }
    public Race(string name)
    {
      Name = name;
      Abilities = new List<IAbility>();
    }

    public Race(string name,
                int strengthIncrease,
                int intelligenceIncrease,
                int wisdomIncrease,
                int dexerityIncrease,
                int constitutionIncrease,
                int charismaIncrease): this(name)
    {
      StrenghtIncrease = strengthIncrease;
      IntelligenceIncrease = intelligenceIncrease;
      WisdomIncrease = wisdomIncrease;
      DexerityIncrease = dexerityIncrease;
      ConstitutionIncrease = constitutionIncrease;
      CharismaIncrease = charismaIncrease;
    }

    public Race(string name,
             int strengthIncrease,
             int intelligenceIncrease,
             int wisdomIncrease,
             int dexerityIncrease,
             int constitutionIncrease,
             int charismaIncrease,
             List<IAbility> abilities):
      this(name, strengthIncrease, intelligenceIncrease, wisdomIncrease, dexerityIncrease, constitutionIncrease, charismaIncrease)
    {      
      Abilities = abilities;
    }

    public Race(string name,
          int strengthIncrease,
          int intelligenceIncrease,
          int wisdomIncrease,
          int dexerityIncrease,
          int constitutionIncrease,
          int charismaIncrease,
          bool isSubRace):
      this(name, strengthIncrease, intelligenceIncrease, wisdomIncrease, dexerityIncrease, constitutionIncrease, charismaIncrease)
    {
      IsSubRace = isSubRace;
    }

    public Race(string name,
         int strengthIncrease,
         int intelligenceIncrease,
         int wisdomIncrease,
         int dexerityIncrease,
         int constitutionIncrease,
         int charismaIncrease,
         bool isSubRace,
         int speed):
      this(name, strengthIncrease, intelligenceIncrease, wisdomIncrease, dexerityIncrease, constitutionIncrease, charismaIncrease, isSubRace)
    {
      Speed = speed;
    }

    public Race(string name,
           int strengthIncrease,
           int intelligenceIncrease,
           int wisdomIncrease,
           int dexerityIncrease,
           int constitutionIncrease,
           int charismaIncrease,
           bool isSubRace,
           int speed,
           List<IAbility> abilities):
      this(name, strengthIncrease, intelligenceIncrease, wisdomIncrease, dexerityIncrease, constitutionIncrease, charismaIncrease, isSubRace, speed)
    {
         Abilities = abilities;
    }
  }
}

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

        public Race(string name)
        {
            Name = name;
            StrenghtIncrease = 0;
            IntelligenceIncrease = 0;
            WisdomIncrease = 0;
            DexerityIncrease = 0;
            ConstitutionIncrease = 0;
            CharismaIncrease = 0;
        }

        public Race(string name,
                    int strengthIncrease, 
                    int intelligenceIncrease, 
                    int wisdomIncrease, 
                    int dexerityIncrease, 
                    int constitutionIncrease, 
                    int charismaIncrease)
        {
            Name = name;
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
                 List<IAbility> abilities)
        {
            Name = name;
            StrenghtIncrease = strengthIncrease;
            IntelligenceIncrease = intelligenceIncrease;
            WisdomIncrease = wisdomIncrease;
            DexerityIncrease = dexerityIncrease;
            ConstitutionIncrease = constitutionIncrease;
            CharismaIncrease = charismaIncrease;
            Abilities = abilities;
        }

        public Race(string name,
           int strengthIncrease,
           int intelligenceIncrease,
           int wisdomIncrease,
           int dexerityIncrease,
           int constitutionIncrease,
           int charismaIncrease,
           List<IAbility> abilities,
           bool isSubRace)
        {
            Name = name;
            StrenghtIncrease = strengthIncrease;
            IntelligenceIncrease = intelligenceIncrease;
            WisdomIncrease = wisdomIncrease;
            DexerityIncrease = dexerityIncrease;
            ConstitutionIncrease = constitutionIncrease;
            CharismaIncrease = charismaIncrease;
            Abilities = abilities;
            IsSubRace = isSubRace;
        }
    }
}

using DndCharacterGenerator.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static DndCharacterGenerator.Models.Builder.CharachterModifiersData;

namespace DndCharacterGenerator.Models.Selectors
{
  public class SkillSelector
  {
    public enum ProfiecieLevel { Not = 0, Profiecient = 1, Expertise = 2}

    public enum Skills
    {
      Acrobatics,
      AnimalHandling,
      Arcana,
      Athletics,
      Deception,
      History,
      Insight,
      Intimidation,
      Investigation,
      Medicine,
      Nature,
      Perception,
      Performance,
      Persuasion,
      Relgion,
      SleightOfHaned,
      Stealth,
      Survival
    }
  }
}

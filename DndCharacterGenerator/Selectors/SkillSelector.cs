using DndCharacterGenerator.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static DndCharacterGenerator.Models.Builder.CharachterModifiers;

namespace DndCharacterGenerator.Models.Selectors
{
  public class SkillSelector
  {
    public enum ProfiecieLevel { Not, Profiecient, Expertise}

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

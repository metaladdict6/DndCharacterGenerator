using DndCharacterGenerator.Models.Builder;
using DndCharacterGenerator.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static DndCharacterGenerator.Models.Builder.CharachterModifiersData;
using static DndCharacterGenerator.Models.Selectors.SkillSelector;

namespace DndCharacterGenerator.Models.Models
{
  public class Skill : ISkill
  {
    public Skill(string name, Stats stat)
    {
      Name = name;
      Stat = stat;
    }

    public string Name { get; set; }

    public Stats Stat { get; set; }

    public ProfiecieLevel ProfiencieLevel { get; set; }
  }
}

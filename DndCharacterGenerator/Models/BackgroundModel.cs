using System;
using System.Collections.Generic;
using System.Text;
using static DndCharacterGenerator.Models.Selectors.SkillSelector;

namespace DndCharacterGenerator.Models
{
  public class BackgroundModel
  {

    public BackgroundModel()
    {

    }

    public BackgroundModel(string name, string description, string feature, string[] traits, string[] ideals, string[] bonds, string[] flaws, Skills[] skills)
    {
      Name = name;
      Description = description;
      Feature = feature;
      Traits = traits;
      Ideals = ideals;
      Bonds = bonds;
      Flaws = flaws;
      Skills = skills;
    }
    public string Name { get; set; }

    public string Description { get; set; }

    public string Feature { get; set; }
    public string[] Traits { get; }
    public Skills[] SelectAbleSkils { get; set; }

    public string[] PersonalityTraits { get; set; }

    public string[] Ideals { get; set; }

    public string[] Bonds { get; set; }

    public string[] Flaws { get; set; }
    public Skills[] Skills { get; }
  }
}

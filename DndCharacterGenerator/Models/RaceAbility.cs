using DndCharacterGenerator.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacterGenerator.Models.Models
{
  class RaceAbility : IAbility
  {
    public string Name { get; set; }
    public string Description { get; set; }
  }
}

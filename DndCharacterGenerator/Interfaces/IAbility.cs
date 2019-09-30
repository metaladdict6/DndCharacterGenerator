using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacterGenerator.Models.Interfaces
{
    public interface IAbility
    {
        string Name { get; set; }

        string Description { get; set; }
    }
}

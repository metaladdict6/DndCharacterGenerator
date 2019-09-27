using DndCharacterGenerator.Models.Interfaces;
using System.Collections.Generic;

namespace DndCharacterGenerator.Models.Classes
{
    public class CharachterClass
    {
        public string Name { get; set; }

        public List<IAbility> Abilities { get; set; }
        public CharachterClass(string name)
        {
            Name = name;
        }
    }
}

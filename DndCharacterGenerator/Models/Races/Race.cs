using DndCharacterGenerator.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacterGenerator.Races
{
    public class Race
    {
        public string Name { get; }

        public Race(string name)
        {
            Name = name;
        }
    }
}

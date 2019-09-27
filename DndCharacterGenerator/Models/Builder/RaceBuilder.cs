using DndCharacterGenerator.Races;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacterGenerator.Models.Builder
{
    public class RaceBuilder
    {
        public Dictionary<String, Race> Races
        {
            get
            {
                return new Dictionary<string, Race>
                {
                    { Selector.Dwarf, new Race(Selector.Dwarf) },
                    { Selector.Elf, new Race(Selector.Elf) },
                    { Selector.Halfling, new Race(Selector.Halfling) },
                    { Selector.Human, new Race(Selector.Human) },
                    { Selector.Dragonborn, new Race(Selector.Dragonborn) },
                    { Selector.Gnome, new Race(Selector.Gnome) },
                    { Selector.HalfElf, new Race(Selector.HalfElf) },
                    { Selector.HalfOrc, new Race(Selector.HalfOrc) },
                    { Selector.Tiefling, new Race(Selector.Tiefling) }
                };
            }
        }
    }
}

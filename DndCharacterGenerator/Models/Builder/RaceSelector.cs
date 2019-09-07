using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacterGenerator.Models.Builder
{
    public static class Selector
    {
        public static string[] Classes = new string[] {
            "Barbarian",
            "Bard",
            "Cleric",
            "Druid",
            "Fighter",
            "Monk",
            "Paladin",
            "Ranger",
            "Rogue",
            "Sorcerer",
            "Warlock",
            "Wizard"
         };

        public static string[] Races = new string[] {
            "Dwarf",
            "Elf",
            "Halfling",
            "Human",
            "Dragonborn",
            "Gnome",
            "Half-Elf",
            "Half-Orc",
            "Tiefling"
        };

    }
}

using DndCharacterGenerator.Models.Classes;
using DndCharacterGenerator.Races;
using System.Collections.Generic;
using static DndCharacterGenerator.Models.Builder.CharachterModifiers;

namespace DndCharacterGenerator.Models
{
    public class Character
    {

        public Dictionary<Stats, int> CharachterStats { get; set; }
       
        public Race Race { get; set; }

        public CharachterClass CharachterClass { get; set; }

        public Character(){}

        public Character(Race race, CharachterClass charachterClass)
        {
            Race = race;
            CharachterClass = charachterClass;
        }

       
    }
}

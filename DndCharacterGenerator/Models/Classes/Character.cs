using DndCharacterGenerator.Models.Classes;
using DndCharacterGenerator.Races;

namespace DndCharacterGenerator.Models
{
    public class Character
    {
        public int Strenght { get; set; }

        public int Intelligence { get; set; }

        public int Wisdom { get; set; }

        public int Dexerity { get; set; }

        public int Constitution { get; set; }

        public int Charisma { get; set; }

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

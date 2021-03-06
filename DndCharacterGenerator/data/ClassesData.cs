using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacterGenerator.Models.Builder
{
    // TODO replace all the strings with enums.
    public static class ClasessData
    {

        #region Clas Names
        public readonly static string Barbarian = "Barbarian";

        public readonly static string Bard = "Bard";

        public readonly static string Cleric = "Cleric";

        public readonly static string Druid = "Druid";

        public readonly static string Fighter = "Fighter";

        public readonly static string Monk = "Monk";

        public readonly static string Paladin = "Paladin";

        public readonly static string Ranger = "Ranger";

        public readonly static string Rogue = "Rogue";

        public readonly static string Sorcerer = "Sorcerer";

        public readonly static string Warlock = "Warlock";

        public readonly static string Wizard = "Wizard";

        #endregion

        public static string[] Classes = new string[] {
            Barbarian,
            Bard,
            Cleric,
            Druid,
            Fighter,
            Monk,
            Paladin,
            Ranger,
            Rogue,
            Sorcerer,
            Warlock,
            Wizard
         };

      

    }
}

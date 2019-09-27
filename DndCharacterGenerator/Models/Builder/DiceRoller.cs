using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacterGenerator.Models.Builder
{
    public static class DiceRoller
    {
        public static Random random = new Random();

        private static int Roll(int maxValue)
        {
            return random.Next(1, maxValue);
        }
        public static int RollD4
        {
            get { return Roll(4); }
        }

        public static int RollD6
        {
             get { return Roll(6); }
        }
       

        public static int RollD8
        {
            get { return Roll(8); }
        }

        public static int RollD10
        {
            get { return Roll(10); }
        }

        public static int RollD12
        {
            get { return Roll(12); }
        }

        public static int RollD20
        {
            get { return Roll(20); }
        }
    }
}

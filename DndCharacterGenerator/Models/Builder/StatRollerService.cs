using DndCharacterGenerator.Races;
using System;
using System.Collections.Generic;
using System.Text;
using static DndCharacterGenerator.Models.Builder.CharachterModifiers;

namespace DndCharacterGenerator.Models.Builder
{
    public static class StatRollerService
    {
        public static void SetStates(Race race, Character charachter)
        {
            List<int> stats = new List<int>
            {
                CreateState,
                CreateState,
                CreateState,
                CreateState,
                CreateState,
                CreateState
            };
            RemainingStats(stats);
            Dictionary<Stats, int> setter = new Dictionary<Stats, int>
            {
                { Stats.Strength, race.StrenghtIncrease },
                { Stats.Intelligence, race.IntelligenceIncrease },
                { Stats.Wisdom, race.WisdomIncrease },
                { Stats.Dexerity, race.DexerityIncrease },
                { Stats.Constitution, race.ConstitutionIncrease },
                { Stats.Charisma, race.CharismaIncrease }
            };

            Console.WriteLine("As a reminder. Your race has the following modifiers");
            Console.WriteLine("Strenght: " + race.StrenghtIncrease);
            Console.WriteLine("Intelligence: " + race.IntelligenceIncrease);
            Console.WriteLine("Wisdom: " + race.WisdomIncrease);
            Console.WriteLine("Dexerity: " + race.DexerityIncrease);
            Console.WriteLine("Constitution: " + race.ConstitutionIncrease);
            Console.WriteLine("Charisma: " + race.ConstitutionIncrease);

            SetState(Stats.Strength, setter, stats);
            SetState(Stats.Intelligence, setter, stats);
            SetState(Stats.Wisdom, setter, stats);
            SetState(Stats.Dexerity, setter, stats);
            SetState(Stats.Constitution, setter, stats);
            SetState(Stats.Charisma, setter, stats);
        }

        private static void SetState(Stats stat, Dictionary<Stats, int> setter, List<int> stats)
        {
            Console.WriteLine("Assign your " + stat);
            RemainingStats(stats);
            var command = Console.ReadLine();
            int selectedStat = int.Parse(command);
            stats.Remove(selectedStat);
            if(selectedStat + setter[stat] > 20)
            {
                setter[stat] = 20;
            }
            else
            {
                setter[stat] = setter[stat] + selectedStat;
            }
        }

        private static void RemainingStats(List<int> stats)
        {
            foreach (int stat in stats)
            {
                Console.WriteLine(stat);
            }
        }
        private static int CreateState
        {
            get
            {
                List<int> rolls = new List<int>
                {
                    DiceRoller.RollD6,
                    DiceRoller.RollD6,
                    DiceRoller.RollD6,
                    DiceRoller.RollD6
                };
                
                rolls.Reverse();
                int result = 0;
                int lowest = 7;
                foreach (int rol in rolls)
                {
                    if(rol < lowest)
                    {
                        lowest = rol;
                    }
                }
                rolls.Remove(lowest);
                foreach(int rol in rolls)
                {
                    result += rol;
                }
                return result;
            }
        }
    }
}

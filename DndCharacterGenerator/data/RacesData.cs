using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacterGenerator.data
{
  public class RacesData
  {
    #region Race Names

    public readonly static string Dwarf = "Dwarf";

    public readonly static string Elf = "Elf";

    public readonly static string Halfling = "Halfling";

    public readonly static string Human = "Human";

    public readonly static string Dragonborn = "Dragonborn";

    public readonly static string Gnome = "Gnome";

    public readonly static string HalfElf = "Half-Elf";

    public readonly static string HalfOrc = "Half-Orc";

    public readonly static string Tiefling = "Tiefling";

    #endregion

    public static string[] Races = new string[] {
            Dwarf,
            Elf,
            Halfling,
            Human,
            Dragonborn,
            Gnome,
            HalfElf,
            HalfOrc,
            Tiefling
        };
  }
}

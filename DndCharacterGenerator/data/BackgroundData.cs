using DndCharacterGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static DndCharacterGenerator.Models.Selectors.SkillSelector;

namespace DndCharacterGenerator.data
{
  public class BackgroundData
  {

    public enum Backgrounds { Acolyte, Charlatan, Criminal, Entertainer, FolkHero, GuildArtian, Hermit, Noble, Outlander, Sage, Sailor, Soldier, Urchin }

    public static Dictionary<Backgrounds, BackgroundModel> Data
    {
      get
      {
        return new Dictionary<Backgrounds, BackgroundModel>
        {
          {Backgrounds.Acolyte, new BackgroundModel(
          "Acolyte",
          "You have spent your life in the service o f a temple to a specific god or pantheon o f gods. You act as an intermediary between the realm o f the holy and the mortal world, " +
          "performing sacred rites and offering sacrifices in order to conduct worshipers into the presence o f the divine. You are not necessarily a cleric performing sacred rites is not the " +
          "same thing as channeling divine power. Choose a god, a pantheon o f gods, or some other quasi-divine being from among those listed in appendix B or those specified by your DM, " +
          "and work with your DM to detail the nature o f your religious service. Were you a lesser functionary in a temple, raised from childhood to assist the priests in the sacred rites? " +
          "Or were you a high priest who suddenly experienced a call to serve your god in a different way? Perhaps you were the leader o f a small cult outside of any established temple structure, " +
          "or even an occult group that served a fiendish master that you now deny.",

          "As an acolyte, you command the respect of those who share your faith, and you can perform the religious ceremonies of your deity. " +
          "You and your adventuring companions can expect to receive free healing and care at a temple, shrine, or other established presence of your " +
          "faith, though you must provide any material components needed for spells. Those w ho share your religion will support you (but only you) at a modest lifestyle. " +
          "You might also have ties to a specific temple dedicated to your chosen deity or pantheon, and you have a residence there. " +
          "This could be the temple where you used to serve, if you remain on good terms with it, or a temple where you have found a new home. " +
          "While near your temple, you can call upon the priests for assistance, provided the assistance you ask for is not hazardous and you remain in good standing with your temple.",

          new string[] {
            "I idolize a particular hero of my faith, and constantly refer to that person’s deeds and example.",
            "I can find common ground between the fiercest enemies, emphathizing with them and always working towards peace",
            "I see omens in every event and action. The gods try to speak to us, we just need to listen",
            "Nothing can shake my optimistic attitude.",
            "I quote (or misquote) sacred texts and proverbs in almost every situation.",
            "I am tolerant (or intolerant) of other faiths and respect (or condemn) the worship of other gods.",
            "I've enjoyed fine food, drink, and high society among my temple’s elite. Rough living grates on me.",
            "I’ve spent so long in the temple that I have little practical experience dealing with people in the outside world."},
          new string[] {
            "[Tradition] The ancient traditions o f worship and sacrifice must be preserved and upheld. (Lawful)",
            "[Charity] I always try to help those in need, no matter what the personal cost. (Good)",
            "[Change] We must help bring about the changes the gods are constantly working in the world. (Chaotic)",
            "[Power] I hope to one day rise to the top of my faith’s religious hierarchy. (Lawful)",
            "[Faith] I trust that my deity will guide my actions, I have faith that if I work hard, things will go well. (Lawful)",
            "[Aspiration] I seek to prove myself worthy of my god’s favor by matching my actions against his or her teachings. (Any)"
          },
          new string[] {
            "I would die to recover an ancient relic of my faith that was lost long ago.",
            "will someday get revenge on the corrupt temple hierarchy who branded me a heretic.",
            "I owe my life to the priest who took me in when my parents died.",
            "Everything I do is for the common people.",
            "I will do anything to protect the temple where I served.",
            "I seek to preserve a sacred text that my enemies consider heretical and seek to destroy."},
          new string[] {
            "I judge others harshly, and myself even more severely.",
            "I put too much trust in those who wield power within my temple’s hierarchy.",
            "My piety sometimes leads me to blindly trust those that profess faith in my god.",
            "I am inflexible in my thinking.",
            "I am suspicious of strangers and expect the worst of them.",
            "Once I pick a goal, I become obsessed with it to the detriment of everything else in my life."},
          new Skills[] {
            Skills.Insight,
            Skills.Relgion}) },
          {Backgrounds.Charlatan, new BackgroundModel(
            "",
            "",
            "",
          new string[] { },
          new string[] { },
          new string[] { },
          new string[] { },
          new Skills[] { } ) },
          {Backgrounds.Criminal, new BackgroundModel(
            "",
            "",
            "",
          new string[] { },
          new string[] { },
          new string[] { },
          new string[] { },
          new Skills[] { } ) },
          {Backgrounds.Entertainer, new BackgroundModel(
            "",
            "",
            "",
          new string[] { },
          new string[] { },
          new string[] { },
          new string[] { },
          new Skills[] { } ) },
          {Backgrounds.FolkHero, new BackgroundModel(
            "",
            "",
            "",
          new string[] { },
          new string[] { },
          new string[] { },
          new string[] { },
          new Skills[] { } ) },
          {Backgrounds.GuildArtian, new BackgroundModel(
            "",
            "",
            "",
          new string[] { },
          new string[] { },
          new string[] { },
          new string[] { },
          new Skills[] { } ) },
          {Backgrounds.Hermit,new BackgroundModel(
            "",
            "",
            "",
          new string[] { },
          new string[] { },
          new string[] { },
          new string[] { },
          new Skills[] { } ) },
          {Backgrounds.Noble, new BackgroundModel(
            "",
            "",
            "",
          new string[] { },
          new string[] { },
          new string[] { },
          new string[] { },
          new Skills[] { } ) },
          {Backgrounds.Outlander, new BackgroundModel(
            "",
            "",
            "",
          new string[] { },
          new string[] { },
          new string[] { },
          new string[] { },
          new Skills[] { } ) },
          {Backgrounds.Sage, new BackgroundModel(
            "",
            "",
            "",
          new string[] { },
          new string[] { },
          new string[] { },
          new string[] { },
          new Skills[] { } ) },
          {Backgrounds.Sailor, new BackgroundModel(
            "",
            "",
            "",
          new string[] { },
          new string[] { },
          new string[] { },
          new string[] { },
          new Skills[] { } ) },
          {Backgrounds.Soldier, new BackgroundModel(
            "",
            "",
            "",
          new string[] { },
          new string[] { },
          new string[] { },
          new string[] { },
          new Skills[] { } ) },
          {Backgrounds.Urchin, new BackgroundModel(
            "",
            "",
            "",
          new string[] { },
          new string[] { },
          new string[] { },
          new string[] { },
          new Skills[] { } ) },
        };
      }
    }
  }
}

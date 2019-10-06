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
             "Charlatan",

            "You have always had a way with people. You know what makes them tick, you can tease out their hearts' desires after a few minutes of conversation, " +
            "and with a few leading questions you can read them like they were children's books. It’s a useful talent, and one that you’re perfectly willing to use for your advantage. " +
            "You know what people want and you deliver, or rather, you promise to deliver. Common sense should steer people away from things that sound too good to be true, but common sense " +
            "seems to be in short supply when you’re around. The bottle of pink-colored liquid will surely cure that unseemly rash, this ointment—nothing more than a bit of fat with a " +
            "sprinkle of silver dust—can restore youth and vigor, and there’s a bridge in the city that just happens to be for sale. These marvels sound implausible, but you make them sound " +
            "like the real deal.",

            "You have created a second identity that includes documentation, established acquaintances, and disguises that allow you to assume that persona. " +
            "Additionally, you can forge documents including official papers and personal letters, as long as you have seen an example o f the kind o f document or the handwriting you are trying " +
            "to copy.",
          new string[] {
            "I fall in and out of love easily, and am always pursuing someone.",
            "I have a joke for every occasion, especially occasions where humor is inappropriate.",
            "Flattery is my preferred trick for getting what I want.",
            "I’m a born gambler who can't resist taking a risk for a potential payoff.",
            "I lie about almost everything, even when there’s no good reason to.",
            "Sarcasm and insults are my weapons of choice",
            "I keep multiple holy symbols on me and invoke whatever deity might come in useful at any given moment.",
            "I pocket anything I see that might have some value."},
          new string[] {
            "[Independence] I am a free spirit— no one tells me what to do. (Chaotic)",
            "[Fairness] I never target people who can’t afford to lose a few coins. (Lawful)",
            "[Charity] I distribute the money I acquire to the people who really need it. (Good)",
            "[Creativity] I never run the same con twice. (Chaotic)",
            "[Friendship] Material goods come and go. Bonds of friendship last forever. (Good)",
            "[Aspiration] I’m determined to make something of myself. (Any)"
          },
          new string[] {
            "I fleeced the wrong person and must work to ensure that this individual never crosses paths with me or those I care about.",
            "I owe everything to my mentor—a horrible person who’s probably rotting in jail somewhere.",
            "Somewhere out there, I have a child who doesn’t know me. I’m making the world better for him or her",
            "I come from a noble family, and one day I’ll reclaim my lands and title from those who stole them from me.",
            "A powerful person killed someone I love. Some day soon, I’ll have my revenge.",
            "I swindled and ruined a person who didn’t deserve it. I seek to atone for my misdeeds but might never be able to forgive myself."
          },
          new string[] {
            "I can’t resist a pretty face.",
            "I'm always in debt. I spend my ill-gotten gains on decadent luxuries faster than I bring them in.",
            "I’m convinced that no one could ever fool me the way I fool others.",
            "I’m too greedy for my own good. I can’t resist taking a risk if there’s money involved.",
            "I can’t resist swindling people who are more powerful than me.",
            "hate to admit it and will hate myself for it, but I'll run and preserve my own hide if the going gets tough."
          },
          new Skills[] {
            Skills.Deception,
            Skills.SleightOfHaned} ) },

          {Backgrounds.Criminal, new BackgroundModel(
            "Criminal",

            "You are an experienced criminal with a history of breaking the law. You have spent a lot o f time among other criminals and still have contacts within the criminal underworld. " +
            "You’re far closer than m ost people to the world o f murder, theft, and violence that pervades the underbelly of civilization, and you have survived up to this point by flouting " +
            "the rules and regulations o f society.",
            "You have a reliable and trustworthy contact who acts as your liaison to a network o f other criminals. " +
            "You know how to get messages to and from your contact, even over great distances; specifically, you know the local messengers, corrupt caravan masters, and seedy sailors who can " +
            "deliver messages for you.",
          new string[] {
            "I always have a plan for what to do when things go wrong.",
            "I am always calm, no matter what the situation. I never raise my voice or let my emotions control me.",
            "The first thing I do in a new place is note the locations of everything valuable—or where such things could be hidden.",
            "I would rather make a new friend than a new enemy.",
            "I am incredibly slow to trust. Those who seem the fairest often have the most to hide.",
            "I don’t pay attention to the risks in a situation. Never tell me the odds.",
            "The best way to get me to do something is to tell me I can’t do it.",
            "I blow up at the slightest insult."
          },
          new string[] {
            "[Honor] I don’t steal from others in the trade. (Lawful)",
            "[Freedom] Chains are meant to be broken, as are those who would forge them. (Chaotic)",
            "[Charity] I steal from the wealthy so that I can help people in need. (Good)",
            "[Greed] I will do whatever it takes to become wealthy. (Evil)",
            "[People] I’m loyal to my friends, not to any ideals, and everyone else can take a trip down the Styx for all I care. (Neutral)",
            "[Redemption] There’s a spark of good in everyone. (Good)"
          },
          new string[] {
            "I’m trying to pay off an old debt I owe to a generous benefactor.",
            "My ill-gotten gains go to support my family.",
            "Something important was taken from me, and I aim to steal it back.",
            "I will become the greatest thief that ever lived.",
            "I’m guilty of a terrible crime. I hope I can redeem myself for it.",
            "Someone I loved died because of a mistake I made. That will never happen again."
          },
          new string[] {
            "When I see something valuable, I can’t think about anything but how to steal it.",
            "When faced with a choice between money and my friends, I usually choose the money.",
            "If there’s a plan, I’ll forget it. If I don’t forget it, I’ll ignore it.",
            "I have a “tell” that reveals when I’m lying.",
            "I turn tail and run when things look bad.",
            "An innocent person is in prison for a crime that I committed. I’m okay with that."
          },
          new Skills[] {
            Skills.Deception,
            Skills.Stealth
          } ) },
          {Backgrounds.Entertainer, new BackgroundModel(
            "Entertainer",

            "You thrive in front of an audience. You know how to entrance them, entertain them, and even inspire them. Your poetics can stir the hearts of those who hear you, awakening grief or joy, " +
            "laughter or anger. Your music raises their spirits or captures their sorrow. Your dance steps captivate, your humor cuts to the quick. Whatever techniques you use, your art is your life.",

            "You can always find a place to perform, usually in an inn or tavern but possibly with a circus, at a theater, or even in a noble's court. At such a place, you receive free lodging and " +
            "food of a modest or comfortable standard (depending on the quality of the establishment), as long as you perform each night. In addition, your performance makes you something of " +
            "a local figure. When strangers recognize you in a town where you have performed, they typically take a liking to you.",
          new string[] {
              "I know a story relevant to almost every situation.",
              "Whenever I come to a new place, I collect local rumors and spread gossip.",
              "I'm a hopeless romantic, always searching for that 'special someone'.",
              "Nobody stays angry at me or around me for long, since I can defuse any amount of tension.",
              "I love a good insult, even one directed at me.",
              "I get bitter if I'm not the center of attention.",
              "I'll settle for nothing less than perfection.",
              "I change my mood or my mind as quickly as I change key in a song."
          },
          new string[] {
              "[Beauty] When I perform, I make the world better than it was. (Good)",
              "[Tradition] The stories, legends, and songs of the past must never be forgotten, for they teach us who we are. (Lawful)",
              "[Creativity] The world is in need of new ideas and bold action. (Chaotic)",
              "[Greed] I'm only in it for the money and fame. (Evil)",
              "[People] I like seeing the smiles on people's faces when I perform. That's all that matters. (Neutral)",
              "[Honesty] Art should reflect the soul; it should come from within and reveal who we really are. (Any)"
          },
          new string[] {
            "My instrument is my most treasured possession, and it reminds me of someone I love.",
            "Someone stole my precious instrument, and someday I’ll get it back.",
            "I want to be famous, whatever it takes.",
            "I idolize a hero of the old tales and measure my deeds against that person’s.",
            "I will do anything to prove myself superior to my hated rival.",
            "I would do anything for the other members of my old troupe."
          },
          new string[] {
            "I’ll do anything to win fame and renown.",
            "I’m a sucker for a pretty face.",
            "A scandal prevents me from ever going home again. That kind of trouble seems to follow me around.",
            "I once satirized a noble who still wants my head. It was a mistake that I will likely repeat.",
            "I have trouble keeping my true feelings hidden. My sharp tongue lands me in trouble.",
            "Despite my best efforts, I am unreliable to my friends."
          },
          new Skills[] {
            Skills.Acrobatics,
            Skills.Performance
          } ) },
          {Backgrounds.FolkHero, new BackgroundModel(
            "Folk Hero",
            "You come from a humble social rank, but you are destined for so much more. Already the people of your home village regard you as their champion, and your destiny calls you to stand against " +
            "the tyrants and monsters that threaten the common folk everywhere.",
            "Since you come from the ranks o f the common folk, you fit in among them with ease. You can find a place to hide, rest, or recuperate among other commoners, unless you have shown yourself " +
            "to be a danger to them. They will shield you from the law or anyone else searching for you, though they will not risk their lives for you.",
          new string[] {
            "I judge people by their actions, not their words.",
            "If someone is in trouble, I’m always ready to lend help",
            "When I set my mind to something, I follow through no matter what gets in my way.",
            "I have a strong sense of fair play and always try to find the most equitable solution to arguments.",
            "I’m confident in my own abilities and do what I can to instill confidence in others.",
            "Thinking is for other people. I prefer action.",
            "I misuse long words in an attempt to sound smarter.",
            "I get bored easily. When am I going to get on with my destiny?"
          },
          new string[] {
            "[Respect] People deserve to be treated with dignity and respect. (Good)",
            "[Fairness] No one should get preferential treatment before the law, and no one is above the law. (Lawful)",
            "[Freedom] Tyrants must not be allowed to oppress the people. (Chaotic)",
            "[Might] If I become strong, I can take what I want— what I deserve. (Evil)",
            "[Sincerity] There’s no good in pretending to be something I’m not. (Neutral)",
            "[Destiny] Nothing and no one can steer me away from my higher calling. (Any)"
          },
          new string[] {
            "I have a family, but I have no idea where they are. One day, I hope to see them again.",
            "I worked the land, I love the land, and I will protect the land.",
            "A proud noble once gave me a horrible beating, and I will take my revenge on any bully I encounter.",
            "My tools are symbols of my past life, and I carry them so that I will never forget my roots.",
            "I protect those who cannot protect themselves.",
            "I wish my childhood sweetheart had come with me to pursue my destiny."
          },
          new string[] {
            "The tyrant who rules my land will stop at nothing to see me killed.",
            "I’m convinced of the significance of my destiny, and blind to my shortcomings and the risk of failure.",
            "The people who knew me when I was young know my shameful secret, so I can never go home again.",
            "I have a weakness for the vices of the city, especially hard drink.",
            "Secretly, I believe that things would be better if I were a tyrant lording over the land.",
            "I have trouble trusting in my allies."
          },
          new Skills[] {
            Skills.AnimalHandling,
            Skills.Survival
          } ) },
          {Backgrounds.GuildArtian, new BackgroundModel(
            "Guild Artians",
            "You are a member of an artisan’s guild, skilled in a particular field and closely associated with other artisans. You are a well-established part o f the mercantile world, freed " +
            "by talent and wealth from the constraints o f a feudal social order. You learned your skills as an apprentice to a master artisan, under the sponsorship o f your guild, until you " +
            "became a master in your own right.",
            "As a member o f your guild, you know the skills needed to create finished items from raw materials (reflected in your proficiency with a certain kind o f artisan’s tools), " +
            "as well as the principles o f trade and good business practices. The question now is whether you abandon your trade for adventure, or take on the extra effort to weave adventuring " +
            "and trade together. " +
            "As an established and respected member of a guild, you can rely on certain benefits that membership provides. Your fellow guild members will provide you with lodging and food if " +
            "necessary, and pay for your funeral if needed. In some cities and towns, a guildhall offers a central place to meet other members o f your profession, which can be a good place to " +
            "meet potential patrons, allies, or hirelings. Guilds often wield tremendous political power. If you are accused o f a crime, your guild w ill support you if a good case can be made for " +
            "your innocence or the crime is justifiable. You can also gain access to powerful political figures through the guild, if you are a member in good standing. Such connections might " +
            "require the donation o f money or m agic items to the guild’s coffers. You must pay dues o f 5 gp per month to the guild. If you miss payments, you must make up back dues to remain in " +
            "the guild’s good graces.",
          new string[] {
            "I believe that anything worth doing is worth doing right. I can’t help it— I’m a perfectionist.",
            "I’m a snob who looks down on those who can’t appreciate fine art.",
            "I always want to know how things work and what makes people tick.",
            "I’m full of witty aphorisms and have a proverb for every occasion.",
            "I’m rude to people who lack my commitment to hard work and fair play.",
            "I like to talk at length about my profession.",
            "I don’t part with my money easily and will haggle tirelessly to get the best deal possible.",
            "I’m well known for my work, and I want to make sure everyone appreciates it. I'm always taken aback when people haven’t heard of me."
          },
          new string[] {
            "[Community] It is the duty of all civilized people to strengthen the bonds of community and the security of civilization. (Lawful)",
            "[Generosity] My talents were given to me so that I could use them to benefit the world. (Good)",
            "[Freedom] Everyone should be free to pursue his or her own livelihood. (Chaotic)",
            "[Greed] I’m only in it for the money. (Evil)",
            "[People] I’m committed to the people I care about, not to ideals. (Neutral)",
            "[Aspiration] I work hard to be the best there is at my craft."
          },
          new string[] {
            "The workshop where I learned my trade is the most important place in the world to me.",
            "I created a great work for someone, and then found them unworthy to receive it. I’m still looking for someone worthy.",
            "I owe my guild a great debt for forging me into the person I am today.",
            "I pursue wealth to secure someone’s love.",
            "One day I will return to my guild and prove that I am the greatest artisan of them all.",
            "I will get revenge on the evil forces that destroyed my place of business and ruined my livelihood."
          },
          new string[] {
            "I’ll do anything to get my hands on something rare or priceless.",
            "I’m quick to assume that someone is trying to cheat me.",
            "No one must ever learn that I once stole money from guild coffers.",
            "I’m never satisfied with what I have— I always want more.",
            "I would kill to acquire a noble title.",
            "I’m horribly jealous of anyone who can outshine my handiwork. Everywhere I go, I’m surrounded by rivals."
          },
          new Skills[] {
            Skills.Insight,
            Skills.Persuasion
          } ) },
          {Backgrounds.Hermit,new BackgroundModel(
            "Hermit",
            "You lived in seclusion—either in a sheltered community such as a monastery, or entirely a lone—for a formative part o f your life. In your time apart from the clamor of society, " +
            "you found quiet, solitude, and perhaps some of the answers you were looking for.",
            "The quiet seclusion o f your extended hermitage gave you access to a unique and powerful discovery. The exact nature o f this revelation depends on the nature of your seclusion. " +
            "It might be a great truth about the cosmos, the deities, the powerful beings o f the outer planes, or the forces o f nature. It could be a site that no one else has ever seen. " +
            "You might have uncovered a fact that has long been forgotten, or unearthed some relic o f the past that could rewrite history. It might be information that would be damaging to the people" +
            " who or consigned you to exile, and hence the reason for your return to society. Work with your DM to determine the details of your discovery and its impact on the campaign",
          new string[] {
            "I’ve been isolated for so long that I rarely speak, preferring gestures and the occasional grunt.",
            "am utterly serene, even in the face of disaster.",
            "The leader of my community had something wise to say on every topic, and I am eager to share that wisdom.",
            "I feel tremendous empathy for all who suffer.",
            "I’m oblivious to etiquette and social expectations.",
            "I connect everything that happens to me to a grand, cosmic plan.",
            "I often get lost in my own thoughts and contemplation, becoming oblivious to my surroundings.",
            "am working on a grand philosophical theory and love sharing my ideas."
          },
          new string[] {
            "[Greater Good] My gifts are meant to be shared with all, not used for my own benefit. (Good)",
            "[Logiç] Emotions must not cloud our sense of what is right and true, or our logical thinking. (Lawful)",
            "[Free Thinking] Inquiry and curiosity are the pillars of progress. (Chaotic)",
            "[Power] Solitude and contemplation are paths toward mystical or magical power. (Evil)",
            "[Live and Let Live] Meddling in the affairs of others only causes trouble. (Neutral)",
            "[Self-Knowledge] If you know yourself, there’s nothing left to know. (Any)"
          },
          new string[] {
            "Nothing is more important than the other members of my hermitage, order, or association.",
            "I entered seclusion to hide from the ones who might still be hunting me. I must someday confront them.",
            "I’m still seeking the enlightenment I pursued in my seclusion, and it still eludes me.",
            "I entered seclusion because I loved someone I could not have.",
            "Should my discovery come to light, it could bring ruin to the world.",
            "My isolation gave me great insight into a great evil that only I can destroy."
          },
          new string[] {
            "Now that I've returned to the world, I enjoy its delights a little too much.",
            "I harbor dark, bloodthirsty thoughts that my isolation and meditation failed to quell.",
            "I am dogmatic in my thoughts and philosophy.",
            "I let my need to win arguments overshadow friendships and harmony.",
            "I’d risk too much to uncover a lost bit of knowledge",
            "I like keeping secrets and won’t share them with anyone."
          },
          new Skills[] {
            Skills.Medicine,
            Skills.Relgion
          } ) },
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

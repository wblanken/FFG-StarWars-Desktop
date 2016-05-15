using System.Collections.Generic;
using SessionManager.Data;
using SessionManager.Data.Model;

namespace SessionManager
{
   public class PashDemoCharacter
   {
      public Character Character
      {
         get
         {
            var character = new Character
            {
               Name = "Pash",
               Species = "Human",
               Specializations = "Pilot",
               PlayerName = "Will",
               Career = "Smuggler",
               Gender = "Male",
               Brawn = 3,
               Agility = 3,
               Intellect = 2,
               Cunning = 3,
               Willpower = 2,
               Presence = 3,
               MeleeDefense = 0,
               RangedDefense = 0,
               Soak = 4,
               Strain = 2,
               StrainThreshold = 12,
               Wounds = 0,
               WoundsThreshold = 13
            };

            character.GeneralSkills = new List<Skill>
            {
               new Skill
               {
                  Name = Strings.Astrogation,
                  CharacteristicName = Strings.Intellect,
                  Career = true,
                  Rank = 1,
                  CharacteristicValue = character.Intellect
               },
               new Skill
               {
                  Name = Strings.Athletics,
                  CharacteristicName = Strings.Brawn,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Brawn
               },
               new Skill
               {
                  Name = Strings.Charm,
                  CharacteristicName = Strings.Presence,
                  Career = false,
                  Rank = 1,
                  CharacteristicValue = character.Presence
               },
               new Skill
               {
                  Name = Strings.Coercion,
                  CharacteristicName = Strings.Willpower,
                  Career = true,
                  Rank = 0,
                  CharacteristicValue = character.Willpower
               },
               new Skill
               {
                  Name = Strings.Computers,
                  CharacteristicName = Strings.Intellect,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Intellect
               },
               new Skill
               {
                  Name = Strings.Cool,
                  CharacteristicName = Strings.Presence,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Presence
               },
               new Skill
               {
                  Name = Strings.Coordination,
                  CharacteristicName = Strings.Agility,
                  Career = true,
                  Rank = 0,
                  CharacteristicValue = character.Agility
               },
               new Skill
               {
                  Name = Strings.Deception,
                  CharacteristicName = Strings.Cunning,
                  Career = true,
                  Rank = 1,
                  CharacteristicValue = character.Cunning
               },
               new Skill
               {
                  Name = Strings.Discipline,
                  CharacteristicName = Strings.Willpower,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Willpower
               },
               new Skill
               {
                  Name = Strings.Leadership,
                  CharacteristicName = Strings.Presence,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Presence
               },
               new Skill
               {
                  Name = Strings.Mechanics,
                  CharacteristicName = Strings.Intellect,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Intellect
               },
               new Skill
               {
                  Name = Strings.Medicine,
                  CharacteristicName = Strings.Intellect,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Intellect
               },
               new Skill
               {
                  Name = Strings.Negotiation,
                  CharacteristicName = Strings.Presence,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Presence
               },
               new Skill
               {
                  Name = Strings.Perception,
                  CharacteristicName = Strings.Cunning,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Cunning
               },
               new Skill
               {
                  Name = $"{Strings.Piloting} - {Strings.Planetary}",
                  CharacteristicName = Strings.Agility,
                  Career = true,
                  Rank = 0,
                  CharacteristicValue = character.Agility
               },
               new Skill
               {
                  Name = $"{Strings.Piloting} - {Strings.Space}",
                  CharacteristicName = Strings.Agility,
                  Career = true,
                  Rank = 2,
                  CharacteristicValue = character.Agility
               },
               new Skill
               {
                  Name = Strings.Resilience,
                  CharacteristicName = Strings.Brawn,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Brawn
               },
               new Skill
               {
                  Name = Strings.Skulduggery,
                  CharacteristicName = Strings.Cunning,
                  Career = true,
                  Rank = 0,
                  CharacteristicValue = character.Cunning
               },
               new Skill
               {
                  Name = Strings.Stealth,
                  CharacteristicName = Strings.Agility,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Agility
               },
               new Skill
               {
                  Name = Strings.Streetwise,
                  CharacteristicName = Strings.Cunning,
                  Career = true,
                  Rank = 0,
                  CharacteristicValue = character.Cunning
               },
               new Skill
               {
                  Name = Strings.Survival,
                  CharacteristicName = Strings.Cunning,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Cunning
               },
               new Skill
               {
                  Name = Strings.Vigilance,
                  CharacteristicName = Strings.Willpower,
                  Career = true,
                  Rank = 1,
                  CharacteristicValue = character.Willpower
               }
            };

            character.CombatSkills = new List<Skill>
            {
               new Skill
               {
                  Name = Strings.Brawl,
                  CharacteristicName = Strings.Brawn,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Brawn
               },
               new Skill
               {
                  Name = Strings.Gunnery,
                  CharacteristicName = Strings.Agility,
                  Career = true,
                  Rank = 0,
                  CharacteristicValue = character.Agility
               },
               new Skill
               {
                  Name = Strings.Melee,
                  CharacteristicName = Strings.Brawn,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Brawn
               },
               new Skill
               {
                  Name = $"{Strings.Ranged} - {Strings.Light}",
                  CharacteristicName = Strings.Agility,
                  Career = false,
                  Rank = 1,
                  CharacteristicValue = character.Agility
               },
               new Skill
               {
                  Name = $"{Strings.Ranged} - {Strings.Heavy}",
                  CharacteristicName = Strings.Agility,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Agility
               }
            };

            character.KnowledgeSkills = new List<Skill>
            {
               new Skill
               {
                  Name = Strings.CoreWorlds,
                  CharacteristicName = Strings.Intellect,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Intellect
               },
               new Skill
               {
                  Name = Strings.Education,
                  CharacteristicName = Strings.Intellect,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Intellect
               },
               new Skill
               {
                  Name = Strings.Lore,
                  CharacteristicName = Strings.Intellect,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Intellect
               },
               new Skill
               {
                  Name = Strings.OuterRim,
                  CharacteristicName = Strings.Intellect,
                  Career = true,
                  Rank = 0,
                  CharacteristicValue = character.Intellect
               },
               new Skill
               {
                  Name = Strings.Underworld,
                  CharacteristicName = Strings.Intellect,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Intellect
               },
               new Skill
               {
                  Name = Strings.Xenology,
                  CharacteristicName = Strings.Intellect,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Intellect
               }
            };

            return character;
         }
      }
   }
}

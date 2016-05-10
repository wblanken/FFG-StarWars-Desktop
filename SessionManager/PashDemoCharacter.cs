using System.Collections.Generic;
using SessionManager.Dto;

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
                  Name = Properties.Resources.Astrogation,
                  Characteristic = Characteristic.Intellect,
                  Career = true,
                  Rank = 1,
                  CharacteristicValue = character.Intellect
               },
               new Skill
               {
                  Name = Properties.Resources.Athletics,
                  Characteristic = Characteristic.Brawn,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Brawn
               },
               new Skill
               {
                  Name = Properties.Resources.Charm,
                  Characteristic = Characteristic.Presence,
                  Career = false,
                  Rank = 1,
                  CharacteristicValue = character.Presence
               },
               new Skill
               {
                  Name = Properties.Resources.Coercion,
                  Characteristic = Characteristic.Willpower,
                  Career = true,
                  Rank = 0,
                  CharacteristicValue = character.Willpower
               },
               new Skill
               {
                  Name = Properties.Resources.Computers,
                  Characteristic = Characteristic.Intellect,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Intellect
               },
               new Skill
               {
                  Name = Properties.Resources.Cool,
                  Characteristic = Characteristic.Presence,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Presence
               },
               new Skill
               {
                  Name = Properties.Resources.Coordination,
                  Characteristic = Characteristic.Agility,
                  Career = true,
                  Rank = 0,
                  CharacteristicValue = character.Agility
               },
               new Skill
               {
                  Name = Properties.Resources.Deception,
                  Characteristic = Characteristic.Cunning,
                  Career = true,
                  Rank = 1,
                  CharacteristicValue = character.Cunning
               },
               new Skill
               {
                  Name = Properties.Resources.Discipline,
                  Characteristic = Characteristic.Willpower,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Willpower
               },
               new Skill
               {
                  Name = Properties.Resources.Leadership,
                  Characteristic = Characteristic.Presence,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Presence
               },
               new Skill
               {
                  Name = Properties.Resources.Mechanics,
                  Characteristic = Characteristic.Intellect,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Intellect
               },
               new Skill
               {
                  Name = Properties.Resources.Medicine,
                  Characteristic = Characteristic.Intellect,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Intellect
               },
               new Skill
               {
                  Name = Properties.Resources.Negotiation,
                  Characteristic = Characteristic.Presence,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Presence
               },
               new Skill
               {
                  Name = Properties.Resources.Perception,
                  Characteristic = Characteristic.Cunning,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Cunning
               },
               new Skill
               {
                  Name = $"{Properties.Resources.Piloting} - {Properties.Resources.Planetary}",
                  Characteristic = Characteristic.Agility,
                  Career = true,
                  Rank = 0,
                  CharacteristicValue = character.Agility
               },
               new Skill
               {
                  Name = $"{Properties.Resources.Piloting} - {Properties.Resources.Space}",
                  Characteristic = Characteristic.Agility,
                  Career = true,
                  Rank = 2,
                  CharacteristicValue = character.Agility
               },
               new Skill
               {
                  Name = Properties.Resources.Resilience,
                  Characteristic = Characteristic.Brawn,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Brawn
               },
               new Skill
               {
                  Name = Properties.Resources.Skulduggery,
                  Characteristic = Characteristic.Cunning,
                  Career = true,
                  Rank = 0,
                  CharacteristicValue = character.Cunning
               },
               new Skill
               {
                  Name = Properties.Resources.Stealth,
                  Characteristic = Characteristic.Agility,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Agility
               },
               new Skill
               {
                  Name = Properties.Resources.Streetwise,
                  Characteristic = Characteristic.Cunning,
                  Career = true,
                  Rank = 0,
                  CharacteristicValue = character.Cunning
               },
               new Skill
               {
                  Name = Properties.Resources.Survival,
                  Characteristic = Characteristic.Cunning,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Cunning
               },
               new Skill
               {
                  Name = Properties.Resources.Vigilance,
                  Characteristic = Characteristic.Willpower,
                  Career = true,
                  Rank = 1,
                  CharacteristicValue = character.Willpower
               }
            };

            character.CombatSkills = new List<Skill>
            {
               new Skill
               {
                  Name = Properties.Resources.Brawl,
                  Characteristic = Characteristic.Brawn,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Brawn
               },
               new Skill
               {
                  Name = Properties.Resources.Gunnery,
                  Characteristic = Characteristic.Agility,
                  Career = true,
                  Rank = 0,
                  CharacteristicValue = character.Agility
               },
               new Skill
               {
                  Name = Properties.Resources.Melee,
                  Characteristic = Characteristic.Brawn,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Brawn
               },
               new Skill
               {
                  Name = $"{Properties.Resources.Ranged} - {Properties.Resources.Light}",
                  Characteristic = Characteristic.Agility,
                  Career = false,
                  Rank = 1,
                  CharacteristicValue = character.Agility
               },
               new Skill
               {
                  Name = $"{Properties.Resources.Ranged} - {Properties.Resources.Heavy}",
                  Characteristic = Characteristic.Agility,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Agility
               }
            };

            character.KnowledgeSkills = new List<Skill>
            {
               new Skill
               {
                  Name = Properties.Resources.CoreWorlds,
                  Characteristic = Characteristic.Intellect,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Intellect
               },
               new Skill
               {
                  Name = Properties.Resources.Education,
                  Characteristic = Characteristic.Intellect,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Intellect
               },
               new Skill
               {
                  Name = Properties.Resources.Lore,
                  Characteristic = Characteristic.Intellect,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Intellect
               },
               new Skill
               {
                  Name = Properties.Resources.OuterRim,
                  Characteristic = Characteristic.Intellect,
                  Career = true,
                  Rank = 0,
                  CharacteristicValue = character.Intellect
               },
               new Skill
               {
                  Name = Properties.Resources.Underworld,
                  Characteristic = Characteristic.Intellect,
                  Career = false,
                  Rank = 0,
                  CharacteristicValue = character.Intellect
               },
               new Skill
               {
                  Name = Properties.Resources.Xenology,
                  Characteristic = Characteristic.Intellect,
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

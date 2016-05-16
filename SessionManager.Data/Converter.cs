using System;
using System.Collections.Generic;
using System.Linq;
using SessionManager.Data.Model;

namespace SessionManager.Data
{
   public static class Converter
   {
      /// <summary>
      /// Convert OggDude's character type to our character type
      /// </summary>
      /// <param name="oggCharacter">Ogg Dude's character data</param>
      public static Character OggCharacterConverter(OggDudeData.Model.Character oggCharacter)
      {
         var character = new Character
         {
            Name = oggCharacter.Description.CharName,
            PlayerName = oggCharacter.Description.PlayerName,
            Gender = oggCharacter.Description.Gender,
            Career = OggDudeData.ImportData.LoadCareerFromTag(oggCharacter.Career.CareerKey),
            Specializations = string.Join(",", oggCharacter.Specializations.Select(s => s.Name)),
            Species = OggDudeData.ImportData.LoadSpeciesFromTag(oggCharacter.Species.SpeciesKey),
            Campaign = oggCharacter.Description.Campaign,
            Brawn = oggCharacter.Characteristics.Single(c => c.Name == Strings.Brawn).Rank.TotalRank,
            Agility = oggCharacter.Characteristics.Single(c => c.Name == Strings.Agility).Rank.TotalRank,
            Intellect = oggCharacter.Characteristics.Single(c => c.Name == Strings.Intellect).Rank.TotalRank,
            Willpower = oggCharacter.Characteristics.Single(c => c.Name == Strings.Willpower).Rank.TotalRank,
            Cunning = oggCharacter.Characteristics.Single(c => c.Name == Strings.Cunning).Rank.TotalRank,
            Presence = oggCharacter.Characteristics.Single(c => c.Name == Strings.Presence).Rank.TotalRank,
            WoundsThreshold = oggCharacter.Attributes.WoundThreshold.Total,
            StrainThreshold = oggCharacter.Attributes.StrainThreshold.Total,
            Soak = oggCharacter.Attributes.SoakValue.Total,
            MeleeDefense = oggCharacter.Attributes.DefenseMelee.Total,
            RangedDefense = oggCharacter.Attributes.DefenseRanged.Total,
            ForceRating = oggCharacter.Attributes.ForceRating.Total,
            GeneralSkills = new List<Skill>(),
            CombatSkills = new List<Skill>(),
            KnowledgeSkills = new List<Skill>(),
            FileName = oggCharacter.FileName,
            Id = Guid.Parse(oggCharacter.Key),
            LastModified = oggCharacter.LastChanged
         };

         // Skills
         foreach (var skill in oggCharacter.Skills)
         {
            var convSkill = OggCharacterSkillConverter(skill);
            convSkill.Value.CharacteristicValue =
               oggCharacter.Characteristics.Single(s => s.Name == convSkill.Value.CharacteristicName).Rank.TotalRank;

            switch (convSkill.Key)
            {
               case Strings.General:
                  character.GeneralSkills.Add(convSkill.Value);
                  break;
               case Strings.Combat:
                  character.CombatSkills.Add(convSkill.Value);
                  break;
               case Strings.Knowledge:
                  character.KnowledgeSkills.Add(convSkill.Value);
                  break;
               default:
                  throw new ArgumentException("Skill type is invalid");
            }
         }
         return character;
      }

      private static KeyValuePair<string, Skill> OggCharacterSkillConverter(OggDudeData.Model.CharacterCharSkill skill)
      {
         var oggDudeSkill = OggDudeData.ImportData.LoadSkills().Skill.SingleOrDefault(s => s.Key == skill.Key);
         var oggDudeCharacteristic = OggDudeData.ImportData.LoadCharacteristics()
            .Characteristic.SingleOrDefault(s => s.Key == oggDudeSkill.CharKey);
         var convSkill = new Skill
         {
            Name = oggDudeSkill.Name,
            CharacteristicName = oggDudeCharacteristic.Name,
            Career = skill.isCareer,
            Rank = skill.Rank.Total
         };
         string type;
         switch (oggDudeSkill.TypeValue)
         {
            case "stCombat":
               type = Strings.Combat;
               break;
            case "stKnowledge":
               type = Strings.Knowledge;
               break;
            default:
               type = Strings.General;
               break;
         }
         return new KeyValuePair<string, Skill>(type, convSkill);
      }
   }
}

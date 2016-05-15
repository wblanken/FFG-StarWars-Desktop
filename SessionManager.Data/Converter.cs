using System;
using System.Collections.Generic;
using System.Linq;

namespace SessionManager.Data
{
   public static class Converter
   {
      /// <summary>
      /// Convert OggDude's character type to our character type
      /// </summary>
      /// <param name="oggCharacter">Ogg Dude's character data</param>
      public static Dto.Character OggCharacterConverter(OggDudeData.Model.Character oggCharacter)
      {
         var character = new Dto.Character
         {
            Name = oggCharacter.Description.CharName,
            PlayerName = oggCharacter.Description.PlayerName,
            Gender = oggCharacter.Description.Gender,
            Career = oggCharacter.Career.CareerKey, //TODO
            Specializations = string.Join(",", oggCharacter.Specializations.Select(s => s.Name)),
            Species = oggCharacter.Species.SpeciesKey, //TODO
            Brawn = oggCharacter.Characteristics.SingleOrDefault(c => c.Name == Strings.Brawn).Rank.TotalRank,
            Agility = oggCharacter.Characteristics.SingleOrDefault(c => c.Name == Strings.Agility).Rank.TotalRank,
            Intellect = oggCharacter.Characteristics.SingleOrDefault(c => c.Name == Strings.Intellect).Rank.TotalRank,
            Willpower = oggCharacter.Characteristics.SingleOrDefault(c => c.Name == Strings.Willpower).Rank.TotalRank,
            Cunning = oggCharacter.Characteristics.SingleOrDefault(c => c.Name == Strings.Cunning).Rank.TotalRank,
            Presence = oggCharacter.Characteristics.SingleOrDefault(c => c.Name == Strings.Presence).Rank.TotalRank,
            WoundsThreshold = oggCharacter.Attributes.WoundThreshold.Total,
            StrainThreshold = oggCharacter.Attributes.StrainThreshold.Total,
            Soak = oggCharacter.Attributes.SoakValue.Total,
            MeleeDefense = oggCharacter.Attributes.DefenseMelee.Total,
            RangedDefense = oggCharacter.Attributes.DefenseRanged.Total,
            ForceRating = oggCharacter.Attributes.ForceRating.Total,
            GeneralSkills = new List<Dto.Skill>(),
            CombatSkills = new List<Dto.Skill>(),
            KnowledgeSkills = new List<Dto.Skill>(),
            FileName = oggCharacter.FileName,
            Id = Guid.Parse(oggCharacter.Key),
            LastModified = oggCharacter.LastChanged
         };

         // Skills
         foreach (var skill in oggCharacter.Skills)
         {
            var convSkill = OggCharacterSkillConverter(skill);

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

      private static KeyValuePair<string, Dto.Skill> OggCharacterSkillConverter(OggDudeData.Model.CharacterCharSkill skill)
      {
         var oggDudeSkill = OggDudeData.ImportData.LoadSkills().Skill.SingleOrDefault(s => s.Key == skill.Key);
         var oggDudeCharacteristic = OggDudeData.ImportData.LoadCharacteristics()
            .Characteristic.SingleOrDefault(s => s.Key == oggDudeSkill.CharKey);
         var convSkill = new Dto.Skill
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
         return new KeyValuePair<string, Dto.Skill>(type, convSkill);
      }
   }
}

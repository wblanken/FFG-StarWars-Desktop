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
         return new Dto.Character
         {
            Name = oggCharacter.Description.CharName,
            PlayerName = oggCharacter.Description.PlayerName,
            Gender = oggCharacter.Description.Gender,
            Career = oggCharacter.Career.CareerKey,
            Species = oggCharacter.Species.SpeciesKey,
            Brawn = oggCharacter.Characteristics.SingleOrDefault(c => c.Name == "Brawn").Rank.TotalRank,
            Agility = oggCharacter.Characteristics.SingleOrDefault(c => c.Name == "Agility").Rank.TotalRank,
            Intellect = oggCharacter.Characteristics.SingleOrDefault(c => c.Name == "Intellect").Rank.TotalRank,
            Willpower = oggCharacter.Characteristics.SingleOrDefault(c => c.Name == "Willpower").Rank.TotalRank,
            Cunning = oggCharacter.Characteristics.SingleOrDefault(c => c.Name == "Cunning").Rank.TotalRank,
            Presence = oggCharacter.Characteristics.SingleOrDefault(c => c.Name == "Presence").Rank.TotalRank,
            WoundsThreshold = oggCharacter.Attributes.WoundThreshold.Total,
            StrainThreshold = oggCharacter.Attributes.StrainThreshold.Total,
            Soak = oggCharacter.Attributes.SoakValue.Total,
            MeleeDefense = oggCharacter.Attributes.DefenseMelee.Total,
            RangedDefense = oggCharacter.Attributes.DefenseRanged.Total,
            ForceRating = oggCharacter.Attributes.ForceRating.Total
         };
      }
   }
}

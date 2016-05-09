using System.Collections.Generic;
using SessionManager.Dto;

namespace SessionManager.ViewModels
{
   public class CharacterViewModel : ViewModelBase
   {
      public CharacterViewModel()
      {
         Character = new Character
         {
            Attributes = new Attributes
            {
               MeleeDefense = 0,
               RangedDefense = 0,
               Soak = 4,
               Strain = 2,
               StrainThreshold = 12,
               Wounds = 0,
               WoundsThreshold = 13
            },
            Characteristics = new Characteristics
            {
               Brawn = 3,
               Agility = 3,
               Intellect = 2,
               Cunning = 3,
               Willpower = 2,
               Presence = 3
            }
         };

         Character.GeneralSkills = new List<Skill>
         {
            new Skill
            {
               Name = Properties.Resources.Astrogation,
               Characteristic = Characteristic.Intellect,
               Career = true,
               Rank = 1,
               CharacteristicValue = Character.Characteristics.Intellect
            },
            new Skill
            {
               Name = Properties.Resources.Athletics,
               Characteristic = Characteristic.Brawn,
               Career = false,
               Rank = 0,
               CharacteristicValue = Character.Characteristics.Brawn
            }
         };
      }

      public Character Character { get; set; }
   }
}

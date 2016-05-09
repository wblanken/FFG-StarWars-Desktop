using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace SessionManager.Dto
{
   public class Skill
   {
      public string Name { get; set; }
      public Characteristic Characteristic { get; set; }
      public bool Career { get; set; }
      public int Rank { get; set; }
      public int CharacteristicValue { get; set; }

      public string CharacteristicName => Utility.GetSkillCharacteristicName(Characteristic);

      public List<Image> DicePool
      {
         get
         {
            var dicePool = new List<Image>();
            var proficency = CharacteristicValue < Rank ? CharacteristicValue : Rank;
            var ability = CharacteristicValue > Rank ? CharacteristicValue : Rank;

            for (var i = 0; i < proficency; i++)
            {
               var img = new Image
               {
                  Source =
                     new BitmapImage(new Uri(@"pack://application:,,,/SessionManager;component/Resources/Proficiency.png"))
               };
               dicePool.Add(img);

               ability--; // Remove an ability die
            }

            for (var i = 0; i < ability; i++)
            {
               var img = new Image
               {
                  Source =
                     new BitmapImage(new Uri(@"pack://application:,,,/SessionManager;component/Resources/Ability.png"))
               };
               dicePool.Add(img);
            }

            return dicePool;
         }
      }
   }
}
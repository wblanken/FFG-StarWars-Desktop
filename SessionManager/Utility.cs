using System;
using System.Linq.Expressions;

namespace SessionManager
{
   public class Utility
   {
      public static string GetNameOf<T>(Expression<Func<T>> property)
      {
         return (property.Body as MemberExpression).Member.Name;
      }

      public static string GetSkillCharacteristicName(Characteristic characteristic)
      {
         var name = string.Empty;
         switch (characteristic)
         {
            case Characteristic.Brawn:
               name = Utility.GetNameOf(() => Properties.Resources.Br);
               break;
            case Characteristic.Agility:
               name = Utility.GetNameOf(() => Properties.Resources.Ag);
               break;
            case Characteristic.Intellect:
               name = Utility.GetNameOf(() => Properties.Resources.Int);
               break;
            case Characteristic.Cunning:
               name = Utility.GetNameOf(() => Properties.Resources.Cun);
               break;
            case Characteristic.Willpower:
               name = Utility.GetNameOf(() => Properties.Resources.Wil);
               break;
            case Characteristic.Presence:
               name = Utility.GetNameOf(() => Properties.Resources.Pr);
               break;
         }
         return name;
      }
   }
}
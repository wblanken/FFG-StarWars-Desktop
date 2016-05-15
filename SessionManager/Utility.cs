using System.Windows;
using SessionManager.Data;
using SessionManager.Dto;

namespace SessionManager
{
   public class Utility
   {
      public static string GetSkillCharacteristicName(string characteristicName)
      {
         var name = string.Empty;
         switch (characteristicName)
         {
            case Strings.Brawn:
               name = "Br";
               break;
            case Strings.Agility:
               name = "Ag";
               break;
            case Strings.Intellect:
               name = "Int";
               break;
            case Strings.Cunning:
               name = "Cun";
               break;
            case Strings.Willpower:
               name = "Wil";
               break;
            case Strings.Presence:
               name = "Pr";
               break;
         }
         return name;
      }
   }

   public class BindingProxy : Freezable
   {
      #region Overrides of Freezable

      protected override Freezable CreateInstanceCore()
      {
         return new BindingProxy();
      }

      #endregion

      public object Data
      {
         get { return GetValue(DataProperty); }
         set { SetValue(DataProperty, value); }
      }

      // Using a DependencyProperty as the backing store for Data.  This enables animation, styling, binding, etc...
      public static readonly DependencyProperty DataProperty =
          DependencyProperty.Register("Data", typeof(object), typeof(BindingProxy), new UIPropertyMetadata(null));
   }
}
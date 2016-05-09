using System;
using System.Linq.Expressions;
using System.Windows;

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
         get { return (object)GetValue(DataProperty); }
         set { SetValue(DataProperty, value); }
      }

      // Using a DependencyProperty as the backing store for Data.  This enables animation, styling, binding, etc...
      public static readonly DependencyProperty DataProperty =
          DependencyProperty.Register("Data", typeof(object), typeof(BindingProxy), new UIPropertyMetadata(null));
   }
}
using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace SessionManager.Converters
{
   public class ImageCollectionConverter : IMultiValueConverter
   {
      public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
      {
         if (values.Length > 0 && values[0] is int)
         {
            var rank = (int) values[0];
            var characteristicValue = (int) values[1];

            var stack = new StackPanel { Orientation = Orientation.Horizontal };

            var proficency = characteristicValue < rank ? characteristicValue : rank;
            var ability = characteristicValue > rank ? characteristicValue : rank;

            for (var i = 0; i < proficency; i++)
            {
               var img = new Image
               {
                  Source =
                     new BitmapImage(
                        new Uri(@"pack://application:,,,/SessionManager;component/Resources/Proficiency.png"))
               };
               stack.Children.Add(img);

               ability--; // Remove an ability die
            }

            for (var i = 0; i < ability; i++)
            {
               var img = new Image
               {
                  Source =
                     new BitmapImage(new Uri(@"pack://application:,,,/SessionManager;component/Resources/Ability.png"))
               };
               stack.Children.Add(img);
            }

            return stack;
         }
         return null;
      }

      public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
      {
         throw new NotImplementedException();
      }
   }
}

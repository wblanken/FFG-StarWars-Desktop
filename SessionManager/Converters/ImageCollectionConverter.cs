using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace SessionManager.Converters
{
   public class ImageCollectionConverter : IValueConverter
   {
      public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
      {
         var images = value as List<Image>;
         if (images != null)
         {
            var stack = new StackPanel();
            stack.Orientation = Orientation.Horizontal;

            foreach (var image in images)
            {
               var uiImage = new Image();
               uiImage.Source = image.Source;
               stack.Children.Add(image);
            }

            return stack;
         }
         return null;
      }

      public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
      {
         throw new NotImplementedException();
      }
   }
}

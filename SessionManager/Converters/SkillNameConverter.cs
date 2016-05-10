using System;
using System.Globalization;
using System.Windows.Data;
using SessionManager.Dto;

namespace SessionManager.Converters
{
   class SkillNameConverter : IMultiValueConverter
   {
      public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
      {
         if (values.Length > 0 && values[0] is string && values[1] is Characteristic)
         {
            return $"{values[0]} ({Utility.GetSkillCharacteristicName((Characteristic)values[1])})";
         }
         return string.Empty;
      }

      public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
      {
         throw new NotImplementedException();
      }
   }
}

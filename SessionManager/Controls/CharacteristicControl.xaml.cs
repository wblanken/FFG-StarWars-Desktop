using System.Windows;
using System.Windows.Controls;

namespace SessionManager.Controls
{
   /// <summary>
   /// Interaction logic for Characteristic.xaml
   /// </summary>
   public partial class CharacteristicControl : UserControl
   {
      public CharacteristicControl()
      {
         InitializeComponent();
      }

      public static DependencyProperty CharacteristicNameProperty =
         DependencyProperty.Register("CharacteristicName", typeof(string), typeof(CharacteristicControl));

      public static DependencyProperty CharacteristicValueProperty =
         DependencyProperty.Register("CharacteristicValue", typeof(int), typeof(CharacteristicControl));

      public string CharacteristicName
      {
         get { return (string) GetValue(CharacteristicNameProperty); }
         set { SetValue(CharacteristicNameProperty, value); }
      }

      public int CharacteristicValue
      {
         get { return (int)GetValue(CharacteristicValueProperty); }
         set { SetValue(CharacteristicValueProperty, value); }
      }
   }
}

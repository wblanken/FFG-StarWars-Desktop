using System.Windows;
using System.Windows.Controls;
using SessionManager.Dto;

namespace SessionManager.Controls
{
   /// <summary>
   /// Interaction logic for CharacteristicsControl.xaml
   /// </summary>
   public partial class CharacteristicsHeaderControl : UserControl
   {
      public CharacteristicsHeaderControl()
      {
         InitializeComponent();
      }

      public static DependencyProperty CharacteristicsDependencyProperty =
         DependencyProperty.Register("Characteristics", typeof(Characteristics), typeof(CharacteristicsHeaderControl));

      public Characteristics Characteristics
      {
         get { return (Characteristics)GetValue(CharacteristicsDependencyProperty); }
         set { SetValue(CharacteristicsDependencyProperty, value); }
      }
   }
}

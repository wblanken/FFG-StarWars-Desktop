using System.Windows;
using System.Windows.Controls;

namespace SessionManager.Controls
{
   /// <summary>
   /// Interaction logic for SectionHeader.xaml
   /// </summary>
   public partial class SectionHeader : UserControl
   {
      public SectionHeader()
      {
         InitializeComponent();
      }

      public static DependencyProperty HeaderProperty =
         DependencyProperty.Register("Header", typeof(string), typeof(SectionHeader));

      public string Header
      {
         get { return (string)GetValue(HeaderProperty); }
         set { SetValue(HeaderProperty, value); }
      }
   }
}

using System.Windows;
using System.Windows.Controls;
using SessionManager.Data;

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
         DependencyProperty.Register(Strings.Header, typeof(string), typeof(SectionHeader));

      public string Header
      {
         get { return (string)GetValue(HeaderProperty); }
         set { SetValue(HeaderProperty, value); }
      }
   }
}

using System.Windows;
using System.Windows.Controls;
using SessionManager.Dto;

namespace SessionManager.Controls
{
   /// <summary>
   /// Interaction logic for AttributesHeaderControl.xaml
   /// </summary>
   public partial class AttributesHeaderControl : UserControl
   {
      public AttributesHeaderControl()
      {
         InitializeComponent();
      }

      public static DependencyProperty AttributesDependencyProperty =
         DependencyProperty.Register(Properties.Resources.Attributes, typeof(Attributes), typeof(AttributesHeaderControl));

      public Attributes Attributes
      {
         get { return (Attributes)GetValue(AttributesDependencyProperty); }
         set { SetValue(AttributesDependencyProperty, value); }
      }
   }
}

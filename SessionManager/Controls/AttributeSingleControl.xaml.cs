using System.Windows;
using System.Windows.Controls;

namespace SessionManager.Controls
{
   /// <summary>
   /// Interaction logic for AttributeSingleControl.xaml
   /// </summary>
   public partial class AttributeSingleControl : UserControl
   {
      public AttributeSingleControl()
      {
         InitializeComponent();
      }
      
      public static DependencyProperty AttributeNameProperty =
         DependencyProperty.Register("AttributeName", typeof(string), typeof(AttributeSingleControl));

      public static DependencyProperty AttributeValueProperty =
         DependencyProperty.Register("AttributeValue", typeof(int), typeof(AttributeSingleControl));

      public string AttributeName
      {
         get { return (string)GetValue(AttributeNameProperty); }
         set { SetValue(AttributeNameProperty, value); }
      }

      public int AttributeValue
      {
         get { return (int)GetValue(AttributeValueProperty); }
         set { SetValue(AttributeValueProperty, value); }
      }
   }
}

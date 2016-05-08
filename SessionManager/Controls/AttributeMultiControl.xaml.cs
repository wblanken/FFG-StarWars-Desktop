using System.Windows;
using System.Windows.Controls;

namespace SessionManager.Controls
{
   /// <summary>
   /// Interaction logic for AttributeMultiControl.xaml
   /// </summary>
   public partial class AttributeMultiControl : UserControl
   {
      public AttributeMultiControl()
      {
         InitializeComponent();
      }

      public static DependencyProperty AttributeNameProperty =
         DependencyProperty.Register("AttributeName", typeof(string), typeof(AttributeMultiControl));

      public static DependencyProperty AttributeLeftNameProperty =
         DependencyProperty.Register("AttributeLeft", typeof(string), typeof(AttributeMultiControl));

      public static DependencyProperty AttributeRightNameProperty =
         DependencyProperty.Register("AttributeRight", typeof(string), typeof(AttributeMultiControl));

      public static DependencyProperty AttributeLeftValueProperty =
         DependencyProperty.Register("AttributeLeftValue", typeof(int), typeof(AttributeMultiControl));

      public static DependencyProperty AttributeRightValueProperty =
         DependencyProperty.Register("AttributeRightValue", typeof(int), typeof(AttributeMultiControl));

      public string AttributeName
      {
         get { return (string)GetValue(AttributeNameProperty); }
         set { SetValue(AttributeNameProperty, value); }
      }

      public string AttributeLeftName
      {
         get { return (string)GetValue(AttributeLeftNameProperty); }
         set { SetValue(AttributeLeftNameProperty, value); }
      }

      public string AttributeRightName
      {
         get { return (string)GetValue(AttributeRightNameProperty); }
         set { SetValue(AttributeRightNameProperty, value); }
      }

      public int AttributeLeftValue
      {
         get { return (int)GetValue(AttributeLeftValueProperty); }
         set { SetValue(AttributeLeftValueProperty, value); }
      }

      public int AttributeRightValue
      {
         get { return (int)GetValue(AttributeRightValueProperty); }
         set { SetValue(AttributeRightValueProperty, value); }
      }
   }
}

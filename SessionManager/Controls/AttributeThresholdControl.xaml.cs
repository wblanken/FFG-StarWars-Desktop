using System.Windows;
using System.Windows.Controls;

namespace SessionManager.Controls
{
   /// <summary>
   /// Interaction logic for AttributeThresholdControl.xaml
   /// </summary>
   public partial class AttributeThresholdControl : UserControl
   {
      public AttributeThresholdControl()
      {
         InitializeComponent();
      }

      public static DependencyProperty AttributeNameProperty =
         DependencyProperty.Register("AttributeName", typeof(string), typeof(AttributeThresholdControl));

      public static DependencyProperty AttributeMaxProperty =
         DependencyProperty.Register("AttributeMax", typeof(string), typeof(AttributeThresholdControl));

      public static DependencyProperty AttributeValueNameProperty =
         DependencyProperty.Register("AttributeValueName", typeof(string), typeof(AttributeThresholdControl));

      public static DependencyProperty AttributeValueProperty =
         DependencyProperty.Register("AttributeValue", typeof(int), typeof(AttributeThresholdControl));

      public static DependencyProperty AttributeThresholdProperty =
         DependencyProperty.Register("AttributeThreshold", typeof(int), typeof(AttributeThresholdControl));

      public string AttributeName
      {
         get { return (string)GetValue(AttributeNameProperty); }
         set { SetValue(AttributeNameProperty, value); }
      }

      public string AttributeMax
      {
         get { return (string)GetValue(AttributeMaxProperty); }
         set { SetValue(AttributeMaxProperty, value); }
      }

      public string AttributeValueName
      {
         get { return (string)GetValue(AttributeValueNameProperty); }
         set { SetValue(AttributeValueNameProperty, value); }
      }

      public int AttributeValue
      {
         get { return (int)GetValue(AttributeValueProperty); }
         set { SetValue(AttributeValueProperty, value); }
      }

      public int AttributeThreshold
      {
         get { return (int)GetValue(AttributeThresholdProperty); }
         set { SetValue(AttributeThresholdProperty, value); }
      }
   }
}

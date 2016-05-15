using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using SessionManager.Data.Model;

namespace SessionManager.Controls
{
   /// <summary>
   /// Interaction logic for SkillListControl.xaml
   /// </summary>
   public partial class SkillListControl : UserControl
   {
      public SkillListControl()
      {
         InitializeComponent();
      }

      public static DependencyProperty SkillListNameProperty =
         DependencyProperty.Register("SkillListName", typeof(string), typeof(SkillListControl));

      public static DependencyProperty SkillListProperty =
         DependencyProperty.Register("SkillList", typeof(List<Skill>),typeof(SkillListControl));

      public string SkillListName
      {
         get { return (string)GetValue(SkillListNameProperty); }
         set { SetValue(SkillListNameProperty, value); }
      }

      public List<Skill> SkillList
      {
         get { return (List<Skill>)GetValue(SkillListProperty); }
         set { SetValue(SkillListProperty, value); }
      }
   }
}

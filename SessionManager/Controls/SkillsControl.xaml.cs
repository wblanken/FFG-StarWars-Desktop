using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using SessionManager.Dto;

namespace SessionManager.Controls
{
   /// <summary>
   /// Interaction logic for SkillsListControl.xaml
   /// </summary>
   public partial class SkillsControl : UserControl
   {
      public SkillsControl()
      {
         InitializeComponent();
      }

      public static DependencyProperty GeneralSkillsProperty =
         DependencyProperty.Register("GeneralSkills", typeof(List<Skill>), typeof(SkillsControl));

      public static DependencyProperty CombatSkillsProperty =
         DependencyProperty.Register("CombatSkills", typeof(List<Skill>), typeof(SkillsControl));

      public static DependencyProperty KnowledgeSkillsProperty =
         DependencyProperty.Register("KnowledgeSkills", typeof(List<Skill>), typeof(SkillsControl));

      public List<Skill> GeneralSkills
      {
         get { return (List<Skill>)GetValue(GeneralSkillsProperty); }
         set { SetValue(GeneralSkillsProperty, value); }
      }

      public List<Skill> CombatSkills
      {
         get { return (List<Skill>)GetValue(CombatSkillsProperty); }
         set { SetValue(CombatSkillsProperty, value); }
      }

      public List<Skill> KnowledgeSkills
      {
         get { return (List<Skill>)GetValue(KnowledgeSkillsProperty); }
         set { SetValue(KnowledgeSkillsProperty, value); }
      }
   }
}

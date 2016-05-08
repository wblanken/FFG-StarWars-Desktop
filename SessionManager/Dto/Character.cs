using System.Collections.Generic;

namespace SessionManager.Dto
{
   public class Character
   {
      public Characteristics Characteristics { get; set;}
      public Attributes Attributes { get; set;}
      public List<Skill> GeneralSkills { get; set; }
      public List<Skill> CombatSkills { get; set; }
      public List<Skill> KnowledgeSkills { get; set; }
   }
}

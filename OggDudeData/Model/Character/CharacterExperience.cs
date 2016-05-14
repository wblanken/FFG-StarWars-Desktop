using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace OggDudeData.Model.Character
{
   /// <remarks/>
   [GeneratedCode("xsd", "4.6.1055.0")]
   [Serializable]
   [DebuggerStepThrough]
   [DesignerCategory("code")]
   [XmlType(AnonymousType=true)]
   public class CharacterExperience {
    
      private string usedExperienceField;
    
      private CharacterExperienceExperienceRanks[] experienceRanksField;
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string UsedExperience {
         get {
            return usedExperienceField;
         }
         set {
            usedExperienceField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement("ExperienceRanks", Form=XmlSchemaForm.Unqualified)]
      public CharacterExperienceExperienceRanks[] ExperienceRanks {
         get {
            return experienceRanksField;
         }
         set {
            experienceRanksField = value;
         }
      }
   }
}
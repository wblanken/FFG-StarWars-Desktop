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
   public class CharacterSummaryPriorities {
    
      private string talentPrioritiesField;
    
      private string forcePrioritiesField;
    
      private string obligPrioritiesField;
    
      private string dutyPrioritiesField;
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string TalentPriorities {
         get {
            return talentPrioritiesField;
         }
         set {
            talentPrioritiesField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string ForcePriorities {
         get {
            return forcePrioritiesField;
         }
         set {
            forcePrioritiesField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string ObligPriorities {
         get {
            return obligPrioritiesField;
         }
         set {
            obligPrioritiesField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string DutyPriorities {
         get {
            return dutyPrioritiesField;
         }
         set {
            dutyPrioritiesField = value;
         }
      }
   }
}
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
   public class CharacterCareer {
    
      private string careerKeyField;
    
      private string startingSpecKeyField;
    
      private Key[] careerSkillsField;
    
      private Key[] careerSpecSkillsField;
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string CareerKey {
         get {
            return careerKeyField;
         }
         set {
            careerKeyField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string StartingSpecKey {
         get {
            return startingSpecKeyField;
         }
         set {
            startingSpecKeyField = value;
         }
      }
    
      /// <remarks/>
      [XmlArray(Form=XmlSchemaForm.Unqualified)]
      [XmlArrayItem("Key", typeof(Key))]
      public Key[] CareerSkills {
         get {
            return careerSkillsField;
         }
         set {
            careerSkillsField = value;
         }
      }
    
      /// <remarks/>
      [XmlArray(Form=XmlSchemaForm.Unqualified)]
      [XmlArrayItem("Key", typeof(Key))]
      public Key[] CareerSpecSkills {
         get {
            return careerSpecSkillsField;
         }
         set {
            careerSpecSkillsField = value;
         }
      }
   }
}
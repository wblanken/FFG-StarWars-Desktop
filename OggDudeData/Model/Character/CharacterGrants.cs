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
   public class CharacterGrants {
    
      private string useGrantsField;
    
      private string freeSpecsField;
    
      private string freeSkillsField;
    
      private string freeTalentsField;
    
      private string freeFRField;
    
      private string freeFRCountField;
    
      private string talentCharWoundField;
    
      private string talentCharStrainField;
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string UseGrants {
         get {
            return useGrantsField;
         }
         set {
            useGrantsField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string FreeSpecs {
         get {
            return freeSpecsField;
         }
         set {
            freeSpecsField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string FreeSkills {
         get {
            return freeSkillsField;
         }
         set {
            freeSkillsField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string FreeTalents {
         get {
            return freeTalentsField;
         }
         set {
            freeTalentsField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string FreeFR {
         get {
            return freeFRField;
         }
         set {
            freeFRField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string FreeFRCount {
         get {
            return freeFRCountField;
         }
         set {
            freeFRCountField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string TalentCharWound {
         get {
            return talentCharWoundField;
         }
         set {
            talentCharWoundField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string TalentCharStrain {
         get {
            return talentCharStrainField;
         }
         set {
            talentCharStrainField = value;
         }
      }
   }
}
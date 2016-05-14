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
   public class CharacterSpecializationsCharSpecializationTalentsCharTalent {
    
      private string keyField;
    
      private string colField;
    
      private string rowField;
    
      private string purchasedField;
    
      private string freeField;
    
      private string ranksField;
    
      private string bonusCharsField;
    
      private string sourcesField;
    
      private string careerSkillsField;
    
      private string selectedSkillsField;
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Key {
         get {
            return keyField;
         }
         set {
            keyField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Col {
         get {
            return colField;
         }
         set {
            colField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Row {
         get {
            return rowField;
         }
         set {
            rowField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Purchased {
         get {
            return purchasedField;
         }
         set {
            purchasedField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Free {
         get {
            return freeField;
         }
         set {
            freeField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Ranks {
         get {
            return ranksField;
         }
         set {
            ranksField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string BonusChars {
         get {
            return bonusCharsField;
         }
         set {
            bonusCharsField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Sources {
         get {
            return sourcesField;
         }
         set {
            sourcesField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string CareerSkills {
         get {
            return careerSkillsField;
         }
         set {
            careerSkillsField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string SelectedSkills {
         get {
            return selectedSkillsField;
         }
         set {
            selectedSkillsField = value;
         }
      }
   }
}
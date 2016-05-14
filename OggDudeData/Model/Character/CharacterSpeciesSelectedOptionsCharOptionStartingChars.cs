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
   public class CharacterSpeciesSelectedOptionsCharOptionStartingChars {
    
      private string brawnField;
    
      private string agilityField;
    
      private string intellectField;
    
      private string cunningField;
    
      private string willpowerField;
    
      private string presenceField;
    
      private Requirement[] requirementField;
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Brawn {
         get {
            return brawnField;
         }
         set {
            brawnField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Agility {
         get {
            return agilityField;
         }
         set {
            agilityField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Intellect {
         get {
            return intellectField;
         }
         set {
            intellectField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Cunning {
         get {
            return cunningField;
         }
         set {
            cunningField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Willpower {
         get {
            return willpowerField;
         }
         set {
            willpowerField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Presence {
         get {
            return presenceField;
         }
         set {
            presenceField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement("Requirement")]
      public Requirement[] Requirement {
         get {
            return requirementField;
         }
         set {
            requirementField = value;
         }
      }
   }
}
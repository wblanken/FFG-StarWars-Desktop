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
   public class CharacterMotivationsCharMotivation {
    
      private string keyField;
    
      private string nameField;
    
      private string descriptionField;
    
      private string sourceField;
    
      private string sourcesField;
    
      private string customField;
    
      private string notesField;
    
      private string motiveKeyField;
    
      private string specMotiveKeyField;
    
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
      public string Name {
         get {
            return nameField;
         }
         set {
            nameField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Description {
         get {
            return descriptionField;
         }
         set {
            descriptionField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Source {
         get {
            return sourceField;
         }
         set {
            sourceField = value;
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
      public string Custom {
         get {
            return customField;
         }
         set {
            customField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Notes {
         get {
            return notesField;
         }
         set {
            notesField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string MotiveKey {
         get {
            return motiveKeyField;
         }
         set {
            motiveKeyField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string SpecMotiveKey {
         get {
            return specMotiveKeyField;
         }
         set {
            specMotiveKeyField = value;
         }
      }
   }
}
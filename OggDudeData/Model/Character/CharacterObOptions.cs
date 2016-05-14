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
   public class CharacterObOptions {
    
      private string startingSizeField;
    
      private string plus5XPField;
    
      private string plus10XPField;
    
      private string plus1000CrField;
    
      private string plus2500CrField;
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string StartingSize {
         get {
            return startingSizeField;
         }
         set {
            startingSizeField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Plus5XP {
         get {
            return plus5XPField;
         }
         set {
            plus5XPField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Plus10XP {
         get {
            return plus10XPField;
         }
         set {
            plus10XPField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Plus1000Cr {
         get {
            return plus1000CrField;
         }
         set {
            plus1000CrField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Plus2500Cr {
         get {
            return plus2500CrField;
         }
         set {
            plus2500CrField = value;
         }
      }
   }
}
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
   public class CharacterMorality {
    
      private string moralityPairsField;
    
      private string modifiedMoralityField;
    
      private string moralityValueField;
    
      private CharacterMoralityOptions[] optionsField;
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string MoralityPairs {
         get {
            return moralityPairsField;
         }
         set {
            moralityPairsField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string ModifiedMorality {
         get {
            return modifiedMoralityField;
         }
         set {
            modifiedMoralityField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string MoralityValue {
         get {
            return moralityValueField;
         }
         set {
            moralityValueField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement("Options", Form=XmlSchemaForm.Unqualified)]
      public CharacterMoralityOptions[] Options {
         get {
            return optionsField;
         }
         set {
            optionsField = value;
         }
      }
   }
}
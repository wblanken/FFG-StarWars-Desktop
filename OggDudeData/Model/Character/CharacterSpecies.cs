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
   public class CharacterSpecies {
    
      private string speciesKeyField;
    
      private string subSpeciesKeyField;
    
      private CharacterSpeciesSelectedOptionsCharOption[] selectedOptionsField;
    
      private Key[] nonCareerSkillsField;
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string SpeciesKey {
         get {
            return speciesKeyField;
         }
         set {
            speciesKeyField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string SubSpeciesKey {
         get {
            return subSpeciesKeyField;
         }
         set {
            subSpeciesKeyField = value;
         }
      }
    
      /// <remarks/>
      [XmlArray(Form=XmlSchemaForm.Unqualified)]
      [XmlArrayItem("CharOption", typeof(CharacterSpeciesSelectedOptionsCharOption), Form=XmlSchemaForm.Unqualified, IsNullable=false)]
      public CharacterSpeciesSelectedOptionsCharOption[] SelectedOptions {
         get {
            return selectedOptionsField;
         }
         set {
            selectedOptionsField = value;
         }
      }
    
      /// <remarks/>
      [XmlArray(Form=XmlSchemaForm.Unqualified)]
      [XmlArrayItem("Key", typeof(Key))]
      public Key[] NonCareerSkills {
         get {
            return nonCareerSkillsField;
         }
         set {
            nonCareerSkillsField = value;
         }
      }
   }
}
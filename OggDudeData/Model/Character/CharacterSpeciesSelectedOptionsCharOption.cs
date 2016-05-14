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
   public class CharacterSpeciesSelectedOptionsCharOption {
    
      private string choiceKeyField;
    
      private string optionKeyField;
    
      private string skillModifiersField;
    
      private string talentModifiersField;
    
      private string dieModifiersField;
    
      private CharacterSpeciesSelectedOptionsCharOptionStartingChars[] startingCharsField;
    
      private CharacterSpeciesSelectedOptionsCharOptionStartingAttribs[] startingAttribsField;
    
      private CharacterSpeciesSelectedOptionsCharOptionStartingSkillTrainingSkillTraining[] startingSkillTrainingField;
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string ChoiceKey {
         get {
            return choiceKeyField;
         }
         set {
            choiceKeyField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string OptionKey {
         get {
            return optionKeyField;
         }
         set {
            optionKeyField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string SkillModifiers {
         get {
            return skillModifiersField;
         }
         set {
            skillModifiersField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string TalentModifiers {
         get {
            return talentModifiersField;
         }
         set {
            talentModifiersField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string DieModifiers {
         get {
            return dieModifiersField;
         }
         set {
            dieModifiersField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement("StartingChars", Form=XmlSchemaForm.Unqualified)]
      public CharacterSpeciesSelectedOptionsCharOptionStartingChars[] StartingChars {
         get {
            return startingCharsField;
         }
         set {
            startingCharsField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement("StartingAttribs", Form=XmlSchemaForm.Unqualified)]
      public CharacterSpeciesSelectedOptionsCharOptionStartingAttribs[] StartingAttribs {
         get {
            return startingAttribsField;
         }
         set {
            startingAttribsField = value;
         }
      }
    
      /// <remarks/>
      [XmlArray(Form=XmlSchemaForm.Unqualified)]
      [XmlArrayItem("SkillTraining", typeof(CharacterSpeciesSelectedOptionsCharOptionStartingSkillTrainingSkillTraining), Form=XmlSchemaForm.Unqualified, IsNullable=false)]
      public CharacterSpeciesSelectedOptionsCharOptionStartingSkillTrainingSkillTraining[] StartingSkillTraining {
         get {
            return startingSkillTrainingField;
         }
         set {
            startingSkillTrainingField = value;
         }
      }
   }
}
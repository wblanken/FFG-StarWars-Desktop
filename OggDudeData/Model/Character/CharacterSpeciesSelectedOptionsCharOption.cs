namespace OggDudeData.Model.Character
{
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class CharacterSpeciesSelectedOptionsCharOption {
    
      private string choiceKeyField;
    
      private string optionKeyField;
    
      private string skillModifiersField;
    
      private string talentModifiersField;
    
      private string dieModifiersField;
    
      private CharacterSpeciesSelectedOptionsCharOptionStartingChars[] startingCharsField;
    
      private CharacterSpeciesSelectedOptionsCharOptionStartingAttribs[] startingAttribsField;
    
      private CharacterSpeciesSelectedOptionsCharOptionStartingSkillTrainingSkillTraining[][] startingSkillTrainingField;
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string ChoiceKey {
         get {
            return this.choiceKeyField;
         }
         set {
            this.choiceKeyField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string OptionKey {
         get {
            return this.optionKeyField;
         }
         set {
            this.optionKeyField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string SkillModifiers {
         get {
            return this.skillModifiersField;
         }
         set {
            this.skillModifiersField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string TalentModifiers {
         get {
            return this.talentModifiersField;
         }
         set {
            this.talentModifiersField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string DieModifiers {
         get {
            return this.dieModifiersField;
         }
         set {
            this.dieModifiersField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("StartingChars", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterSpeciesSelectedOptionsCharOptionStartingChars[] StartingChars {
         get {
            return this.startingCharsField;
         }
         set {
            this.startingCharsField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("StartingAttribs", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterSpeciesSelectedOptionsCharOptionStartingAttribs[] StartingAttribs {
         get {
            return this.startingAttribsField;
         }
         set {
            this.startingAttribsField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      [System.Xml.Serialization.XmlArrayItemAttribute("SkillTraining", typeof(CharacterSpeciesSelectedOptionsCharOptionStartingSkillTrainingSkillTraining), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
      public CharacterSpeciesSelectedOptionsCharOptionStartingSkillTrainingSkillTraining[][] StartingSkillTraining {
         get {
            return this.startingSkillTrainingField;
         }
         set {
            this.startingSkillTrainingField = value;
         }
      }
   }
}
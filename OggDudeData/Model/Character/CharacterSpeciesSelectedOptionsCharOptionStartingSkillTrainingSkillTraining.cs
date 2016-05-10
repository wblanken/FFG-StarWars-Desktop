namespace OggDudeData.Model.Character
{
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class CharacterSpeciesSelectedOptionsCharOptionStartingSkillTrainingSkillTraining {
    
      private string skillCountField;
    
      private Requirement[] requirementField;
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string SkillCount {
         get {
            return this.skillCountField;
         }
         set {
            this.skillCountField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Requirement")]
      public Requirement[] Requirement {
         get {
            return this.requirementField;
         }
         set {
            this.requirementField = value;
         }
      }
   }
}
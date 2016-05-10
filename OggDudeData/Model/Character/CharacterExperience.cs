namespace OggDudeData.Model.Character
{
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class CharacterExperience {
    
      private string usedExperienceField;
    
      private CharacterExperienceExperienceRanks[] experienceRanksField;
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string UsedExperience {
         get {
            return this.usedExperienceField;
         }
         set {
            this.usedExperienceField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ExperienceRanks", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterExperienceExperienceRanks[] ExperienceRanks {
         get {
            return this.experienceRanksField;
         }
         set {
            this.experienceRanksField = value;
         }
      }
   }
}
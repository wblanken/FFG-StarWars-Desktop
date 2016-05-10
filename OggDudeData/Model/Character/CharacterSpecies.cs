namespace OggDudeData.Model.Character
{
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class CharacterSpecies {
    
      private string speciesKeyField;
    
      private string subSpeciesKeyField;
    
      private CharacterSpeciesSelectedOptionsCharOption[][] selectedOptionsField;
    
      private Key[][] nonCareerSkillsField;
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string SpeciesKey {
         get {
            return this.speciesKeyField;
         }
         set {
            this.speciesKeyField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string SubSpeciesKey {
         get {
            return this.subSpeciesKeyField;
         }
         set {
            this.subSpeciesKeyField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      [System.Xml.Serialization.XmlArrayItemAttribute("CharOption", typeof(CharacterSpeciesSelectedOptionsCharOption), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
      public CharacterSpeciesSelectedOptionsCharOption[][] SelectedOptions {
         get {
            return this.selectedOptionsField;
         }
         set {
            this.selectedOptionsField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      [System.Xml.Serialization.XmlArrayItemAttribute("Key", typeof(Key))]
      public Key[][] NonCareerSkills {
         get {
            return this.nonCareerSkillsField;
         }
         set {
            this.nonCareerSkillsField = value;
         }
      }
   }
}
namespace OggDudeData.Model.Character
{
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class CharacterCareer {
    
      private string careerKeyField;
    
      private string startingSpecKeyField;
    
      private Key[][] careerSkillsField;
    
      private Key[][] careerSpecSkillsField;
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string CareerKey {
         get {
            return this.careerKeyField;
         }
         set {
            this.careerKeyField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string StartingSpecKey {
         get {
            return this.startingSpecKeyField;
         }
         set {
            this.startingSpecKeyField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      [System.Xml.Serialization.XmlArrayItemAttribute("Key", typeof(Key))]
      public Key[][] CareerSkills {
         get {
            return this.careerSkillsField;
         }
         set {
            this.careerSkillsField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      [System.Xml.Serialization.XmlArrayItemAttribute("Key", typeof(Key))]
      public Key[][] CareerSpecSkills {
         get {
            return this.careerSpecSkillsField;
         }
         set {
            this.careerSpecSkillsField = value;
         }
      }
   }
}
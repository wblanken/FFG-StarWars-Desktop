namespace OggDudeData.Model.Character
{
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class CharacterSpeciesSelectedOptionsCharOptionStartingChars {
    
      private string brawnField;
    
      private string agilityField;
    
      private string intellectField;
    
      private string cunningField;
    
      private string willpowerField;
    
      private string presenceField;
    
      private Requirement[] requirementField;
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Brawn {
         get {
            return this.brawnField;
         }
         set {
            this.brawnField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Agility {
         get {
            return this.agilityField;
         }
         set {
            this.agilityField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Intellect {
         get {
            return this.intellectField;
         }
         set {
            this.intellectField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Cunning {
         get {
            return this.cunningField;
         }
         set {
            this.cunningField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Willpower {
         get {
            return this.willpowerField;
         }
         set {
            this.willpowerField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Presence {
         get {
            return this.presenceField;
         }
         set {
            this.presenceField = value;
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
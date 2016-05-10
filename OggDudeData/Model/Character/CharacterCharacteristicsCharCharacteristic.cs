namespace OggDudeData.Model.Character
{
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class CharacterCharacteristicsCharCharacteristic {
    
      private string keyField;
    
      private string nameField;
    
      private string descriptionField;
    
      private string sourceField;
    
      private string sourcesField;
    
      private string customField;
    
      private Rank[] rankField;
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Key {
         get {
            return this.keyField;
         }
         set {
            this.keyField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Name {
         get {
            return this.nameField;
         }
         set {
            this.nameField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Description {
         get {
            return this.descriptionField;
         }
         set {
            this.descriptionField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Source {
         get {
            return this.sourceField;
         }
         set {
            this.sourceField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Sources {
         get {
            return this.sourcesField;
         }
         set {
            this.sourcesField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Custom {
         get {
            return this.customField;
         }
         set {
            this.customField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Rank")]
      public Rank[] Rank {
         get {
            return this.rankField;
         }
         set {
            this.rankField = value;
         }
      }
   }
}
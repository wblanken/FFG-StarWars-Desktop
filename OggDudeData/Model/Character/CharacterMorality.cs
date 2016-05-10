namespace OggDudeData.Model.Character
{
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class CharacterMorality {
    
      private string moralityPairsField;
    
      private string modifiedMoralityField;
    
      private string moralityValueField;
    
      private CharacterMoralityOptions[] optionsField;
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string MoralityPairs {
         get {
            return this.moralityPairsField;
         }
         set {
            this.moralityPairsField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string ModifiedMorality {
         get {
            return this.modifiedMoralityField;
         }
         set {
            this.modifiedMoralityField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string MoralityValue {
         get {
            return this.moralityValueField;
         }
         set {
            this.moralityValueField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Options", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterMoralityOptions[] Options {
         get {
            return this.optionsField;
         }
         set {
            this.optionsField = value;
         }
      }
   }
}
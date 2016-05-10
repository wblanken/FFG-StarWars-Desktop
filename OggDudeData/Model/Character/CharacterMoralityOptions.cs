namespace OggDudeData.Model.Character
{
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class CharacterMoralityOptions {
    
      private string optionField;
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Option {
         get {
            return this.optionField;
         }
         set {
            this.optionField = value;
         }
      }
   }
}
namespace OggDudeData.Model.Character
{
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class CharacterAttitude {
    
      private string attitudeKeyField;
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string AttitudeKey {
         get {
            return this.attitudeKeyField;
         }
         set {
            this.attitudeKeyField = value;
         }
      }
   }
}
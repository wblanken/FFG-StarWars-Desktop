namespace OggDudeData.Model.Character
{
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
   public partial class NewDataSet {
    
      private object[] itemsField;
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Character", typeof(Character))]
      [System.Xml.Serialization.XmlElementAttribute("Key", typeof(Key), IsNullable=true)]
      [System.Xml.Serialization.XmlElementAttribute("Rank", typeof(Rank))]
      [System.Xml.Serialization.XmlElementAttribute("Requirement", typeof(Requirement))]
      public object[] Items {
         get {
            return this.itemsField;
         }
         set {
            this.itemsField = value;
         }
      }
   }
}
namespace OggDudeData.Model.Character
{
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
   public partial class Key {
    
      private string valueField;
    
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public string Value {
         get {
            return this.valueField;
         }
         set {
            this.valueField = value;
         }
      }
   }
}
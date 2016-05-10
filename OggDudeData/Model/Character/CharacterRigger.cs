namespace OggDudeData.Model.Character
{
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class CharacterRigger {
    
      private string vehicleKeyField;
    
      private string weaponIndexField;
    
      private string maxSilhouetteField;
    
      private CharacterRiggerCustRigger[] custRiggerField;
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string VehicleKey {
         get {
            return this.vehicleKeyField;
         }
         set {
            this.vehicleKeyField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string WeaponIndex {
         get {
            return this.weaponIndexField;
         }
         set {
            this.weaponIndexField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string MaxSilhouette {
         get {
            return this.maxSilhouetteField;
         }
         set {
            this.maxSilhouetteField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("custRigger", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterRiggerCustRigger[] custRigger {
         get {
            return this.custRiggerField;
         }
         set {
            this.custRiggerField = value;
         }
      }
   }
}
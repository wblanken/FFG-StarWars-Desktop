using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace OggDudeData.Model.Character
{
   /// <remarks/>
   [GeneratedCode("xsd", "4.6.1055.0")]
   [Serializable]
   [DebuggerStepThrough]
   [DesignerCategory("code")]
   [XmlType(AnonymousType=true)]
   public class CharacterRigger {
    
      private string vehicleKeyField;
    
      private string weaponIndexField;
    
      private string maxSilhouetteField;
    
      private CharacterRiggerCustRigger[] custRiggerField;
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string VehicleKey {
         get {
            return vehicleKeyField;
         }
         set {
            vehicleKeyField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string WeaponIndex {
         get {
            return weaponIndexField;
         }
         set {
            weaponIndexField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string MaxSilhouette {
         get {
            return maxSilhouetteField;
         }
         set {
            maxSilhouetteField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement("custRigger", Form=XmlSchemaForm.Unqualified)]
      public CharacterRiggerCustRigger[] custRigger {
         get {
            return custRiggerField;
         }
         set {
            custRiggerField = value;
         }
      }
   }
}
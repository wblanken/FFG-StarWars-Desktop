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
   public class CharacterRiggerCustRigger {
    
      private string chooseVehicleField;
    
      private string silhouetteBaseField;
    
      private string silhouetteAddField;
    
      private string baseModsField;
    
      private string chooseWeaponField;
    
      private string weaponModsField;
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string ChooseVehicle {
         get {
            return chooseVehicleField;
         }
         set {
            chooseVehicleField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string SilhouetteBase {
         get {
            return silhouetteBaseField;
         }
         set {
            silhouetteBaseField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string SilhouetteAdd {
         get {
            return silhouetteAddField;
         }
         set {
            silhouetteAddField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string BaseMods {
         get {
            return baseModsField;
         }
         set {
            baseModsField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string ChooseWeapon {
         get {
            return chooseWeaponField;
         }
         set {
            chooseWeaponField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string WeaponMods {
         get {
            return weaponModsField;
         }
         set {
            weaponModsField = value;
         }
      }
   }
}
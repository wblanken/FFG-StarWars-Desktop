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
   public class CharacterAttributes {
    
      private CharacterAttributesSoakValue[] soakValueField;
    
      private CharacterAttributesWoundThreshold[] woundThresholdField;
    
      private CharacterAttributesStrainThreshold[] strainThresholdField;
    
      private CharacterAttributesDefenseRanged[] defenseRangedField;
    
      private CharacterAttributesDefenseMelee[] defenseMeleeField;
    
      private CharacterAttributesForceRating[] forceRatingField;
    
      /// <remarks/>
      [XmlElement("SoakValue", Form=XmlSchemaForm.Unqualified)]
      public CharacterAttributesSoakValue[] SoakValue {
         get {
            return soakValueField;
         }
         set {
            soakValueField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement("WoundThreshold", Form=XmlSchemaForm.Unqualified)]
      public CharacterAttributesWoundThreshold[] WoundThreshold {
         get {
            return woundThresholdField;
         }
         set {
            woundThresholdField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement("StrainThreshold", Form=XmlSchemaForm.Unqualified)]
      public CharacterAttributesStrainThreshold[] StrainThreshold {
         get {
            return strainThresholdField;
         }
         set {
            strainThresholdField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement("DefenseRanged", Form=XmlSchemaForm.Unqualified)]
      public CharacterAttributesDefenseRanged[] DefenseRanged {
         get {
            return defenseRangedField;
         }
         set {
            defenseRangedField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement("DefenseMelee", Form=XmlSchemaForm.Unqualified)]
      public CharacterAttributesDefenseMelee[] DefenseMelee {
         get {
            return defenseMeleeField;
         }
         set {
            defenseMeleeField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement("ForceRating", Form=XmlSchemaForm.Unqualified)]
      public CharacterAttributesForceRating[] ForceRating {
         get {
            return forceRatingField;
         }
         set {
            forceRatingField = value;
         }
      }
   }
}
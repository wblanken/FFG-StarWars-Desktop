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
   public class CharacterSpeciesSelectedOptionsCharOptionStartingAttribs {
    
      private string woundThresholdField;
    
      private string strainThresholdField;
    
      private string defenseRangedField;
    
      private string defenseMeleeField;
    
      private string soakValueField;
    
      private string experienceField;
    
      private string forceRatingField;
    
      private Requirement[] requirementField;
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string WoundThreshold {
         get {
            return woundThresholdField;
         }
         set {
            woundThresholdField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string StrainThreshold {
         get {
            return strainThresholdField;
         }
         set {
            strainThresholdField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string DefenseRanged {
         get {
            return defenseRangedField;
         }
         set {
            defenseRangedField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string DefenseMelee {
         get {
            return defenseMeleeField;
         }
         set {
            defenseMeleeField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string SoakValue {
         get {
            return soakValueField;
         }
         set {
            soakValueField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Experience {
         get {
            return experienceField;
         }
         set {
            experienceField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string ForceRating {
         get {
            return forceRatingField;
         }
         set {
            forceRatingField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement("Requirement")]
      public Requirement[] Requirement {
         get {
            return requirementField;
         }
         set {
            requirementField = value;
         }
      }
   }
}
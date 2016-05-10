namespace OggDudeData.Model.Character
{
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class CharacterAttributes {
    
      private CharacterAttributesSoakValue[] soakValueField;
    
      private CharacterAttributesWoundThreshold[] woundThresholdField;
    
      private CharacterAttributesStrainThreshold[] strainThresholdField;
    
      private CharacterAttributesDefenseRanged[] defenseRangedField;
    
      private CharacterAttributesDefenseMelee[] defenseMeleeField;
    
      private CharacterAttributesForceRating[] forceRatingField;
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("SoakValue", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterAttributesSoakValue[] SoakValue {
         get {
            return this.soakValueField;
         }
         set {
            this.soakValueField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("WoundThreshold", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterAttributesWoundThreshold[] WoundThreshold {
         get {
            return this.woundThresholdField;
         }
         set {
            this.woundThresholdField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("StrainThreshold", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterAttributesStrainThreshold[] StrainThreshold {
         get {
            return this.strainThresholdField;
         }
         set {
            this.strainThresholdField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("DefenseRanged", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterAttributesDefenseRanged[] DefenseRanged {
         get {
            return this.defenseRangedField;
         }
         set {
            this.defenseRangedField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("DefenseMelee", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterAttributesDefenseMelee[] DefenseMelee {
         get {
            return this.defenseMeleeField;
         }
         set {
            this.defenseMeleeField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ForceRating", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterAttributesForceRating[] ForceRating {
         get {
            return this.forceRatingField;
         }
         set {
            this.forceRatingField = value;
         }
      }
   }
}
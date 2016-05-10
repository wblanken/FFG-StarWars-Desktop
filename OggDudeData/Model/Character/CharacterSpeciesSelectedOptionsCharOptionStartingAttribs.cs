namespace OggDudeData.Model.Character
{
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class CharacterSpeciesSelectedOptionsCharOptionStartingAttribs {
    
      private string woundThresholdField;
    
      private string strainThresholdField;
    
      private string defenseRangedField;
    
      private string defenseMeleeField;
    
      private string soakValueField;
    
      private string experienceField;
    
      private string forceRatingField;
    
      private Requirement[] requirementField;
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string WoundThreshold {
         get {
            return this.woundThresholdField;
         }
         set {
            this.woundThresholdField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string StrainThreshold {
         get {
            return this.strainThresholdField;
         }
         set {
            this.strainThresholdField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string DefenseRanged {
         get {
            return this.defenseRangedField;
         }
         set {
            this.defenseRangedField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string DefenseMelee {
         get {
            return this.defenseMeleeField;
         }
         set {
            this.defenseMeleeField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string SoakValue {
         get {
            return this.soakValueField;
         }
         set {
            this.soakValueField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Experience {
         get {
            return this.experienceField;
         }
         set {
            this.experienceField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string ForceRating {
         get {
            return this.forceRatingField;
         }
         set {
            this.forceRatingField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Requirement")]
      public Requirement[] Requirement {
         get {
            return this.requirementField;
         }
         set {
            this.requirementField = value;
         }
      }
   }
}
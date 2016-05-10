namespace OggDudeData.Model.Character
{
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class CharacterSummaryPriorities {
    
      private string talentPrioritiesField;
    
      private string forcePrioritiesField;
    
      private string obligPrioritiesField;
    
      private string dutyPrioritiesField;
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string TalentPriorities {
         get {
            return this.talentPrioritiesField;
         }
         set {
            this.talentPrioritiesField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string ForcePriorities {
         get {
            return this.forcePrioritiesField;
         }
         set {
            this.forcePrioritiesField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string ObligPriorities {
         get {
            return this.obligPrioritiesField;
         }
         set {
            this.obligPrioritiesField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string DutyPriorities {
         get {
            return this.dutyPrioritiesField;
         }
         set {
            this.dutyPrioritiesField = value;
         }
      }
   }
}
namespace OggDudeData.Model.Character
{
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
   public partial class Character {
    
      private string lastChangedField;
    
      private string notPersistedField;
    
      private string fileNameField;
    
      private string nameField;
    
      private string keyField;
    
      private string forcePowersField;
    
      private string sigAbilitiesField;
    
      private string dutiesField;
    
      private string vehiclesField;
    
      private string storyField;
    
      private string creditsField;
    
      private string useGrantsField;
    
      private string portraitField;
    
      private string autoRecalcField;
    
      private CharacterDescription[] descriptionField;
    
      private CharacterCharacteristicsCharCharacteristic[][] characteristicsField;
    
      private CharacterMotivationsCharMotivation[][] motivationsField;
    
      private CharacterSpecializationsCharSpecialization[][] specializationsField;
    
      private CharacterSkillsCharSkill[][] skillsField;
    
      private CharacterObOptions[] obOptionsField;
    
      private CharacterObligationsCharObligation[][] obligationsField;
    
      private CharacterDutOptions[] dutOptionsField;
    
      private CharacterExperience[] experienceField;
    
      private CharacterAttributes[] attributesField;
    
      private CharacterSpecies[] speciesField;
    
      private CharacterCareer[] careerField;
    
      private CharacterClass[] classField;
    
      private CharacterHook[] hookField;
    
      private CharacterAttitude[] attitudeField;
    
      private CharacterWeaponsCharWeapon[][] weaponsField;
    
      private CharacterArmorCharArmor[][] armorField;
    
      private CharacterGearCharGear[][] gearField;
    
      private CharacterSummaryPriorities[] summaryPrioritiesField;
    
      private CharacterMorality[] moralityField;
    
      private CharacterGrants[] grantsField;
    
      private CharacterRigger[] riggerField;
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string LastChanged {
         get {
            return this.lastChangedField;
         }
         set {
            this.lastChangedField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string NotPersisted {
         get {
            return this.notPersistedField;
         }
         set {
            this.notPersistedField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string FileName {
         get {
            return this.fileNameField;
         }
         set {
            this.fileNameField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Name {
         get {
            return this.nameField;
         }
         set {
            this.nameField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Key {
         get {
            return this.keyField;
         }
         set {
            this.keyField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string ForcePowers {
         get {
            return this.forcePowersField;
         }
         set {
            this.forcePowersField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string SigAbilities {
         get {
            return this.sigAbilitiesField;
         }
         set {
            this.sigAbilitiesField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Duties {
         get {
            return this.dutiesField;
         }
         set {
            this.dutiesField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Vehicles {
         get {
            return this.vehiclesField;
         }
         set {
            this.vehiclesField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Story {
         get {
            return this.storyField;
         }
         set {
            this.storyField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Credits {
         get {
            return this.creditsField;
         }
         set {
            this.creditsField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string UseGrants {
         get {
            return this.useGrantsField;
         }
         set {
            this.useGrantsField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Portrait {
         get {
            return this.portraitField;
         }
         set {
            this.portraitField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string AutoRecalc {
         get {
            return this.autoRecalcField;
         }
         set {
            this.autoRecalcField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Description", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterDescription[] Description {
         get {
            return this.descriptionField;
         }
         set {
            this.descriptionField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      [System.Xml.Serialization.XmlArrayItemAttribute("CharCharacteristic", typeof(CharacterCharacteristicsCharCharacteristic), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
      public CharacterCharacteristicsCharCharacteristic[][] Characteristics {
         get {
            return this.characteristicsField;
         }
         set {
            this.characteristicsField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      [System.Xml.Serialization.XmlArrayItemAttribute("CharMotivation", typeof(CharacterMotivationsCharMotivation), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
      public CharacterMotivationsCharMotivation[][] Motivations {
         get {
            return this.motivationsField;
         }
         set {
            this.motivationsField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      [System.Xml.Serialization.XmlArrayItemAttribute("CharSpecialization", typeof(CharacterSpecializationsCharSpecialization), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
      public CharacterSpecializationsCharSpecialization[][] Specializations {
         get {
            return this.specializationsField;
         }
         set {
            this.specializationsField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      [System.Xml.Serialization.XmlArrayItemAttribute("CharSkill", typeof(CharacterSkillsCharSkill), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
      public CharacterSkillsCharSkill[][] Skills {
         get {
            return this.skillsField;
         }
         set {
            this.skillsField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ObOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterObOptions[] ObOptions {
         get {
            return this.obOptionsField;
         }
         set {
            this.obOptionsField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      [System.Xml.Serialization.XmlArrayItemAttribute("CharObligation", typeof(CharacterObligationsCharObligation), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
      public CharacterObligationsCharObligation[][] Obligations {
         get {
            return this.obligationsField;
         }
         set {
            this.obligationsField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("DutOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterDutOptions[] DutOptions {
         get {
            return this.dutOptionsField;
         }
         set {
            this.dutOptionsField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Experience", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterExperience[] Experience {
         get {
            return this.experienceField;
         }
         set {
            this.experienceField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Attributes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterAttributes[] Attributes {
         get {
            return this.attributesField;
         }
         set {
            this.attributesField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Species", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterSpecies[] Species {
         get {
            return this.speciesField;
         }
         set {
            this.speciesField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Career", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterCareer[] Career {
         get {
            return this.careerField;
         }
         set {
            this.careerField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Class", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterClass[] Class {
         get {
            return this.classField;
         }
         set {
            this.classField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Hook", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterHook[] Hook {
         get {
            return this.hookField;
         }
         set {
            this.hookField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Attitude", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterAttitude[] Attitude {
         get {
            return this.attitudeField;
         }
         set {
            this.attitudeField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      [System.Xml.Serialization.XmlArrayItemAttribute("CharWeapon", typeof(CharacterWeaponsCharWeapon), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
      public CharacterWeaponsCharWeapon[][] Weapons {
         get {
            return this.weaponsField;
         }
         set {
            this.weaponsField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      [System.Xml.Serialization.XmlArrayItemAttribute("CharArmor", typeof(CharacterArmorCharArmor), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
      public CharacterArmorCharArmor[][] Armor {
         get {
            return this.armorField;
         }
         set {
            this.armorField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      [System.Xml.Serialization.XmlArrayItemAttribute("CharGear", typeof(CharacterGearCharGear), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
      public CharacterGearCharGear[][] Gear {
         get {
            return this.gearField;
         }
         set {
            this.gearField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("SummaryPriorities", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterSummaryPriorities[] SummaryPriorities {
         get {
            return this.summaryPrioritiesField;
         }
         set {
            this.summaryPrioritiesField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Morality", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterMorality[] Morality {
         get {
            return this.moralityField;
         }
         set {
            this.moralityField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Grants", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterGrants[] Grants {
         get {
            return this.grantsField;
         }
         set {
            this.grantsField = value;
         }
      }
    
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Rigger", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public CharacterRigger[] Rigger {
         get {
            return this.riggerField;
         }
         set {
            this.riggerField = value;
         }
      }
   }
}
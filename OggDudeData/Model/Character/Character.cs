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
   [XmlType(AnonymousType = true)]
   [XmlRoot(Namespace = "", IsNullable = false)]
   public class Character
   {
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

      private CharacterCharacteristicsCharCharacteristic[] characteristicsField;

      private CharacterMotivationsCharMotivation[] motivationsField;

      private CharacterSpecializationsCharSpecialization[] specializationsField;

      private CharacterSkillsCharSkill[] skillsField;

      private CharacterObOptions[] obOptionsField;

      private CharacterObligationsCharObligation[] obligationsField;

      private CharacterDutOptions[] dutOptionsField;

      private CharacterExperience[] experienceField;

      private CharacterAttributes[] attributesField;

      private CharacterSpecies[] speciesField;

      private CharacterCareer[] careerField;

      private CharacterClass[] classField;

      private CharacterHook[] hookField;

      private CharacterAttitude[] attitudeField;

      private CharacterWeaponsCharWeapon[] weaponsField;

      private CharacterArmorCharArmor[] armorField;

      private CharacterGearCharGear[] gearField;

      private CharacterSummaryPriorities[] summaryPrioritiesField;

      private CharacterMorality[] moralityField;

      private CharacterGrants[] grantsField;

      private CharacterRigger[] riggerField;

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string LastChanged
      {
         get { return lastChangedField; }
         set { lastChangedField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string NotPersisted
      {
         get { return notPersistedField; }
         set { notPersistedField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string FileName
      {
         get { return fileNameField; }
         set { fileNameField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string Name
      {
         get { return nameField; }
         set { nameField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string Key
      {
         get { return keyField; }
         set { keyField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string ForcePowers
      {
         get { return forcePowersField; }
         set { forcePowersField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string SigAbilities
      {
         get { return sigAbilitiesField; }
         set { sigAbilitiesField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string Duties
      {
         get { return dutiesField; }
         set { dutiesField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string Vehicles
      {
         get { return vehiclesField; }
         set { vehiclesField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string Story
      {
         get { return storyField; }
         set { storyField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string Credits
      {
         get { return creditsField; }
         set { creditsField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string UseGrants
      {
         get { return useGrantsField; }
         set { useGrantsField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string Portrait
      {
         get { return portraitField; }
         set { portraitField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string AutoRecalc
      {
         get { return autoRecalcField; }
         set { autoRecalcField = value; }
      }

      /// <remarks/>
      [XmlElement("Description", Form = XmlSchemaForm.Unqualified)]
      public CharacterDescription[] Description
      {
         get { return descriptionField; }
         set { descriptionField = value; }
      }

      /// <remarks/>
      [XmlArray(Form = XmlSchemaForm.Unqualified)]
      [XmlArrayItem("CharCharacteristic", typeof(CharacterCharacteristicsCharCharacteristic),
         Form = XmlSchemaForm.Unqualified, IsNullable = false)]
      public CharacterCharacteristicsCharCharacteristic[] Characteristics
      {
         get { return CharacteristicsField; }
         set { CharacteristicsField = value; }
      }

      /// <remarks/>
      [XmlArray(Form = XmlSchemaForm.Unqualified)]
      [XmlArrayItem("CharMotivation", typeof(CharacterMotivationsCharMotivation), Form = XmlSchemaForm.Unqualified,
         IsNullable = false)]
      public CharacterMotivationsCharMotivation[] Motivations
      {
         get { return motivationsField; }
         set { motivationsField = value; }
      }

      /// <remarks/>
      [XmlArray(Form = XmlSchemaForm.Unqualified)]
      [XmlArrayItem("CharSpecialization", typeof(CharacterSpecializationsCharSpecialization),
         Form = XmlSchemaForm.Unqualified, IsNullable = false)]
      public CharacterSpecializationsCharSpecialization[] Specializations
      {
         get { return SpecializationsField; }
         set { SpecializationsField = value; }
      }

      /// <remarks/>
      [XmlArray(Form = XmlSchemaForm.Unqualified)]
      [XmlArrayItem("CharSkill", typeof(CharacterSkillsCharSkill), Form = XmlSchemaForm.Unqualified, IsNullable = false)
      ]
      public CharacterSkillsCharSkill[] Skills
      {
         get { return skillsField; }
         set { skillsField = value; }
      }

      /// <remarks/>
      [XmlElement("ObOptions", Form = XmlSchemaForm.Unqualified)]
      public CharacterObOptions[] ObOptions
      {
         get { return obOptionsField; }
         set { obOptionsField = value; }
      }

      /// <remarks/>
      [XmlArray(Form = XmlSchemaForm.Unqualified)]
      [XmlArrayItem("CharObligation", typeof(CharacterObligationsCharObligation), Form = XmlSchemaForm.Unqualified,
         IsNullable = false)]
      public CharacterObligationsCharObligation[] Obligations
      {
         get { return obligationsField; }
         set { obligationsField = value; }
      }

      /// <remarks/>
      [XmlElement("DutOptions", Form = XmlSchemaForm.Unqualified)]
      public CharacterDutOptions[] DutOptions
      {
         get { return dutOptionsField; }
         set { dutOptionsField = value; }
      }

      /// <remarks/>
      [XmlElement("Experience", Form = XmlSchemaForm.Unqualified)]
      public CharacterExperience[] Experience
      {
         get { return experienceField; }
         set { experienceField = value; }
      }

      /// <remarks/>
      [XmlElement("Attributes", Form = XmlSchemaForm.Unqualified)]
      public CharacterAttributes[] Attributes
      {
         get { return attributesField; }
         set { attributesField = value; }
      }

      /// <remarks/>
      [XmlElement("Species", Form = XmlSchemaForm.Unqualified)]
      public CharacterSpecies[] Species
      {
         get { return speciesField; }
         set { speciesField = value; }
      }

      /// <remarks/>
      [XmlElement("Career", Form = XmlSchemaForm.Unqualified)]
      public CharacterCareer[] Career
      {
         get { return careerField; }
         set { careerField = value; }
      }

      /// <remarks/>
      [XmlElement("Class", Form = XmlSchemaForm.Unqualified)]
      public CharacterClass[] Class
      {
         get { return classField; }
         set { classField = value; }
      }

      /// <remarks/>
      [XmlElement("Hook", Form = XmlSchemaForm.Unqualified)]
      public CharacterHook[] Hook
      {
         get { return hookField; }
         set { hookField = value; }
      }

      /// <remarks/>
      [XmlElement("Attitude", Form = XmlSchemaForm.Unqualified)]
      public CharacterAttitude[] Attitude
      {
         get { return attitudeField; }
         set { attitudeField = value; }
      }

      /// <remarks/>
      [XmlArray(Form = XmlSchemaForm.Unqualified)]
      [XmlArrayItem("CharWeapon", typeof(CharacterWeaponsCharWeapon), Form = XmlSchemaForm.Unqualified,
         IsNullable = false)]
      public CharacterWeaponsCharWeapon[] Weapons
      {
         get { return weaponsField; }
         set { weaponsField = value; }
      }

      /// <remarks/>
      [XmlArray(Form = XmlSchemaForm.Unqualified)]
      [XmlArrayItem("CharArmor", typeof(CharacterArmorCharArmor), Form = XmlSchemaForm.Unqualified, IsNullable = false)]
      public CharacterArmorCharArmor[] Armor
      {
         get { return armorField; }
         set { armorField = value; }
      }

      /// <remarks/>
      [XmlArray(Form = XmlSchemaForm.Unqualified)]
      [XmlArrayItem("CharGear", typeof(CharacterGearCharGear), Form = XmlSchemaForm.Unqualified, IsNullable = false)]
      public CharacterGearCharGear[] Gear
      {
         get { return gearField; }
         set { gearField = value; }
      }

      /// <remarks/>
      [XmlElement("SummaryPriorities", Form = XmlSchemaForm.Unqualified)]
      public CharacterSummaryPriorities[] SummaryPriorities
      {
         get { return summaryPrioritiesField; }
         set { summaryPrioritiesField = value; }
      }

      /// <remarks/>
      [XmlElement("Morality", Form = XmlSchemaForm.Unqualified)]
      public CharacterMorality[] Morality
      {
         get { return moralityField; }
         set { moralityField = value; }
      }

      /// <remarks/>
      [XmlElement("Grants", Form = XmlSchemaForm.Unqualified)]
      public CharacterGrants[] Grants
      {
         get { return grantsField; }
         set { grantsField = value; }
      }

      /// <remarks/>
      [XmlElement("Rigger", Form = XmlSchemaForm.Unqualified)]
      public CharacterRigger[] Rigger
      {
         get { return riggerField; }
         set { riggerField = value; }
      }

      public CharacterSpecializationsCharSpecialization[] SpecializationsField
      {
         get
         {
            return specializationsField;
         }

         set
         {
            specializationsField = value;
         }
      }

      public CharacterCharacteristicsCharCharacteristic[] CharacteristicsField
      {
         get
         {
            return characteristicsField;
         }

         set
         {
            characteristicsField = value;
         }
      }
   }
}
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
   public class CharacterDescription
   {
      private string charNameField;

      private string playerNameField;

      private string genderValueField;

      private string ageField;

      private string heightField;

      private string buildField;

      private string hairField;

      private string eyesField;

      private string otherFeaturesField;

      private string campaignField;

      private string genderField;

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string CharName
      {
         get { return charNameField; }
         set { charNameField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string PlayerName
      {
         get { return playerNameField; }
         set { playerNameField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string GenderValue
      {
         get { return genderValueField; }
         set { genderValueField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string Age
      {
         get { return ageField; }
         set { ageField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string Height
      {
         get { return heightField; }
         set { heightField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string Build
      {
         get { return buildField; }
         set { buildField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string Hair
      {
         get { return hairField; }
         set { hairField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string Eyes
      {
         get { return eyesField; }
         set { eyesField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string OtherFeatures
      {
         get { return otherFeaturesField; }
         set { otherFeaturesField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string Campaign
      {
         get { return campaignField; }
         set { campaignField = value; }
      }

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string Gender
      {
         get { return genderField; }
         set { genderField = value; }
      }
   }
}
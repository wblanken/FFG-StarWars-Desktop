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
   public class CharacterClass
   {
      private string classKeyField;

      /// <remarks/>
      [XmlElement(Form = XmlSchemaForm.Unqualified)]
      public string ClassKey
      {
         get { return classKeyField; }
         set { classKeyField = value; }
      }
   }
}
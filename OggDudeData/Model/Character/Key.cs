using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OggDudeData.Model.Character
{
   /// <remarks/>
   [GeneratedCode("xsd", "4.6.1055.0")]
   [Serializable]
   [DebuggerStepThrough]
   [DesignerCategory("code")]
   [XmlType(AnonymousType = true)]
   [XmlRoot(Namespace = "", IsNullable = true)]
   public class Key
   {
      private string valueField;

      /// <remarks/>
      [XmlText]
      public string Value
      {
         get { return valueField; }
         set { valueField = value; }
      }
   }
}
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
   [XmlType(AnonymousType=true)]
   [XmlRoot(Namespace="", IsNullable=false)]
   public class NewDataSet {
    
      private object[] itemsField;
    
      /// <remarks/>
      [XmlElement("Character", typeof(Character))]
      [XmlElement("Key", typeof(Key), IsNullable=true)]
      [XmlElement("Rank", typeof(Rank))]
      [XmlElement("Requirement", typeof(Requirement))]
      public object[] Items {
         get {
            return itemsField;
         }
         set {
            itemsField = value;
         }
      }
   }
}
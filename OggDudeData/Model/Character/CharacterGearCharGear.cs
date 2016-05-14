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
   public class CharacterGearCharGear {
    
      private string itemKeyField;
    
      private string keyField;
    
      private string equippedField;
    
      private string heldField;
    
      private string countField;
    
      private string purchasedAttachmentsField;
    
      private string addlHPField;
    
      private string notesField;
    
      private string renameField;
    
      private string prioritizeField;
    
      private string hPPerItemField;
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string ItemKey {
         get {
            return itemKeyField;
         }
         set {
            itemKeyField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Key {
         get {
            return keyField;
         }
         set {
            keyField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Equipped {
         get {
            return equippedField;
         }
         set {
            equippedField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Held {
         get {
            return heldField;
         }
         set {
            heldField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Count {
         get {
            return countField;
         }
         set {
            countField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string PurchasedAttachments {
         get {
            return purchasedAttachmentsField;
         }
         set {
            purchasedAttachmentsField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string AddlHP {
         get {
            return addlHPField;
         }
         set {
            addlHPField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Notes {
         get {
            return notesField;
         }
         set {
            notesField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Rename {
         get {
            return renameField;
         }
         set {
            renameField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string Prioritize {
         get {
            return prioritizeField;
         }
         set {
            prioritizeField = value;
         }
      }
    
      /// <remarks/>
      [XmlElement(Form=XmlSchemaForm.Unqualified)]
      public string HPPerItem {
         get {
            return hPPerItemField;
         }
         set {
            hPPerItemField = value;
         }
      }
   }
}
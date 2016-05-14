// Copyright (c) 2016 Will Blankenship, Inc.  All Rights Reserved.

using System.IO;
using System.Xml.Serialization;
using OggDudeData.Model;

namespace OggDudeData
{
   public static class ImportData
   {
      public static Character LoadCharacter(string filePath)
      {
         var serializer = new XmlSerializer(typeof(Character));
         using (var file = new FileStream(filePath, FileMode.Open,
               FileAccess.Read))
         {
            var character = (Character)serializer.Deserialize(file);
            return character;
         }
      }

      public static void WriteCharacter(Character chracter)
      {
         var serializer = new XmlSerializer(typeof(Character));
      }
   }
}
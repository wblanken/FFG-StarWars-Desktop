// Copyright (c) 2016 Will Blankenship, Inc.  All Rights Reserved.

using System.IO;
using System.Xml.Serialization;
using OggDudeData.Model;

namespace OggDudeData
{
   public static class ImportData
   {
      private const string AppDataPath =
         @"C:\Users\Will\AppData\Local\Apps\2.0\O0VVP9N3.2VV\PZY921LQ.5Q2\swch..tion_0000000000000000_0001.0006_e7f2ca33d94ec618\Data\";

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

      /*public static void WriteCharacter(Character chracter)
      {
         var serializer = new XmlSerializer(typeof(Character));
      }*/

      public static Skills LoadSkills()
      {
         var serializer = new XmlSerializer(typeof(Skills));
         using (var file = new FileStream($"{AppDataPath}Skills.xml", FileMode.Open, FileAccess.Read))
         {
            var skills = (Skills) serializer.Deserialize(file);
            return skills;
         }
      }

      public static Characteristics LoadCharacteristics()
      {
         var serializer = new XmlSerializer(typeof(Characteristics));
         using (var file =
            new FileStream($"{AppDataPath}Characteristics.xml", FileMode.Open, FileAccess.Read))
         {
            var characteristics = (Characteristics) serializer.Deserialize(file);
            return characteristics;
         }
      }
   }
}
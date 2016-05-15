// Copyright (c) 2016 Will Blankenship, Inc.  All Rights Reserved.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Xml.Linq;
using OggDudeData.Model;

namespace OggDudeData
{
   public static class ImportData
   {
      public static string AppDataPath { get; set; }
      public static string DataPath { get; set; }

      public static Character LoadCharacter(string filePath)
      {
         var serializer = new XmlSerializer(typeof(Character));
         using (var file = new FileStream(filePath, FileMode.Open,
               FileAccess.Read))
         {
            /*var position = 8192;
            file.Seek(position, SeekOrigin.Begin);
            var test = new Byte[file.Length - position];
            file.Read(test, 0, (int)file.Length - position);

            var s = System.Text.Encoding.UTF8.GetString(test);*/

            var character = (Character)serializer.Deserialize(file);
            return character;
         }
      }

      public static IList<Character> LoadCharacters(string campaign)
      {
         var characters = new List<Character>();

         foreach (var file in Directory.EnumerateFiles($"{DataPath}Characters", "*.xml"))
         {
            var character = LoadCharacter(file);
            if (campaign == null)
            {
               characters.Add(character);
            }
            else
            {
               if (character.Description.Campaign == campaign)
               {
                  characters.Add(character);
               }
            }
         }

         

         return characters;
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

      public static string LoadSpeciesFromTag(string speciesTag)
      {
         foreach (var file in Directory.EnumerateFiles($"{AppDataPath}Species\\", $"{speciesTag[0]}*.xml"))
         {
            var doc = XDocument.Load(file);
            if (doc.Root.Descendants("Key").First().Value == speciesTag)
            {
               return doc.Root.Descendants("Name").First().Value;
            }
         }
         return string.Empty;
      }

      public static string LoadCareerFromTag(string careerTag)
      {
         foreach (var file in Directory.EnumerateFiles($"{AppDataPath}Careers\\", $"{careerTag[0]}*.xml"))
         {
            var doc = XDocument.Load(file);
            if (doc.Root.Descendants("Key").First().Value == careerTag)
            {
               return doc.Root.Descendants("Name").First().Value;
            }
         }
         return string.Empty;
      }
   }
}
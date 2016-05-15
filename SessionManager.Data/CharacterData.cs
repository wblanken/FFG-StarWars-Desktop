// Copyright (c) 2016 Will Blankenship, Inc.  All Rights Reserved.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using SessionManager.Data.Model;

namespace SessionManager.Data
{
   public class CharacterData : ICharacterData
   {
      public Character GetCharacter(string characterFile, string appFolder)
      {
         var doc = XDocument.Load(characterFile);
         var character = new Character
         {
            Name = doc.Descendants("CharName").First().Value,
            PlayerName = doc.Descendants("PlayerName").First().Value,
            Gender = doc.Descendants("GenderValue").First().Value,
            Career = LoadCareerFromTag(doc.Root.Element("Career").Elements("CareerKey").First().Value, appFolder),
            Specializations = string.Join(",",
               doc.Root.Elements("Specializations")
                  .Elements("CharSpecialization")
                  .Select(s => s.Element("Name").Value)
                  .ToList()),
            Species = LoadSpeciesFromTag(doc.Root.Elements("Species").Elements("SpeciesKey").First().Value, appFolder),
            Campaign = doc.Descendants("Campaign").First().Value,
            Brawn =
               GetSum(
                  doc.Descendants("CharCharacteristic")
                     .Single(s => s.Element("Name").Value == Strings.Brawn)
                     .Element("Rank")),
            Agility =
               GetSum(
                  doc.Descendants("CharCharacteristic")
                     .Single(s => s.Element("Name").Value == Strings.Agility)
                     .Element("Rank")),
            Intellect =
               GetSum(
                  doc.Descendants("CharCharacteristic")
                     .Single(s => s.Element("Name").Value == Strings.Intellect)
                     .Element("Rank")),
            Willpower =
               GetSum(
                  doc.Descendants("CharCharacteristic")
                     .Single(s => s.Element("Name").Value == Strings.Willpower)
                     .Element("Rank")),
            Cunning =
               GetSum(
                  doc.Descendants("CharCharacteristic")
                     .Single(s => s.Element("Name").Value == Strings.Cunning)
                     .Element("Rank")),
            Presence =
               GetSum(
                  doc.Descendants("CharCharacteristic")
                     .Single(s => s.Element("Name").Value == Strings.Presence)
                     .Element("Rank")),
            WoundsThreshold = GetSum(doc.Descendants("WoundThreshold").First()),
            StrainThreshold = GetSum(doc.Descendants("StrainThreshold").First()),
            Soak = GetSum(doc.Descendants("SoakValue").First()),
            MeleeDefense = GetSum(doc.Descendants("DefenseMelee").First()),
            RangedDefense = GetSum(doc.Descendants("DefenseRanged").First()),
            ForceRating = GetSum(doc.Descendants("ForceRating").First()),
            GeneralSkills = new List<Skill>(),
            CombatSkills = new List<Skill>(),
            KnowledgeSkills = new List<Skill>(),
            FileName = doc.Root.Element("FileName").Value,
            Id = Guid.Parse(doc.Root.Element("Key").Value),
            LastModified = DateTime.Parse(doc.Root.Element("LastChanged").Value)
         };

         return character;
      }

      /// <summary>
      /// Gets a list of all characters, can be filtered by campagin
      /// </summary>
      /// <param name="dataFolder">The data folder for OggDude's tools</param>
      /// <param name="appFolder">The app folder for OggDude's tools</param>
      /// <param name="campaign">Campaign filter</param>
      public IList<Character> GetCharacters(string dataFolder, string appFolder, string campaign = null)
      {
         var characters = new List<Character>();

         foreach (var file in Directory.EnumerateFiles(Path.Combine(dataFolder, "Characters"), "*.xml"))
         {
            if (campaign == null)
            {
               characters.Add(GetCharacter(file, appFolder));
            }
            else
            {
               if (XDocument.Load(file).Descendants("Campaign").First().Value == campaign)
               {
                  characters.Add(GetCharacter(file, appFolder));
               }
            }
         }
         return characters;
      }

      /// <summary>
      /// Load species data from the species tag
      /// </summary>
      /// <param name="speciesTag">The species tag</param>
      /// <param name="appFolder">The app folder for OggDude's tools</param>
      private string LoadSpeciesFromTag(string speciesTag, string appFolder)
      {
         foreach (var file in Directory.EnumerateFiles(Path.Combine(appFolder, "Species"), $"{speciesTag[0]}*.xml"))
         {
            var doc = XDocument.Load(file);
            if (doc.Root.Descendants("Key").First().Value == speciesTag)
            {
               return doc.Root.Descendants("Name").First().Value;
            }
         }
         return string.Empty;
      }

      /// <summary>
      /// Load career data from the career tag
      /// </summary>
      /// <param name="careerTag">The career tag</param>
      /// <param name="appFolder">The app folder for OggDude's tools</param>
      private string LoadCareerFromTag(string careerTag, string appFolder)
      {
         foreach (var file in Directory.EnumerateFiles(Path.Combine(appFolder, "Careers"), $"{careerTag[0]}*.xml"))
         {
            var doc = XDocument.Load(file);
            if (doc.Root.Descendants("Key").First().Value == careerTag)
            {
               return doc.Root.Descendants("Name").First().Value;
            }
         }
         return string.Empty;
      }

      /// <summary>
      /// Get the sum of all integer child elements in an xml element
      /// </summary>
      /// <param name="sumElement">The parent element to be summed</param>
      private int GetSum(XContainer sumElement)
      {
         var sum = 0;
         foreach (var element in sumElement.Elements())
         {
            int value;
            var success = int.TryParse(element.Value, out value);
            if (success)
            {
               sum += value;
            }
         }
         return sum;
      }
   }
}

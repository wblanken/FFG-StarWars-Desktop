// Copyright (c) 2016 Will Blankenship, Inc.  All Rights Reserved.

using System.Collections.Generic;
using SessionManager.Data.Model;

namespace SessionManager.Data
{
   public interface ICharacterData
   {
      /// <summary>
      /// Loads a given character file
      /// </summary>
      /// <param name="characterFile">The character file</param>
      /// <param name="appFolder">The app folder for OggDude's tools</param>
      Character GetCharacter(string characterFile, string appFolder);

      /// <summary>
      /// Gets a list of all characters, can be filtered by campagin
      /// </summary>
      /// <param name="dataFolder">The data folder for OggDude's tools</param>
      /// <param name="appFolder">The app folder for OggDude's tools</param>
      /// <param name="campaign">Campaign filter</param>
      IList<Character> GetCharacters(string dataFolder, string appFolder, string campaign = null);
   }
}
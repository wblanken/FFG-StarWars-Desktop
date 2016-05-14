// Copyright (c) 2016 Will Blankenship, Inc.  All Rights Reserved.

using System.Collections.Generic;
using SessionManager.Dto;

namespace SessionManager.Data
{
   public interface ICharacterData
   {
      /// <summary>
      /// Gets a list of all characters, can be filtered by campagin
      /// </summary>
      /// <param name="dataFolder">The data folder for OggDude's tools</param>
      /// <param name="appFolder">The app folder for OggDude's tools</param>
      /// <param name="campaign">Campaign filter</param>
      IList<Character> GetCharacters(string dataFolder, string appFolder, string campaign = null);
   }
}
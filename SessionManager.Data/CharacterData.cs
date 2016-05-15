using System.Collections.Generic;
using System.Linq;
using SessionManager.Dto;

namespace SessionManager.Data
{
   public class CharacterData : ICharacterData
   {
      public IList<Character> GetCharacters(string dataFolder, string appFolder, string campaign = null)
      {
         OggDudeData.ImportData.DataPath = dataFolder;
         OggDudeData.ImportData.AppDataPath = appFolder;

         return OggDudeData.ImportData.LoadCharacters(campaign)
                  .Select(Converter.OggCharacterConverter)
                  .ToList();
      }
   }
}

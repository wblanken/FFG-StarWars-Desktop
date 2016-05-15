using SessionManager.Data;

namespace Test_Importer
{
   class Program
   {
      static void Main(string[] args)
      {        
         var character =
            OggDudeData.ImportData.LoadCharacter(@"D:\Dev\Projects\FFG Star Wars\OggDudeData\Model\Testy.xml");
         var convertedChar = Converter.OggCharacterConverter(character);
         return;
      }
   }
}

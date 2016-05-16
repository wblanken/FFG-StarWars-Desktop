using SessionManager.Data;

namespace Test_Importer
{
   class Program
   {
      static void Main(string[] args)
      {
         var appDataFolder =
            @"C:\Users\Will\AppData\Local\Apps\2.0\O0VVP9N3.2VV\PZY921LQ.5Q2\swch..tion_0000000000000000_0001.0006_e7f2ca33d94ec618\Data\";
         var dataFolder = @"C:\Users\Will\AppData\Roaming\SWCharGen\";
         var testCharacter = @"D:\Dev\Projects\FFG Star Wars\OggDudeData\Model\Testy.xml";

         var character = CharacterData.GetCharacter(testCharacter, appDataFolder);
         return;
      }
   }
}

using System.IO;
using System.Xml.Serialization;
using OggDudeData.Model;
using SessionManager.Data;

namespace Test_Importer
{
   class Program
   {
      static void Main(string[] args)
      {        
         var character = new OggDudeData.Model.Character();
         var serializer = new XmlSerializer(typeof(Character));
         using (var file = new FileStream(@"D:\Dev\Projects\FFG Star Wars\OggDudeData\Model\Testy.xml", FileMode.Open,
            FileAccess.Read))
         {
            character = (OggDudeData.Model.Character) serializer.Deserialize(file);
            var convertedCharacter = Converter.OggCharacterConverter(character);
            return;
         }

         /*var doc = new XmlDocument();

         var reader = new XmlTextReader(@"D:\Dev\Projects\FFG Star Wars\OggDudeData\Model\Char5.xml");
         reader.WhitespaceHandling = WhitespaceHandling.None;
         reader.MoveToContent();
         
         doc.Load(reader);
         doc.Save(Console.Out);*/
      }
   }
}

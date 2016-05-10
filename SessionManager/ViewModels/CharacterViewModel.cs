using SessionManager.Dto;

namespace SessionManager.ViewModels
{
   public class CharacterViewModel : ViewModelBase
   {
      public CharacterViewModel()
      {
         var testData = new PashDemoCharacter();
         Character = testData.Character;
      }

      public Character Character { get; set; }
   }
}

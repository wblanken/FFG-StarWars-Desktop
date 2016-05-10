using SessionManager.Model;

namespace SessionManager.ViewModels
{
   public class CharacterViewModel : ViewModelBase
   {
      public CharacterViewModel()
      {
         Character = PashDemoCharacter.Pash;
      }

      public Character Character { get; set; }
   }
}

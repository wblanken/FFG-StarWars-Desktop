using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using SessionManager.Data;
using SessionManager.Data.Model;

namespace SessionManager.ViewModels
{
   public class MainWindowViewModel : ViewModelBase
   {
      private ObservableCollection<Character> _characters;
      private Character _character;

      public MainWindowViewModel()
      {
         ImportData();
      }

      public ObservableCollection<UserControl> Tabs { get; set; }

      public ICommand CharacterCommand { get; set; }
      public ICommand GroupCommand { get; set; }
      public ICommand EnemyCommand { get; set; }
      public ICommand EncounterCommand { get; set; }

      public void ImportData()
      {
         Task.Run(() =>
         {
            Characters = new ObservableCollection<Character>(CharacterData.GetCharacters(Properties.Settings.Default.DataFolder,
               Properties.Settings.Default.AppDataFolder));
         });
      }

      public ObservableCollection<Character> Characters
      {
         get { return _characters; }
         set
         {
            if (Equals(value, _characters)) return;
            _characters = value;
            OnPropertyChanged(nameof(Characters));
         }
      }

      public Character Character
      {
         get { return _character; }
         set
         {
            if(Equals(value, _character)) return;
            _character = value;
            OnPropertyChanged(nameof(Character));
         }
      }
   }
}

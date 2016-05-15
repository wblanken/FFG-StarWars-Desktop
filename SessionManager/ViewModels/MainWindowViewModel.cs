using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using SessionManager.Data;
using SessionManager.Dto;

namespace SessionManager.ViewModels
{
   public class MainWindowViewModel : ViewModelBase
   {
      public MainWindowViewModel()
      {}

      public ObservableCollection<UserControl> Tabs { get; set; }

      public ICommand CharacterCommand { get; set; }
      public ICommand GroupCommand { get; set; }
      public ICommand EnemyCommand { get; set; }
      public ICommand EncounterCommand { get; set; }

      public void ImportData()
      {
         Task.Run(() =>
         {
            var data = new CharacterData();
            Characters = new ObservableCollection<Character>(data.GetCharacters(Properties.Settings.Default.DataFolder,
               Properties.Settings.Default.AppDataFolder));
            return;
         });
      }

      public ObservableCollection<Character> Characters { get; set; }
   }
}

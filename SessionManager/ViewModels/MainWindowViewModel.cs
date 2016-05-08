using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace SessionManager.ViewModels
{
   public class MainWindowViewModel : ViewModelBase
   {
      public MainWindowViewModel()
      {
         
      }

      public ObservableCollection<UserControl> Tabs { get; set; }

      public ICommand CharacterCommand { get; set; }
      public ICommand GroupCommand { get; set; }
      public ICommand EnemyCommand { get; set; }
      public ICommand EncounterCommand { get; set; }
   }
}

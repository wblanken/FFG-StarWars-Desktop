using System;
using System.Windows;
using SessionManager.ViewModels;

namespace SessionManager.Views
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();
         DataContext = new MainWindowViewModel();
      }

      protected override void OnInitialized(EventArgs e)
      {
         base.OnInitialized(e);
         ((MainWindowViewModel) DataContext).ImportData();
      }
   }
}

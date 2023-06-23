using Acron.RestApi.Client.Frontend.ViewModels;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Acron.RestApi.Client.Frontend
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();

         //Example_Method_Calls.Examples.DoAction();
      }

      private async void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (DataContext is MainViewModel vm)
         {

            e.Cancel = !vm.CanClose;
            if (!vm.CanClose)
            {
               Dispatcher.Invoke(() =>
               {
                  Task.Delay(100);
                  Discard.Visibility = Visibility.Visible;
               });
               await vm.ReturnAccessCommand.ExecuteAsync(true);
               Close();
            }
         }

      }
   }
}

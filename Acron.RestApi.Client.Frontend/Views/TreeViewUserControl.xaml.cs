using Acron.RestApi.Client.Frontend.Models;
using Acron.RestApi.Client.Frontend.Models.CommandWrappers;
using Acron.RestApi.Client.Frontend.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Acron.RestApi.Client.Frontend.Views
{
   /// <summary>
   /// Interaktionslogik für TreeViewUserControl.xaml
   /// </summary>
   public partial class TreeViewUserControl : UserControl
   {
      public TreeViewUserControl()
      {
         InitializeComponent();
      }
      private void CommandList_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
      {
         if (DataContext is MainViewModel vm)
            vm.SelectedItem = (e.NewValue as IWrapper);
      }

      private void CommandList_KeyDown(object sender, KeyEventArgs e)
      {
         if (DataContext is not MainViewModel vm)
            return;
         if (e.Key == Key.Delete)
         {
            if (vm.DeleteSelectedCommand.CanExecute(true))
               vm.DeleteSelectedCommand.Execute(true);
         }

      }
   }
}

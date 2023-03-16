using Acron.RestApi.Client.Frontend.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Acron.RestApi.Client.Frontend.Views.Dialog
{
   /// <summary>
   /// Interaktionslogik für ModifyLoginValuesDialog.xaml
   /// </summary>
   public partial class ModifyLoginValuesDialog : Window
   {

      public ObservableCollection<DataItem> ListOfLoginValues { get; set; }
      public DataItem? SelectedItem { get; set; }
      public ModifyLoginValuesDialog(Login login)
      {
         ListOfLoginValues = new();
         foreach (PropertyInfo prop in login.GetType().GetProperties())
         {
            Type t = prop.PropertyType;
            ListOfLoginValues.Add(new DataItem()
            {
               Key = prop.Name,
               Value = (prop.GetValue(login) as string) ?? string.Empty,
            });
            if (ListOfLoginValues.Last().Value == string.Empty)
            {
               switch (t.Name)
               {
                  case "UInt32":
                     uint ou = (uint)prop.GetValue(login)!;
                     ListOfLoginValues.Last().Value = ou.ToString(CultureInfo.InvariantCulture);
                     break;
                  case "Single":
                     float floa = (float)prop.GetValue(login)!;
                     ListOfLoginValues.Last().Value = floa.ToString(CultureInfo.InvariantCulture);
                     break;


               }

            }
         }
         InitializeComponent();
      }

      private void Button_Click_1(object sender, RoutedEventArgs e)
      {
         DialogResult = true;
         this.Close();
      }
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
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
   /// Interaktionslogik für ClientRibbon.xaml
   /// </summary>
   public partial class ClientRibbon : Ribbon
   {
      public ClientRibbon()
      {
         InitializeComponent();
      }

      private void TextBox_KeyDown(object sender, KeyEventArgs e)
      {
         if (sender is not TextBox tb)
            return;
         if(e.Key == Key.Enter)
         {
            if (!int.TryParse(tb.Text,out int test))
               tb.Text = "50";
            tb.GetBindingExpression(TextBox.TextProperty).UpdateSource();
         }
      }
   }
}

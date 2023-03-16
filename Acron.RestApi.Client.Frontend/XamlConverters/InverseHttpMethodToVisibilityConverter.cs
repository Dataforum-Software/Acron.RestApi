using Acron.RestApi.Client.Frontend.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Acron.RestApi.Client.Frontend.XamlConverters
{
   internal class InverseHttpMethodToVisibilityConverter : IValueConverter
   {
      public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
      {
         if( value is not Methods Value)
            return Visibility.Collapsed;
         if (Value == Methods.GET || Value == Methods.DELETE || Value == Methods.HEAD || Value == Methods.OPTIONS)
         {
            return Visibility.Visible;
         }
         else
         {
            return Visibility.Collapsed;
         }
      }

      public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
      {
         throw new NotImplementedException();
      }
   }
}

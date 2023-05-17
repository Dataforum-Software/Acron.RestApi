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
   internal class PortVisibilityConverter : IValueConverter
   {
      public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
      {
         if (value is not uint)
            return Visibility.Visible;
         if ((uint)value <= 0 || (uint)value > 65535)
            return Visibility.Visible;
         return Visibility.Collapsed;

      }

      public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
      {
         throw new NotImplementedException();
      }
   }
}

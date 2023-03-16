﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Acron.RestApi.Client.Frontend.XamlConverters
{
   internal class StatusCodeToColorConverter : IValueConverter
   {
      public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
      {
         if ((int)value <= 202)
         {
            return new SolidColorBrush((Color)ColorConverter.ConvertFromString("green"));
         }
         else
         {
            return new SolidColorBrush((Color)ColorConverter.ConvertFromString("red"));
         }
      }

      public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
      {
         throw new NotImplementedException();
      }
   }
}

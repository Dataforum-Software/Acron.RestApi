using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Acron.RestApi.Client.Frontend.XamlConverters
{
   internal class TypeToNameConverter : IValueConverter
   {
      public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
      {
         if(value is IEnumerable<Type> list)
         {
            List<string> list2 = new();
            foreach(var t in list)
               list2.Add(t.Name);
            return list2;
         }
         else
            return (value as Type)?.Name ?? string.Empty;
      }

      public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
      {
         if(value is string s)
         {
            return AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).First(x => x.Name == s);
         }
         else
         {
            throw new NotImplementedException();
         }
      }
   }
}

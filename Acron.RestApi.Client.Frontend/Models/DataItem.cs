using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Acron.RestApi.Client.Frontend.Models
{
   public class DataItem
   {
      public DataItem() 
      {
         Key = string.Empty;
         Value = string.Empty;
      }

      public bool canDelete { get { return true; } }
      public string Key { get; set; }
      public string Value { get; set; }
   }
}

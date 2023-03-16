using Acron.RestApi.Client.Frontend.Models.CommandWrappers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Frontend.Models
{
   internal class Folders
   {
      public Folders() 
      {
         Name = string.Empty;
         Children = new();
      }
      public string Name { get; set; }

      public ObservableCollection<IWrapper> Children { get; set; }
   }
}

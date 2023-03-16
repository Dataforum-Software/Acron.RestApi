using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Frontend.Models.CommandWrappers
{
   internal interface IOnlineGraphCapable
   {
      #region Required Properties
      public DateTime LastExecution { get;  }

      public int MaxLength { get; set; }
      #endregion

      public void UpdateLastExecution();

      public Task ExecuteOnline();
   }
}

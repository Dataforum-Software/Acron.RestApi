using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Frontend.Models.CommandWrappers
{
   /// <summary>
   /// Implement this Interface for OnlineGraph functionality, check GetProcessDataWrapper for Implementation
   /// </summary>
   internal interface IOnlineGraphCapable : IWrapper
   {
      #region Required Properties
      public DateTime LastExecution { get;  }

      public int MaxLength { get; set; }
      #endregion

      public void UpdateLastExecution();

      public Task ExecuteOnline();
   }
}

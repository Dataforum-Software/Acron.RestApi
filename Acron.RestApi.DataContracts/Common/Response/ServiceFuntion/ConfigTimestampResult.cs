using Acron.RestApi.Interfaces.Common.Response.ServiceFunction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Common.Response.ServiceFuntion
{
   public class ConfigTimestampResult : IConfigTimestampResult
   {
      public DateTime? ConfigTimestamp { get; set; }
   }
}

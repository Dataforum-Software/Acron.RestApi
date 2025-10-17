using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Common.Response.ServiceFunction
{
   public interface IShutdownResult
   {
      bool ShutdownInitiated { get; set; }
   }
}

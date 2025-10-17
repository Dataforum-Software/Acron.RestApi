using Acron.RestApi.Interfaces.Common.Response.ServiceFunction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Common.Response.ServiceFuntion
{
   [DataContract]
   public class ResponsivenessCheckResult : IResponsivenessCheckResult
   {
      [DataMember]
      public bool RestAPIIsResponsive { get; set; }
   }
}

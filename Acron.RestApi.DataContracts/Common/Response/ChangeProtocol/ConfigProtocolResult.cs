using Acron.RestApi.Interfaces.Common.Response.ChangeProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Common.Response.ChangeProtocol
{
   [DataContract]
   public class ConfigProtocolResult : IConfigProtocolResult<ConfigProtocol>
   {
      [DataMember]
      public List<ConfigProtocol> ConfigProtocolEntries { get; set; }
   }
}

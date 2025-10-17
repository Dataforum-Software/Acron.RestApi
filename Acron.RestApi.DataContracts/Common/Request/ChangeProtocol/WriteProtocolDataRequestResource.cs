using Acron.RestApi.Interfaces.Common.Request.ChangeProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Common.Request.ChangeProtocol
{
   [DataContract]
   public class WriteProtocolDataRequestResource : IWriteProtocolDataRequestResource<WriteProtocolDataEntry>
   {
      [DataMember]
      public string UserShortName { get; set; }

      [DataMember]
      public List<WriteProtocolDataEntry> Values { get; set; }
   }
}

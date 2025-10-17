using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Common.Response.ChangeProtocol
{
   [DataContract]
   public class DataProtocolResult : IDataProtocolResult<DataProtocol>
   {
      [DataMember]
      public List<DataProtocol> DataProtocolEntries { get; set; }
   }
}

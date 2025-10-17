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
   public class GetDataProtocolRequestResource : IGetDataProtocolRequestResource
   {
      [DataMember]
      public DateTime FromTime { get; set; }
      [DataMember]
      public DateTime ToTime { get; set; }
      [DataMember]
      public DateTime FromTimeData { get; set; }
      [DataMember]
      public DateTime ToTimeData { get; set; }
      [DataMember]
      public string UserShortName { get; set; }
      [DataMember]
      public List<PROTFILTER_DataProtocol> PROTFILTERs { get; set; }
   }
}

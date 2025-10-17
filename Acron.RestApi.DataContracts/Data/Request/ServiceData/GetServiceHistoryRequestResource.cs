using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.ServiceData;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.ServiceData
{
   [DataContract]
   public class GetServiceHistoryRequestResource : IGetServiceHistoryRequestResource
   {
      [DataMember]
      public DateTime FromTime { get; set; }

      [DataMember]
      public DateTime ToTime { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public ServiceHistoryFlags ServiceHistoryFlag { get; set; }

      [DataMember]
      [ObjectId]
      public List<uint> ServiceEntityIDs { get; set; }
   }
}

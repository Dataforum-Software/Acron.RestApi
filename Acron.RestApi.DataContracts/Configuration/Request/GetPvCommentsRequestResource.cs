using Acron.RestApi.Interfaces.Configuration.Request;
using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Configuration.Request
{
   [DataContract]
   public class GetPvCommentsRequestResource : IGetPvCommentsRequestResource
   {
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public AVComKinds_Pv Kind { get; set; }

      [DataMember]
      public DateTimeOffset FromTime { get; set; }

      public DateTime FromTime_UTC
      {
         get
         {
            return FromTime.UtcDateTime;
         }
      }

      [DataMember]
      public DateTimeOffset ToTime { get; set; }

      public DateTime ToTime_UTC
      {
         get
         {
            return ToTime.UtcDateTime;
         }

      }

      [DataMember]
      public IEnumerable<uint> PVIDs { get; set; }
   }
}

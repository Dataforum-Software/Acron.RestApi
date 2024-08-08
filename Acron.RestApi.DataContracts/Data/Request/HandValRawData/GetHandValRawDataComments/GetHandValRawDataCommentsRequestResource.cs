
using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.HandValRawData.GetHandValRawDataComments;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.GetHandValRawDataComments
{
   [DataContract]
   public class GetHandValRawDataCommentsRequestResource : IGetHandValRawDataCommentsRequestResource
   {
      [DataMember]
      [Required]
      [JsonConverter(typeof(StringEnumConverter))]
      public AVComKinds_HandVal Kind { get; set; }

      [DataMember]
      [Required]
      [RequestTimeStampValidator]
      public DateTimeOffset FromTime { get; set; }

      public DateTime FromTime_UTC
      {
         get
         {
            return FromTime.UtcDateTime;
         }
      }

      [DataMember]
      [Required]
      [RequestTimeStampValidator]
      public DateTimeOffset ToTime { get; set; }

      public DateTime ToTime_UTC
      {
         get
         {
            return ToTime.UtcDateTime;
         }

      }

      [DataMember]
      [Required]
      public IEnumerable<uint> PVIds { get; set; }
   }


}

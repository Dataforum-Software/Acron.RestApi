using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.HandValRawData.GetHandValRawData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.GetHandValRawData
{
   [DataContract]
   public class GetHandValRawDataRequestResource : IGetHandValRawDataRequestResource
   {
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
      [JsonConverter(typeof(StringEnumConverter))]
      [Range(0, 2)]
      public HANDVALREADTYPES HandValReadType { get; set; }

      [DataMember]
      [Required]
      public List<int> PVs { get; set; }
   }
}

using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.IntervalData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.IntervalData
{

   [DataContract]
   public class GetIntervalDataRequestResource : IGetIntervalDataRequestResource<GetIntervalDataPVDescription, IntervalWhat>
   {
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      [Range(1, 8)]
      public IntervalTypes IntervalType {get; set;}

      [DataMember]
      public DateTimeOffset FromTime { get; set; }
      [Required]
      [RequestTimeStampValidator]
      public DateTime FromTime_UTC 
      { 
         get
         {
            return FromTime.UtcDateTime;
         }
      }

      [DataMember]
      public DateTimeOffset ToTime { get; set; }
      [Required]
      [RequestTimeStampValidator]
      public DateTime ToTime_UTC
      {
         get
         {
            return ToTime.UtcDateTime;
         }
      }

      [DataMember]
      [Required]
      public List<GetIntervalDataPVDescription> PVDescriptions {get; set;}
   }
}

using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.MonthWeekData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.MonthWeekData
{
   [DataContract]
   public class GetMonthWeekDataRequestResource : IGetMonthWeekDataRequestResource<GetMonthWeekDataPVDescription, MonthWeekWhat>
   {
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      [Range(17,18)]
      public MonthWeekTypes MonthWeekType { get; set; }

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
      public List<GetMonthWeekDataPVDescription> PVDescriptions { get; set; }
   }
}

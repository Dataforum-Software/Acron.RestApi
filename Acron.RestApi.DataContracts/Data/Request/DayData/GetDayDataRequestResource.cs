using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.DayData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.DayData
{
   [DataContract]
   public class GetDayDataRequestResource : IGetDayDataRequestResource<GetDayDataPVDescription, DayWhat>
   {
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      [Range(9,10)]
      public DayTypes DayType { get; set; }

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
      public List<GetDayDataPVDescription> PVDescriptions { get; set; }
   }

}


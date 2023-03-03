using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.YearData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.YearData
{
   [DataContract]
   public class GetYearDataRequestResource : IGetYearDataRequestResource<GetYearDataPVDescription, YearWhat>
   {
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      [Range(19,20)]
      public YearTypes YearType { get; set; }
      
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
      public List<GetYearDataPVDescription> PVDescriptions { get; set; }
   }
}

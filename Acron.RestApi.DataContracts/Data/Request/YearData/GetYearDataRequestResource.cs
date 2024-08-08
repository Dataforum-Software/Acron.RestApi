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
      [Range(1971,3000)]
      public int FromYear { get; set; }

      public DateTimeOffset FromTime
      {
         get => new DateTime(FromYear, 1, 1);
         set => FromYear = value.DateTime.Year;
      }

      [DataMember]
      [Required]
      [Range(1971, 3000)]
      public int ToYear { get; set; }

      public DateTimeOffset ToTime
      {
         get => new DateTime(ToYear, 1, 1);
         set => ToYear = value.DateTime.Year;
      }

      [DataMember]
      [Required]
      public List<GetYearDataPVDescription> PVDescriptions { get; set; }
   }

   [DataContract]
   public class GetYearDataRequestResource__L9_4__10_0 : IGetYearDataRequestResource__L9_4__10_0<GetYearDataPVDescription, YearWhat>
   {
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      [Range(19, 20)]
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

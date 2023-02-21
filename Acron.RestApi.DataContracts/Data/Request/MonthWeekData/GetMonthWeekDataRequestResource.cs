using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.MonthWeekData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.MonthWeekData
{
   [DataContract]
   public class GetMonthWeekDataRequestResource : IGetMonthWeekDataRequestResource<GetMonthWeekDataPVDescription, MonthWeekWhat>
   {
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public MonthWeekTypes MonthWeekType { get; set; }

      [DataMember]
      [FormatDateTimeUTCRequest(nameof(FromTime_UTC))]
      public DateTime FromTime { get; set; }
      public DateTime FromTime_UTC { get; set; }

      [DataMember]
      [FormatDateTimeUTCRequest(nameof(ToTime_UTC))]
      public DateTime ToTime { get; set; }
      public DateTime ToTime_UTC { get; set; }

      [DataMember]
      public List<GetMonthWeekDataPVDescription> PVDescriptions { get; set; }
   }
}

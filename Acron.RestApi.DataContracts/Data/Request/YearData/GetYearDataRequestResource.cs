using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.YearData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.YearData
{
   [DataContract]
   public class GetYearDataRequestResource : IGetYearDataRequestResource<GetYearDataPVDescription, YearWhat>
   {
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]         
      public YearTypes YearType { get; set; }

      [DataMember]
      [FormatDateTimeUTCRequest(nameof(FromTime_UTC))]
      public DateTime FromTime { get; set; }
      public DateTime FromTime_UTC { get; set; }

      [DataMember]
      [FormatDateTimeUTCRequest(nameof(ToTime_UTC))]
      public DateTime ToTime { get; set; }
      public DateTime ToTime_UTC { get; set; }

      [DataMember]
      public List<GetYearDataPVDescription> PVDescriptions { get; set; }
   }
}

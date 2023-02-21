using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.IntervalData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.IntervalData
{

   [DataContract]
   public class GetIntervalDataRequestResource : IGetIntervalDataRequestResource<GetIntervalDataPVDescription, IntervalWhat>
   {
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public IntervalTypes IntervalType {get; set;}

      [DataMember]
      [FormatDateTimeUTCRequest(nameof(FromTime_UTC))]
      public DateTime FromTime { get; set; }
      public DateTime FromTime_UTC { get; set; }

      [DataMember]
      [FormatDateTimeUTCRequest(nameof(ToTime_UTC))]
      public DateTime ToTime { get; set; }
      public DateTime ToTime_UTC { get; set; }

      [DataMember]
      public List<GetIntervalDataPVDescription> PVDescriptions {get; set;}
   }
}

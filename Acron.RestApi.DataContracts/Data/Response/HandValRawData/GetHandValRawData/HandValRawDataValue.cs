using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.HandValRawData.GetHandValRawData
{
   [DataContract]
   public class GetHandValRawDataValue : IGetHandValRawDataValue
   {
      [DataMember]
      [FormatDateTime(nameof(TimeStamp_FORMATTED), DateTimeFormatType.Process)]
      public DateTimeOffset TimeStamp { get; set; }

      [DataMember]
      public string TimeStamp_FORMATTED { get; set; }

      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public HandValRawDataProvalTypes ProvalType { get; set; }

      [DataMember]
      public short MilliSec { get; set; }

      [DataMember]
      [FormatDoubleMarker(nameof(NumValue_FORMATTED), ValueFormatType.ManualValue)]
      public double NumValue { get; set; }

      [DataMember]
      public string NumValue_FORMATTED { get; set; }

      [DataMember]
      public string AlphaNumericValue { get; set; }

      [DataMember]
      public IGetHandValRawDataFlag ValuesFlag { get; set; }

      [DataMember]
      public DateTimeOffset InputTimeHandVal { get; set; }

      [DataMember]
      public string InputUserHandVal { get; set; }

      [DataMember]
      public string OptionalInputKey { get; set; }
   }
}

using Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.HandValRawData.GetHandValRawData
{
   [DataContract]
    public class GetHandValRawDataValue : IGetHandValRawDataValue
    {
        [DataMember]
        public DateTime TimeStamp { get; set; }

        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public HandValRawDataProvalTypes ProvalType { get; set; }

        [DataMember]
        public short MilliSec { get; set; }

        [DataMember]
        public double NumValue { get; set; }

        [DataMember]
        public string TextValue { get; set; }

        [DataMember]
        public string AlphaNumericValue { get; set; }

        [DataMember]
        public IGetHandValRawDataFlag ValuesFlag { get; set; }

        [DataMember]
        public DateTime InputTimeHandVal { get; set; }

        [DataMember]
        public string InputUserHandVal { get; set; }

        [DataMember]
        public string OptionalInputKey { get; set; }
    }
}

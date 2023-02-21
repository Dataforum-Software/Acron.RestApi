using Acron.RestApi.Interfaces.Data.Request.HandValRawData.GetHandValRawData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.GetHandValRawData
{
   [DataContract]
    public class GetHandValRawDataRequestResource : IGetHandValRawDataRequestResource
    {
        [DataMember]
        public DateTime FromTime { get; set; }

        [DataMember]
        public DateTime ToTime { get; set; }

        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public HANDVALREADTYPES HandValReadType { get; set; }

        [DataMember]
        public List<int> PVs { get; set; }
    }
}

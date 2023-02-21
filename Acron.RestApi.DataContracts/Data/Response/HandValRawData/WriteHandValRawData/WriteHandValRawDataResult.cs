using Acron.RestApi.Interfaces.Data.Response.HandValRawData.WriteHandValRawData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.HandValRawData.WriteHandValRawData
{
   [DataContract]
   public class WriteHandValRawDataResult : IWriteHandValRawDataResult
   {
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      [DefaultValue(-1000)]
      public WriteHandValRawDataResults Result { get; set; }
   }
}

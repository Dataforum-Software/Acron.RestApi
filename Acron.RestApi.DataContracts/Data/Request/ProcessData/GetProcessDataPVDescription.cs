using Acron.RestApi.Interfaces.Data.Request.ProcessData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using static Acron.RestApi.Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription;

namespace Acron.RestApi.DataContracts.Data.Request.ProcessData
{
   [DataContract]
   public class GetProcessDataPVDescription : IGetProcessDataPVDescription
   {
      /// <summary>
      /// ObjectID
      /// </summary>
      [DataMember]
      public uint PVID { get; set; }

      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public DataValueTypes ValueTypes { get; set; }

      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public DBP_ReadTypes DBP_ReadType { get; set; }

      [DataMember]
      public uint PVReplID { get; set; } = 0;
   }
}

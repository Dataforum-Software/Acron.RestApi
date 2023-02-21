using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawData;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValRawData
{
   [DataContract]
   public class WriteHandValRawDataPVDescription : IWriteHandValRawDataPVDescription<WriteHandValRawDataProval>
   {
      [DataMember]
      public uint PVID { get; set; }

      [DataMember]
      public List<WriteHandValRawDataProval> Provals { get; set; }
   }
}

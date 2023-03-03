using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawDataAndInfos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos
{
   [DataContract]
   public class WriteHandValRawDataAndInfosPVDescription : IWriteHandValRawDataAndInfosPVDescription<WriteHandValRawDataAndInfos, WriteHandValRawDataAndInfoFlag>
   {
      [DataMember]
      public uint PVID { get; set; }
      [DataMember]
      public List<WriteHandValRawDataAndInfos> Values { get; set; }
   }
}

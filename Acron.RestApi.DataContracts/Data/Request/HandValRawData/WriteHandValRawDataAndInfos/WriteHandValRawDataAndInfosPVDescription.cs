using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawDataAndInfos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos
{
   public class WriteHandValRawDataAndInfosPVDescription : IWriteHandValRawDataAndInfosPVDescription<WriteHandValRawDataAndInfos, WriteHandValRawDataAndInfoFlag>
   {
      public uint PVID { get; set; }
      public List<WriteHandValRawDataAndInfos> Values { get; set; }
   }
}

using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawDataAndInfos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos
{
   public class WriteHandValRawDataAndInfosRequestResource : IWriteHandValRawDataAndInfosRequestResource<WriteHandValRawDataAndInfosPVDescription, WriteHandValRawDataAndInfos, WriteHandValRawDataAndInfoFlag>
   {
      public DateTime DayTimeStamp { get; set; }
      public List<WriteHandValRawDataAndInfosPVDescription> PVDescriptions { get; set; }
   }
}

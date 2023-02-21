using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValInfos;
using System.Collections.Generic;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValInfos
{
   public class WriteHandValInfosRequestResource : IWriteHandValInfosRequestResource<WriteHandValRawDataInfo, WriteHandValRawDataInfoFlag>
   {
      public List<WriteHandValRawDataInfo> ProInfos { get; set; }
   }
}

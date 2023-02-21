using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValInfos
{
   public interface IWriteHandValInfosRequestResource<T, U> where T : IWriteHandValRawDataInfo<U> where U : IWriteHandValRawDataInfoFlag
   {
      public List<T> ProInfos { get; set; }
   }
}

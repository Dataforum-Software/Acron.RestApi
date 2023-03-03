using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValInfos
{
   public interface IWriteHandValInfosRequestResource<T, U> where T : IWriteHandValRawDataInfo<U> where U : IWriteHandValRawDataInfoFlag
   {
      [SwaggerSchema("List of infos for requested process variables")]
      [SwaggerExampleValue(typeof(IWriteHandValRawDataInfo<IWriteHandValRawDataInfoFlag>))]
      public List<T> ProInfos { get; set; }
   }
}

using Acron.RestApi.Interfaces.Data.Response.IntervalData;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData
{
   public interface IGetHandValRawDataResult
    {
      [SwaggerSchema("Result contains values")]
      [SwaggerExampleValue(true)]
      bool HasData { get; }

      [SwaggerSchema("Number of manual variables in result")]
      [SwaggerExampleValue(15)]
      int PVCount { get; }

      [SwaggerSchema("List of manual variables")]
      [SwaggerExampleValue(typeof(IGetHandValRawData))]
      List<IGetHandValRawData> PVList { get; set; }
    }
}

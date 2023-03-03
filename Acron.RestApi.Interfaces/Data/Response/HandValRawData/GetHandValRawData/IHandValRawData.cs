using Acron.RestApi.Interfaces.Data.Response.IntervalData;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData
{
   public interface IGetHandValRawData
    {

      [SwaggerSchema("Numeric ID of process value")]
      [SwaggerExampleValue(302000003)]
      public uint PVID { get; set; }

      [SwaggerSchema($"Number of values in {nameof(DayList)}")]
      [SwaggerExampleValue(30)]
      public int DaysCount { get; }


      [SwaggerSchema($"Collection of {nameof(IGetHandValRawDataDayValue)} objects, one per process variable")]
      [SwaggerExampleValue(typeof(IGetHandValRawDataDayValue))]
      public List<IGetHandValRawDataDayValue> DayList { get; set; }
    }
}

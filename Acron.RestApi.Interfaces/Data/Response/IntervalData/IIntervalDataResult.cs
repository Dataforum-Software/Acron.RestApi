using Acron.RestApi.Interfaces.Data.Response.DayData;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Response.IntervalData
{
   public interface IIntervalDataResult
   {
      [SwaggerSchema("Result contains values")]
      [SwaggerExampleValue("true")]
      bool HasData { get; }

      [SwaggerSchema("Number of process variables in result")]
      [SwaggerExampleValue(15)]
      int PVCount { get; }

      [SwaggerSchema("Number of time stamps per process variable")]
      [SwaggerExampleValue(12)]
      int TimeStampsCount { get; }

      [SwaggerSchema($"Time stamps for interval values of process variables in {nameof(Data)}")]
      [SwaggerExampleValue("[\"2022-10-10T02:00:00Z\", \"2022-10-10T04:00:00Z\", \"2022-10-10T06:00:00Z\"]")]
      List<DateTime> TimeStamps { get; set; }

      [SwaggerSchema($"{nameof(TimeStamps)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"10.10.2022 02:00:00\", \"10.10.2022 04:00:00\", \"10.10.2022 06:00:00\"]")]
      List<string> TimeStamps_FORMATTED { get; set; }

      [SwaggerSchema($"Collection of {nameof(IIntervalData)} objects, one per process variable")]
      [SwaggerExampleValue(typeof(IIntervalData))]
      List<IIntervalData> Data { get; set; }
   }
}

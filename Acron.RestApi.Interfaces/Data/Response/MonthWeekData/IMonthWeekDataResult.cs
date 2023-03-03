using Acron.RestApi.Interfaces.Data.Response.DayData;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Response.MonthWeekData
{
   public interface IMonthWeekDataResult
   {
      [SwaggerSchema("Result contains values")]
      [SwaggerExampleValue("true")]
      public bool HasData { get; }

      [SwaggerSchema("Number of process variables in result")]
      [SwaggerExampleValue(15)]
      public int PVCount { get; }

      [SwaggerSchema("Number of time stamps per process variable")]
      [SwaggerExampleValue(12)]
      public int TimeStampsCount { get; }

      [SwaggerSchema($"Time stamps for Monthly/Weekly values of process variables in {nameof(Data)}")]
      [SwaggerExampleValue("[\"2022-10-01T00:00:00Z\", \"2022-11-01T00:00:00Z\", \"2022-12-01T00:00:00Z\"]")]
      public List<DateTime> TimeStamps { get; set; }

      [SwaggerSchema($"{nameof(TimeStamps)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"01.10.2022 00:00:00\", \"01.11.2022 00:00:00\", \"01.12.2022 00:00:00\"]")]
      public List<string> TimeStamps_FORMATTED { get; set; }

      [SwaggerSchema($"Collection of {nameof(IMonthWeekData)} objects, one per process variable")]
      [SwaggerExampleValue(typeof(IMonthWeekData))]
      public List<IMonthWeekData> Data { get; set; }
   }
}

using Acron.RestApi.Interfaces.Data.Response.DayData;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Response.YearData
{
   public interface IYearDataResult
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

      [SwaggerSchema($"Time stamps for daily values of process variables in {nameof(Data)}")]
      [SwaggerExampleValue("[\"2021-01-01T00:00:00Z\", \"2022-01-01T00:00:00Z\", \"2023-01-01T00:00:00Z\"]")]
      public List<DateTime> TimeStamps { get; set; }

      [SwaggerSchema($"{nameof(TimeStamps)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"01.01.2021 00:00:00\", \"01.01.2022 00:00:00\", \"01.01.2023 00:00:00\"]")]
      public List<string> TimeStamps_FORMATTED { get; set; }

      [SwaggerSchema($"Collection of {nameof(IYearData)} objects, one per process variable")]
      [SwaggerExampleValue(typeof(IYearData))]
      public List<IYearData> Data { get; set; }
   }
}

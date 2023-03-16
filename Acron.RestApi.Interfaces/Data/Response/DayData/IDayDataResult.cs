using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;


namespace Acron.RestApi.Interfaces.Data.Response.DayData
{
   public interface IDayDataResult<T,U> where T : IDayData<U> where U : IDayDataFlag
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

      [SwaggerSchema($"Time stamps for daily values of process variables in {nameof(Data)}")]
      [SwaggerExampleValue("[\"2022-10-10T00:00:00Z\", \"2022-10-11T00:00:00Z\", \"2022-10-12T00:00:00Z\"]")]
      List<DateTime> TimeStamps { get; set; }

      [SwaggerSchema($"{nameof(TimeStamps)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"10.10.2022 00:00:00\", \"11.10.2022 00:00:00\", \"12.10.2022 00:00:00\"]")]
      List<string> TimeStamps_FORMATTED { get; set; }

      [SwaggerSchema($"Collection of DayData objects, one per process variable")]
      [SwaggerExampleValue(typeof(IDayData<IDayDataFlag>))]
      List<T> Data { get; set; }      
   }
}

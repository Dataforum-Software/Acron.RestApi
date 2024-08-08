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
      [SwaggerExampleValue(new string[] { "2022-10-10", "2022-10-11", "2022-10-12" })]
      List<DateOnly> TimeStampDays { get; set; }

      [SwaggerSchema($"{nameof(TimeStampDays)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue(new string[]{ "10.10.2022", "11.10.2022", "12.10.2022"})]
      List<string> TimeStamps_FORMATTED { get; set; }

      [SwaggerSchema($"Collection of DayData objects, one per process variable")]
      [SwaggerExampleValue(typeof(IDayData<IDayDataFlag>))]
      List<T> Data { get; set; }      
   }

   public interface IDayDataResult__L9_4__10_0<T, U> where T : IDayData<U> where U : IDayDataFlag
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
      [SwaggerExampleValue(new string[]{ "2022-10-10T00:00:00Z", "2022-10-11T00:00:00Z", "2022-10-12T00:00:00Z"})]
      List<DateTime> TimeStamps { get; set; }

      [SwaggerSchema($"{nameof(TimeStamps)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue(new string[]{ "10.10.2022 00:00:00", "11.10.2022 00:00:00", "12.10.2022 00:00:00"})]
      List<string> TimeStamps_FORMATTED { get; set; }

      [SwaggerSchema($"Collection of DayData objects, one per process variable")]
      [SwaggerExampleValue(typeof(IDayData<IDayDataFlag>))]
      List<T> Data { get; set; }
   }
}

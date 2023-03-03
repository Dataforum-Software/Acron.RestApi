using Acron.RestApi.Interfaces.Data.Response.IntervalData;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData
{
   public interface IGetHandValRawDataDayValue
    {
      [SwaggerSchema("Day start time")]
      [SwaggerExampleValue("2022-10-10T01:29:59Z")]
      public DateTimeOffset DayStartTime { get; set; }

      [SwaggerSchema("Day start time formatted")]
      [SwaggerExampleValue("01.01.1970 00:00:00")]
      public string DayStartTime_FORMATTED { get; set; }

      [SwaggerSchema("Day comment")]
      [SwaggerExampleValue("")]
      public string DayComment { get; set; }

      [SwaggerSchema($"Number of values in {nameof(Data)}")]
      [SwaggerExampleValue(300)]
      public int DataCount { get; }

      [SwaggerSchema($"Collection of {nameof(IGetHandValRawDataValue)} objects")]
      [SwaggerExampleValue(typeof(IGetHandValRawDataValue))]
      public List<IGetHandValRawDataValue> Data { get; set; }
    }
}

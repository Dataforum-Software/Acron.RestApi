using Swashbuckle.AspNetCore.Annotations;
using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using System;
using System.Runtime.Serialization;

namespace Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData
{
   public interface IGetHandValRawDataValue<GetHandValRawDataFlagType> where GetHandValRawDataFlagType : IGetHandValRawDataFlag
   {
      [SwaggerSchema("Time stamp for manual value")]
      [SwaggerExampleValue("2022-10-10T01:29:59Z")]
      public DateTimeOffset TimeStamp { get; set; }

      [SwaggerSchema($"{nameof(TimeStamp)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("10.10.2022 02:00:00")]
      public string TimeStamp_FORMATTED { get; set; }

      [SwaggerSchema("Data type (Numeric / Text)")]
      [SwaggerExampleValue(HandValRawDataProvalTypes.Numeric)]
      public HandValRawDataProvalTypes ProvalType { get; set; }

      [SwaggerSchema("Milliseconds of time stamp")]
      [SwaggerExampleValue(50)]
      public short MilliSec { get; set; }

      [SwaggerSchema($"Numeric value, if {nameof(ProvalType)} is numeric")]
      [SwaggerExampleValue(10)]
      public double NumValue { get; set; }


      [SwaggerSchema("Numeric value formatted")]
      [SwaggerExampleValue("10")]
      public string NumValue_FORMATTED { get; set; }

      [SwaggerSchema($"Text value, if {nameof(ProvalType)} is text")]
      [SwaggerExampleValue("Rainy")]
      public string AlphaNumericValue { get; set; }

      [SwaggerSchema("Extended properties of this manual value")]
      [SwaggerExampleValue(typeof(IGetHandValRawDataFlag))]
      public GetHandValRawDataFlagType ValuesFlag { get; set; }

      [SwaggerSchema("Input time of manual value")]
      [SwaggerExampleValue("2022-10-10T01:29:59Z")]
      public DateTimeOffset InputTimeHandVal { get; set; }

      [SwaggerSchema("Manual value given from user")]
      [SwaggerExampleValue("10")]
      public string InputUserHandVal { get; set; }

      [SwaggerSchema("Optional tag for this manual value (e.g. laboratory name)")]
      [SwaggerExampleValue("1")]
      public string OptionalInputKey { get; set; }
    }
}

using Swashbuckle.AspNetCore.Annotations;
using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using System;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawData
{
   public interface IWriteHandValRawDataProval
   {
      [SwaggerSchema("Time stamp")]
      [SwaggerExampleValue("2022-10-10T21:44:59")]
      public DateTimeOffset TimeStamp { get; set; }

      public DateTime TimeStamp_UTC { get; }

      [SwaggerSchema("Type of process value")]
      [SwaggerExampleValue("Numeric = 0")]
      public HandValRawDataProvalTypes ProvalType { get; }

      [SwaggerSchema("Milliseconds")]
      [SwaggerExampleValue(65535)]
      public short MilliSeconds { get; set; }

      [SwaggerSchema("Numeric value")]
      [SwaggerExampleValue(20)]
      public double Value { get; set; } //Wenn ProvalType = Numeric

      [SwaggerSchema("Text value")]
      [SwaggerExampleValue("val")]
      public string StringValue { get; set; } //Wenn ProvalType = Text
   }
}

using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawDataAndInfos
{
   public interface IWriteHandValRawDataAndInfos<FlagType> where FlagType : IWriteHandValRawDataAndInfoFlag
   {
      [SwaggerSchema("Time stamp")]
      [SwaggerExampleValue("2022-10-10T21:44:59")]
      public DateTimeOffset TimeStamp { get; set; }

      public DateTime TimeStamp_UTC { get; }

      [SwaggerSchema("Type of process value")]
      [SwaggerExampleValue("Numeric = 0")]
      public WriteHandValRawDataAndInfoTypes ProvalType { get; }

      [SwaggerSchema("Milliseconds")]
      [SwaggerExampleValue(65535)]
      public short MilliSeconds { get; }

      [SwaggerSchema("Numeric value")]
      [SwaggerExampleValue(20)]
      public double Value { get; set; } //Wenn ProvalType = Numeric

      [SwaggerSchema("Text value")]
      [SwaggerExampleValue("val")]
      public string StringValue { get; set; } //Wenn ProvalType = Text

      [SwaggerSchema("Extended properties of this value")]
      [SwaggerExampleValue(typeof(IWriteHandValRawDataAndInfoFlag))]
      FlagType ProInfoFlag { get; set; }

      [SwaggerSchema("Optional key 9 Unicode characters")]
      [SwaggerExampleValue("abc!")]
      string Key { get; set; }  //Optionaler Schlüssel 9 Unicode Zeichen
   }

   public enum WriteHandValRawDataAndInfoTypes : short
   {
      [SwaggerEnumInfo("Value is a numeric value")]
      Numeric = 0,

      [SwaggerEnumInfo("Value is a alphanumeric value")]
      Text = 1,
   }

}

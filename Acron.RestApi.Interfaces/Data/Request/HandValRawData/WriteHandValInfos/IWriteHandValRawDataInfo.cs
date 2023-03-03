using Acron.RestApi.Interfaces.Data.Request.DayData;
using Swashbuckle.AspNetCore.Annotations;
using System;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValInfos
{
   public interface IWriteHandValRawDataInfo<T> where T : IWriteHandValRawDataInfoFlag
   {
      [SwaggerSchema("Identification of Process Variable")]
      [SwaggerExampleValue(302000003)]
      uint PVID { get; set; }

      [SwaggerSchema("Time stamp of the additional info")]
      [SwaggerExampleValue("2022-10-10T21:44:59")]
      DateTimeOffset TimeStamp { get; set; } //Zeitstempel der Zusatzinfo. Muss zur TimeStamp des Handwertes passen

      DateTime TimeStamp_UTC { get; }

      [SwaggerSchema("Milliseconds")]
      [SwaggerExampleValue(65535)]
      ushort MilliSeconds { get; }

      [SwaggerSchema("Extended properties of this value")]
      [SwaggerExampleValue(typeof(IWriteHandValRawDataInfoFlag))]
      T ProInfoFlag { get; set; }

      //DateTime Edit_TimeStamp { get; set; } //Eingabezeit /Wird von der RestAPI/DBServer versorgt
      //string User { get; set; } //Eingabeuser 29 Unicode Zeichen /Wird von der RestAPI/DBServer versorgt

      [SwaggerSchema("Optional key 9 Unicode characters")]
      [SwaggerExampleValue("abc!")]
      string Key { get; set; }  //Optionaler Schlüssel 9 Unicode Zeichen
   }
}

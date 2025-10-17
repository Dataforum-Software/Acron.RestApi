using Acron.RestApi.Interfaces.Data.Request.DayData;
using Swashbuckle.AspNetCore.Annotations;
using System;

namespace Acron.RestApi.Interfaces.Data.Request.ProcessData
{
   public interface IGetProcessDataPVDescription
   {
      [SwaggerSchema("Numeric ID of Process Variable")]
      [SwaggerExampleValue(302000003)]
      uint PVID { get; set; }

      [SwaggerSchema("Requested type of values")]
      [SwaggerExampleValue(DataValueTypes.Values)]
      DataValueTypes ValueTypes { get; set; }

      [SwaggerSchema("Requested processing of values")]
      [SwaggerExampleValue(DBP_ReadTypes.DBP_WITHOUT_NOVALID)]
      DBP_ReadTypes DBP_ReadType { get; set; }

      [Flags]
      public enum DataValueTypes : short
      {
         [SwaggerEnumInfo("Undefined")]
         Nothing = 0,

         [SwaggerEnumInfo("Contains values")]
         Values = 1,

         [SwaggerEnumInfo("Contains minimums")]
         Minima = 2,

         [SwaggerEnumInfo("Contains maximums")]
         Maxima = 4,
      }

      public enum DBP_ReadTypes : short
      {
         /// <summary>
         /// Prozessdaten gemäß PV-Konfig aufbereitet
         /// </summary>
         [SwaggerEnumInfo("Process values processed according to plant settings")]
         DBP_NORMAL = 1,

         /// <summary>
         /// Prozessdaten gemäß PV-Konfig aufbereitet, mit garantiertem Wert zum Start- und Endzeitpunkt
         /// </summary>
         [SwaggerEnumInfo("Process values processed so that the chosen time frame always contains a valid start and end value")]
         DBP_INCLUDE_FIRST_LAST = 2,

         /// <summary>
         /// Prozessdaten gemäß PV-Konfig aufbereitet ohne leere Werte bei fehlenden Werten
         /// </summary>
         [SwaggerEnumInfo("Process values processed so that all empty results are discarded")]
         DBP_WITHOUT_NOVALID = 3,

         /// <summary>
         /// Prozessrohdaten
         /// </summary>
         [SwaggerEnumInfo("Raw process values")]
         DBP_RAWDATA = 4
      }
   }
}

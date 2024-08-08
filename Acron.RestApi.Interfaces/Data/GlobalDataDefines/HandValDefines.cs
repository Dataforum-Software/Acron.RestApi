using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.GlobalDataDefines
{
   [SwaggerSchema("Data type")]
   public enum HandValRawDataProvalTypes : short
   {
      [SwaggerEnumInfo("Value is a numeric value")]
      Numeric = 0,

      [SwaggerEnumInfo("Value is a alphanumeric value")]
      Text = 1,
   }

   [SwaggerSchema("Comment types")]
   [JsonConverter(typeof(StringEnumConverter))]
   public enum CDAT_Kind : short
   {
      [SwaggerEnumInfo("Daily comment for Process Variable")]     
      CDAT_REMVG = 0,         // comment for VG-handvalue on one day

      [SwaggerEnumInfo("General comment for day, week, month and year")]
      CDAT_REMTM = 1,         // comment for day, week, month and year

      [SwaggerEnumInfo("Comment for service entity hand value")]
      CDAT_REMRT = 2,         // comment for AG-runtime-handvalue, one day

      [SwaggerEnumInfo("Comment for service action hand value")]
      CDAT_REMSS = 4,         // comment for AG-switch-handvalue, one day

      [SwaggerEnumInfo("Value for Manual Variable of type Text")]
      CDAT_VALVG = 5,        // Values für Handwerte-Text
   }
}

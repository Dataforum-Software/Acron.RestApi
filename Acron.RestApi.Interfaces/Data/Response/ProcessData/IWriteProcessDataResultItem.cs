using Acron.RestApi.Interfaces.Data.Request.ProcessData;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.ProcessData
{
   public interface IWriteProcessDataResultItem
   {
      [SwaggerSchema("Time zone ID of Database Server local time")]
      [SwaggerExampleValue("Central European Standard Time")]
      string DBServerTimeZone { get; set; }

      [SwaggerSchema("Earliest time stamp of written values")]
      [SwaggerExampleValue("2022-10-12T01:00:00Z")]
      DateTime From_UTC { get; set; }

      [SwaggerSchema($"{nameof(From_UTC)} time stamp formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.10.2022 01:00:00")]
      string From_FORMATTED { get; set; }

      [SwaggerSchema("Last time stamp of written values")]
      [SwaggerExampleValue("2022-10-12T11:00:00Z")]
      DateTime To_UTC { get; set; }

      [SwaggerSchema($"{nameof(To_UTC)} time stamp formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.10.2022 11:00:00")]
      string To_FORMATTED { get; set; }

      [SwaggerSchema("User friendly error text.")]
      [SwaggerExampleValue("OK")]
      string ErrorText { get; set; }

      [SwaggerSchema("Operation Result")]
      [SwaggerExampleValue(WriteProcessDataErrors.OK)]
      WriteProcessDataErrors Result { get; set; }
   }

   public enum WriteProcessDataErrors : short
   {
      [SwaggerEnumInfo("Operation successful")]
      OK = 0,

      [SwaggerEnumInfo("Handled Error in operation")]
      GeneralError = -1,

      [SwaggerEnumInfo("Unexpected Error in operation")]
      Unknown = short.MinValue,
   }

}

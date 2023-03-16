using Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Configuration.Response
{
   public interface ITimeZoneIDItem
   {
      [SwaggerSchema($"Identification of the time zone")]
      [SwaggerExampleValue("W. Europe Standard Time")]
      string TimeZoneID { get; set; }

      [SwaggerSchema($"User friendly name of the time zone")]
      [SwaggerExampleValue("(UTC+01:00) Amsterdam, Berlin, Bern, Rom, Stockholm, Wien")]
      string DisplayName { get; set; }
   }
}

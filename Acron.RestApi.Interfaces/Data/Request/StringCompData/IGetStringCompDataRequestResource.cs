using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.StringCompData
{
   public interface IGetStringCompDataRequestResource
   {
      [SwaggerSchema("Compression interval to get values for")]
      [SwaggerExampleValue(GetStringCompDataCompTypes.DAY_1)]
      GetStringCompDataCompTypes CompType { get; set; }

      [SwaggerSchema("Start of time range to get values for")]
      [SwaggerExampleValue("2022-10-12T01:00:00Z")]
      DateTimeOffset FromTime { get; set; }

      DateTime FromTime_UTC { get; }

      [SwaggerSchema("End of time range to get values for")]
      [SwaggerExampleValue("2022-10-12T09:00:00Z")]
      DateTimeOffset ToTime { get; set; }

      DateTime ToTime_UTC { get; }

      [SwaggerSchema("List of numeric IDs of process variables to get values for")]
      [SwaggerExampleValue("[302000001, 302000002, 302000003, 302000004]")]
      List<uint> PVIDs { get; set; }
   }
}

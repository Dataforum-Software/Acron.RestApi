using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.StringCompData
{
   public interface IGetCustomIntervalStringDataRequestResource
   {
      [SwaggerSchema("List of process variable IDs")]
      [SwaggerExampleValue(new uint[] { 302000001, 302000002, 302000003 })]
      List<uint> PVIDs { get; set; }

      [SwaggerSchema("Start of time range to get values for")]
      [SwaggerExampleValue("2022-10-12T01:00:00Z")]
      DateTimeOffset FromTime { get; set; }

      DateTime FromTime_UTC { get; }

      [SwaggerSchema("End of time range to get values for")]
      [SwaggerExampleValue("2022-10-12T09:00:00Z")]
      DateTimeOffset ToTime { get; set; }

      DateTime ToTime_UTC { get; }

      [SwaggerSchema("Custom interval in seconds")]
      [SwaggerExampleValue(600)]
      uint Interval { get; set; }

   }
}

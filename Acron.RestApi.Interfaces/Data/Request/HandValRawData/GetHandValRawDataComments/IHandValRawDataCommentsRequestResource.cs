using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.GetHandValRawDataComments
{
   public interface IHandValRawDataCommentsRequestResource
   {
      AVComKinds Kind { get; set; }

      [SwaggerSchema("Start time stamp")]
      [SwaggerExampleValue("2020-08-15T00:00:00Z")]
      DateTimeOffset FromTime { get; set; }

      [SwaggerSchema("End time stamp")]
      [SwaggerExampleValue("2020-08-16T00:00:00Z")]
      DateTimeOffset ToTime { get; set; }

      [SwaggerSchema("List of process variable ids")]
      [SwaggerExampleValue(new int[] { 302000001, 302000005, 302000013, 302000015, 302000016, 302000029 })]
      List<uint> PVIds { get; set; }
   }

}

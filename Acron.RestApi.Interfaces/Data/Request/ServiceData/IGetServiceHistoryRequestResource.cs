using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.ServiceData
{
   public interface IGetServiceHistoryRequestResource
   {
      [SwaggerSchema("Start time stamp")]
      [SwaggerExampleValue("2022-10-12T01:00:00Z")]
      DateTime FromTime { get; set; }

      [SwaggerSchema("End time stamp")]
      [SwaggerExampleValue("2022-10-12T01:00:00Z")]
      DateTime ToTime { get; set; }

      [SwaggerSchema("Flag that determines whether services or repairs are returned")]
      [SwaggerExampleValue(ServiceHistoryFlags.Hist_Service)]
      ServiceHistoryFlags ServiceHistoryFlag { get; set; }

      [SwaggerSchema("List of serice entity IDs")]
      [SwaggerExampleValue(new int[] {})]
      List<uint> ServiceEntityIDs { get; set; }
   }

   [Flags]
   public enum ServiceHistoryFlags : short
   {
      Hist_Service = 1,
      Hist_Repairs = 2,
      Hist_Repairs_Service = 3
   }
}

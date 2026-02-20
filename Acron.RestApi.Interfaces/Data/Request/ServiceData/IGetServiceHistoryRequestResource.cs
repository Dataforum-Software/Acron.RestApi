using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.ServiceData
{
   public interface IGetServiceHistoryRequestResource
   {
      [SwaggerSchema("Start time stamp")]
      [SwaggerExampleValue("2022-10-12T01:00:00Z")]
      DateTimeOffset FromTime { get; set; }

      [SwaggerSchema("End time stamp")]
      [SwaggerExampleValue("2022-10-12T01:00:00Z")]
      DateTimeOffset ToTime { get; set; }

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
      [EnumMember]
      [SwaggerEnumInfo("Service history")]
      Hist_Service = 1,
      [EnumMember]
      [SwaggerEnumInfo("Repair history")]
      Hist_Repairs = 2,
      [EnumMember]
      [SwaggerEnumInfo("Service and repair history")]
      Hist_Repairs_Service = 3
   }
}

using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Common.Request.ChangeProtocol
{
   public interface IGetDataProtocolRequestResource
   {
      [SwaggerSchema("Start of the requested time interval concerning changes")]
      [SwaggerExampleValue("2024-06-17T07:22:37+02:00")]
      DateTime FromTime { get; set; }

      [SwaggerSchema("End of the requested time interval concerning changes")]
      [SwaggerExampleValue("2024-06-17T14:13:56+02:00")]
      DateTime ToTime { get; set; }

      [SwaggerSchema("Start of the requested time interval concerning data")]
      [SwaggerExampleValue("2024-06-17T07:22:37+02:00")]
      DateTime FromTimeData { get; set; }

      [SwaggerSchema("End of the requested time interval concerning data")]
      [SwaggerExampleValue("2024-06-17T14:13:56+02:00")]
      DateTime ToTimeData { get; set; }

      [SwaggerSchema("The user whose changes are requested")]
      [SwaggerExampleValue("acron")]
      string UserShortName { get; set; }

      [SwaggerSchema("Filters for change types")]
      [SwaggerExampleValue(typeof(PROTFILTER_DataProtocol))]
      List<PROTFILTER_DataProtocol> PROTFILTERs { get; set; }
   }


   public enum PROTFILTER_DataProtocol
   {
      [SwaggerEnumInfo("Manual value was changed")]
      ACP_DIAL_HANDVAL = PROTID.ACP_DIAL_HANDVAL,

      [SwaggerEnumInfo("Interval value was changed")]
      ACP_DIAL_INTERVAL = PROTID.ACP_DIAL_INTERVAL,

      [SwaggerEnumInfo("Daily value was changed")]
      ACP_DIAL_DAYVAL = PROTID.ACP_DIAL_DAYVAL,

      [SwaggerEnumInfo("Weekly value was changed")]
      ACP_DIAL_WEEKVAL = PROTID.ACP_DIAL_WEEKVAL,

      [SwaggerEnumInfo("Monthly value was changed")]
      ACP_DIAL_MONVAL = PROTID.ACP_DIAL_MONVAL,

      [SwaggerEnumInfo("Yearly value was changed")]
      ACP_DIAL_YEARVAL = PROTID.ACP_DIAL_YEARVAL,

      [SwaggerEnumInfo("Multiple values were changed")]
      ACP_DIAL_BATCH = PROTID.ACP_DIAL_BATCH,

      [SwaggerEnumInfo("Manual value was changed")]
      ACP_DIAL_SVHANDVAL = PROTID.ACP_DIAL_SVHANDVAL,
   }
}

using Acron.RestApi.Interfaces.Common.Response.ChangeProtocol;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Common.Request.ChangeProtocol
{
   public interface IWriteProtocolDataEntry
   {
      [SwaggerSchema("acron module id")]
      [SwaggerExampleValue(ACRON_MODULE.ACMOD_DESIGNER)]
      ACRON_MODULE Module { get; set; }

      [SwaggerSchema("Time of change")]
      [SwaggerExampleValue("2024-06-17T07:22:37+02:00")]
      DateTimeOffset Timestamp { get; set; }

      DateTime Timestamp_UTC { get; }

      [SwaggerSchema("Name of the property according to the general naming scheme Type -> Area -> Name")]
      [SwaggerExampleValue("umValue.ConfiSetType.Plant")]
      string PropertyName { get; set; }

      [SwaggerSchema("Unique identification of object. ShortName or LongName + Id")]
      [SwaggerExampleValue("denitrifikation")]
      string ObjectIndentification { get; set; }

      [SwaggerSchema("Kind or type of the action")]
      [SwaggerExampleValue(ACP_STATE.ACP_STATE_ACTION)]
      ACP_STATE ActionType { get; set; }

      [SwaggerSchema("Old value which has been overwritten")]
      [SwaggerExampleValue("14.7")]
      string OldValue { get; set; }

      [SwaggerSchema("New value")]
      [SwaggerExampleValue("17.8")]
      string NewValue { get; set; }

   }
}

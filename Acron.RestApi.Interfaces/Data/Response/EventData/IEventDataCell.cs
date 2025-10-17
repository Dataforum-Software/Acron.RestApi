using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.EventData
{
   public interface IEventDataCell
   {
      [SwaggerSchema("String representation of the cell value")]
      [SwaggerExampleValue("ACRON")]
      string ValueString { get; set; }

      [SwaggerSchema("Is the cell marked?")]
      [SwaggerExampleValue(true)]
      bool IsMarkerSet { get; set; }

      [SwaggerSchema("Is the marking color valid?")]
      [SwaggerExampleValue(true)]
      bool IsColorValid { get; set; }

      [SwaggerSchema("Marking color")]
      [SwaggerExampleValue(4294967040)]
      uint Color { get; set; }

      [SwaggerSchema("Marking color for report")]
      [SwaggerExampleValue(4294967040)]
      uint ColorReport { get; set; }

   }
}

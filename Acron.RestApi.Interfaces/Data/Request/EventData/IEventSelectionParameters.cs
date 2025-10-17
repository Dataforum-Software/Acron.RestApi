using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.EventData
{
   public interface IEventSelectionParameters
   {
      [SwaggerSchema("Start time stamp")]
      [SwaggerExampleValue("2022-10-12T01:00:00Z")]
      DateTime FromTime { get; set; }

      [SwaggerSchema("End time stamp")]
      [SwaggerExampleValue("2022-10-18T01:00:00Z")]
      DateTime ToTime { get; set; }

      [SwaggerSchema("Unique short name of the event")]
      [SwaggerExampleValue("Event_1")]
      string ShortName { get; set; }

      [SwaggerSchema("Unique (per event) batch identifier")]
      [SwaggerExampleValue("0001")]
      string BatchId { get; set; }

      [SwaggerSchema("Specific filter formula of the event")]
      [SwaggerExampleValue("Event_1")]
      string Formula { get; set; }

      [SwaggerSchema("Event filter type")]
      [SwaggerExampleValue(EventFilters.ALL)]
      EventFilters Filter { get; set; }

      [SwaggerSchema("Event read options")]
      [SwaggerExampleValue(ReadOptions.READ_SUB)]
      ReadOptions ReadOptions { get; set; }

   }
}

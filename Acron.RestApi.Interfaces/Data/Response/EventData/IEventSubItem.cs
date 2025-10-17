using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.EventData
{
   public interface IEventSubItem<V, W, X> where V : IEventCell where W : IEventDataItem<X> where X : IEventDataCell
   {
      [SwaggerSchema("Name of the Subevent")]
      [SwaggerExampleValue("ExampleEvent01A")]
      public string SubEventName { get; set; }

      [SwaggerSchema("Optional accending batch ID")]
      [SwaggerExampleValue("0001")]
      string BatchId { get; set; }

      [SwaggerSchema("Base flags of the event")]
      [SwaggerExampleValue("2022-10-12T01:00:00Z")]
      EventBaseFlags EventBaseFlags { get; set; }

      [SwaggerSchema("Start time stamp")]
      [SwaggerExampleValue("2022-10-12T01:00:00Z")]
      DateTime FromTime { get; set; }

      [SwaggerSchema($"{nameof(FromTime)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("18.10.2022 1:00:00")]
      string FromTime_FORMATTED { get; set; }

      [SwaggerSchema("End time stamp")]
      [SwaggerExampleValue("2022-10-18T01:00:00Z")]
      DateTime ToTime { get; set; }

      [SwaggerSchema($"{nameof(ToTime)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("18.10.2022 1:00:00")]
      string ToTime_FORMATTED { get; set; }

      [SwaggerSchema($"Milliseconds value for increased accuracy of {nameof(ToTime)}")]
      [SwaggerExampleValue(788)]
      short FromMilliseconds { get; set; }

      [SwaggerSchema($"Milliseconds value for increased accuracy of {nameof(FromTime)}")]
      [SwaggerExampleValue(141)]
      short ToMilliseconds { get; set; }

      [SwaggerSchema("Flags of the event")]
      [SwaggerExampleValue("2022-10-12T01:00:00Z")]
      EventFlags EventFlags { get; set; }

      [SwaggerSchema("List of associated event cells")]
      [SwaggerExampleValue(true)]
      List<V> SubEventCells { get; set; }

      [SwaggerSchema("Maximum number of data rows")]
      [SwaggerExampleValue(1000)]
      int MaximumDataRows { get; set; }

      [SwaggerSchema("Total number of data rows")]
      [SwaggerExampleValue(5000)]
      int DataColumns { get; set; }

      [SwaggerSchema("List of data items")]
      [SwaggerExampleValue(typeof(IEventDataItem<IEventDataCell>))]
      List<W> DataItems { get; set; }


   }
}

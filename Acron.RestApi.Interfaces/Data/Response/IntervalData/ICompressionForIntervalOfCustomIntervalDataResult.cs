using Acron.RestApi.Interfaces.Data.Response.DayData;
using Acron.RestApi.Interfaces.Data.Response.MonthWeekData;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.IntervalData
{
   public interface ICompressionForIntervalOfCustomIntervalDataResult<T, U, V> where T : ICompressionForIntervalOfCustomIntervalData<U, V> where U : ICompressionForIntervalOfCustomIntervalDataFlag_Day where V : ICompressionForIntervalOfCustomIntervalDataFlag_Interval
   {
      [SwaggerSchema($"Status of the operation")]
      [SwaggerExampleValue(GaugeMsg.GStart)]
      GaugeMsg Status { get; set; }

      [SwaggerSchema($"Unique ID on a running compression. Can sed to receive status information or retrieve the result.")]
      [SwaggerExampleValue("d9262d90-5feb-4d55-b9b8-2b12093abd25")]
      Guid ResultID { get; set; }

      [SwaggerSchema($"If the result is not returned instantantly, this field represents the progress (in %) of the DBEngine's compression")]
      [SwaggerExampleValue(97)]
      uint Progress { get; set; }

      [SwaggerSchema($"Information about the current state of the operation")]
      [SwaggerExampleValue("Result was returned in time")]
      string Message { get; set; }

      [SwaggerSchema($"The compressions is either queued or currently running.")]
      [SwaggerExampleValue("QUEUED")]
      DBEngOperation QueueStatus { get; set; }

      [SwaggerSchema($"Collection of compression data objects, one per process variable")]
      [SwaggerExampleValue(typeof(ICompressionForIntervalOfCustomIntervalData<ICompressionForIntervalOfCustomIntervalDataFlag_Day, ICompressionForIntervalOfCustomIntervalDataFlag_Interval>))]
      List<T> Values { get; set; }
   }
}

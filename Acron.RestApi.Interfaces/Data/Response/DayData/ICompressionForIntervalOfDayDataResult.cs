using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.DayData
{
   public interface ICompressionForIntervalOfDayDataResult<T, U> where T : ICompressionForIntervalOfDayData<U> where U : ICompressionForIntervalOfDayDataFlag
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
      [SwaggerExampleValue(typeof(ICompressionForIntervalOfDayData<ICompressionForIntervalOfDayDataFlag>))]
      List<T> Values { get; set; }
   }

   [DataContract]
   public enum GaugeMsg : int
   {
      [EnumMember]
      [SwaggerEnumInfo("Main operation started")]
      GStart = 1,       // dwWhat: 0, USECANCEL		pszText: verwendet

      [EnumMember]
      [SwaggerEnumInfo("Main operation started")]
      GStop = 2,        // dwWhat: 0

      [EnumMember]
      [SwaggerEnumInfo("Main operation started")]
      GSet = 3,         // dwWhat: 0-100

      [EnumMember]
      [SwaggerEnumInfo("Main operation started")]
      GSubStart = 4,    // dwWhat: 0						pszText: verwendet

      [EnumMember]
      [SwaggerEnumInfo("Main operation started")]
      GSubStop = 5,     // dwWhat: 0

      [EnumMember]
      [SwaggerEnumInfo("Main operation started")]
      GSubSet = 6,      // dwWhat: 0-100

      [EnumMember]
      [SwaggerEnumInfo("Main operation started")]
      GCaptionText = 7, // dwWhat: 0						pszText: verwendet

      [EnumMember]
      [SwaggerEnumInfo("Main operation started")]
      GButtonText = 8   // dwWhat: 0						pszText: verwendet
   }

   [DataContract]
   public enum DBEngOperation : int
   {
      [EnumMember]
      [SwaggerEnumInfo("The operation is currently queued and will be processed after all previous operations are finished.")]
      QUEUED = 0,

      [EnumMember]
      [SwaggerEnumInfo("The operation is currently worked on by the DBEngine.")]
      CURRENT = 1
   }
}

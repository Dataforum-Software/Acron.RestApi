using Acron.RestApi.Interfaces.Data.Response.DayData;
using Acron.RestApi.Interfaces.Data.Response.MonthWeekData;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.MonthWeekData
{
   [DataContract]
   public class CompressionForIntervalOfMonthWeekDataResult : ICompressionForIntervalOfMonthWeekDataResult<CompressionForIntervalOfMonthWeekData, CompressionForIntervalOfMonthWeekDataFlag>
   {
      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public GaugeMsg Status { get; set; }

      [DataMember]
      public Guid ResultID { get; set; }

      [DataMember]
      public uint Progress { get; set; }

      [DataMember]
      public string Message { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      [DefaultValue(1)]
      public DBEngOperation QueueStatus { get; set; }

      [DataMember]
      public List<CompressionForIntervalOfMonthWeekData> Values { get; set; }
   }
}

using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.EventData;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.EventData
{
   [DataContract]
   public class EventItem : IEventItem<EventSubItem, EventCell, EventDataItem, EventDataCell>
   {
      [DataMember]
      public string ShortName { get; set; }

      [DataMember]
      public int EventId { get; set; }

      [DataMember]
      public string BatchId { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public EventBaseFlags EventBaseFlags { get; set; }

      [DataMember]
      [FormatDateTime(nameof(FromTime_FORMATTED), DateTimeFormatType.Default)]
      public DateTime FromTime { get; set; }

      [DataMember]
      public string FromTime_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(ToTime_FORMATTED), DateTimeFormatType.Default)]
      public DateTime ToTime { get; set; }

      [DataMember]
      public string ToTime_FORMATTED { get; set; }

      [DataMember]
      public short FromMilliseconds { get; set; }

      [DataMember]
      public short ToMilliseconds { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public EventFlags EventFlags { get; set; }

      [DataMember]
      public List<EventCell> EventCells { get; set; }

      [DataMember]
      public List<EventSubItem> SubItems { get; set; }

      [DataMember]
      public int MaximumDataRows { get; set; }

      [DataMember]
      public int DataColumns { get; set; }

      [DataMember]
      public List<EventDataItem> DataItems { get; set; }
   }
}

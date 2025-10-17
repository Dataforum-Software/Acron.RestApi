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
   public class GetEventDataResult : IGetEventDataResult<EventItem, EventSubItem, EventCell, EventDataItem, EventDataCell>
   {
      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public EventErrorType EventStatus { get; set; }

      [DataMember]
      public List<EventItem> EventItems { get; set; }
   }


}

